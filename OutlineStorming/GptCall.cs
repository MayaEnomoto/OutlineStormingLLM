using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace OutlineStorming
{
    public class GptCall
    {
        private static string currentAuthkey = Properties.Settings.Default.dataAuthKey;
        private static string currentSystem = Properties.Settings.Default.dataGPTsystem;
        private static string currentModel = Properties.Settings.Default.dataGPTmodel;
        private static int currentTimeout = Properties.Settings.Default.dataGPTTimeout;
        private static List<object> messageHistory = new List<object>();

        public static void ForEachMessage(Action<string, string> action)
        {
            foreach (var message in messageHistory)
            {
                if (message is JsonElement messageElement)
                {
                    Dictionary<string, object> messageDict = JsonSerializer.Deserialize<Dictionary<string, object>>(messageElement.GetRawText());
                    if (messageDict != null && messageDict.ContainsKey("role"))
                    {
                        string role = messageDict["role"].ToString();
                        string content = messageDict["content"].ToString();
                        action(role, content);
                    }
                }
            }
        }

        public static List<object> GetMessageHistory()
        {
            return new List<object>(messageHistory);
        }

        public static void SetMessageHistory(List<object> newMessageHistory)
        {
            messageHistory = new List<object>(newMessageHistory);
        }

        public static void RemoveMessageAtIndex(int index)
        {
            if (index >= 0 && index < messageHistory.Count)
            {
                messageHistory.RemoveAt(index);
            }
        }

        public static void SaveMessageHistoryToFile(string filePath)
        {
            //string jsonString = JsonSerializer.Serialize(messageHistory, new JsonSerializerOptions { WriteIndented = true });
            //File.WriteAllText(filePath, jsonString);
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            string jsonString = JsonSerializer.Serialize(messageHistory, options);
            File.WriteAllText(filePath, jsonString);
        }

        public static void LoadMessageHistoryFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                messageHistory = JsonSerializer.Deserialize<List<object>>(jsonString);
            }
        }

        public static List<Dictionary<string, object>> GetMessages()
        {
            List<Dictionary<string, object>> allMessages = new List<Dictionary<string, object>>();

            foreach (var message in messageHistory)
            {
                if (message is JsonElement messageElement)
                {
                    Dictionary<string, object> messageDict = JsonSerializer.Deserialize<Dictionary<string, object>>(messageElement.GetRawText());
                    if (messageDict != null && messageDict.ContainsKey("role"))
                    {
                        allMessages.Add(messageDict);
                    }
                }
            }

            return allMessages;
        }

        public static async Task<string> CallGptAsync(string req, IHttpClientFactory clientFactory)
        {
            IHttpClientFactory _clientFactory = clientFactory;
            string endpoint = "https://api.openai.com/v1/chat/completions";
            var request = new HttpRequestMessage(HttpMethod.Post, endpoint);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", currentAuthkey);

            addRequest(req);

            //string jsonContent = JsonSerializer.Serialize(new
            //{
            //    model = currentModel,
            //    messages = messageHistory.ToArray()
            //});
            string jsonContent = JsonSerializer.Serialize(new
            {
                model = currentModel,
                messages = messageHistory.Where(message => {
                    if (message is JsonElement messageElement)
                    {
                        Dictionary<string, object> messageDict = JsonSerializer.Deserialize<Dictionary<string, object>>(messageElement.GetRawText());
                        if (messageDict != null && messageDict.ContainsKey("role"))
                        {
                            string role = messageDict["role"].ToString();
                            return role != "assistant_after_translation" && role != "user_before_translation";
                        }
                    }
                    return false;
                }).ToArray()
            });

            request.Content = new ByteArrayContent(System.Text.Encoding.UTF8.GetBytes(jsonContent));
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpClient client = _clientFactory.CreateClient();
            client.Timeout = TimeSpan.FromMilliseconds(currentTimeout * 1000);

            HttpResponseMessage response = await client.SendAsync(request);
            string responseBody = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonoptions = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                var responsedata = JsonSerializer.Deserialize<ResponseData>(responseBody, jsonoptions);

                if (responsedata == null)
                {
                    return "<Error>\r\nunexpected error occurred.\r\nPlease check your network connection.";
                }
                addResponse(responsedata.choices[0].message.content);
                return responsedata.choices[0].message.content;
            }
            else
            {
                //throw new Exception(response.ReasonPhrase);
                string errorMessage = $"<Error>\r\nStatus Code: {response.StatusCode}\r\nReason: {response.ReasonPhrase}\r\nPlease check gpt setting and network connection.";
                return errorMessage;
            }
        }

        public static bool hasHistory()
        {
            if (messageHistory.Count > 0)
            {
                return true;
            }
            return false;
        }

        public static void clearHistory()
        {
            messageHistory.Clear();
            currentAuthkey = Properties.Settings.Default.dataAuthKey;
            currentSystem = Properties.Settings.Default.dataGPTsystem;
            currentModel = Properties.Settings.Default.dataGPTmodel;
            currentTimeout = Properties.Settings.Default.dataGPTTimeout;
        }

        public static void setAuthkey(string authkey)
        {
            if (String.IsNullOrWhiteSpace(authkey))
            {
                return;
            }
            currentAuthkey = authkey;
        }

        public static void setRole(string sys)
        {
            if (String.IsNullOrWhiteSpace(sys))
            {
                return;
            }
            string json = JsonSerializer.Serialize(new { role = "system", content = sys });
            JsonDocument document = JsonDocument.Parse(json);
            messageHistory.Add(document.RootElement);
        }

        public static void setModel(string model)
        {
            if (String.IsNullOrWhiteSpace(model))
            {
                return;
            }
            currentModel = model;
        }

        public static void setTimeout(int timeout)
        {
            currentTimeout = timeout;
        }

        private static void addRequest(string req)
        {
            if (String.IsNullOrWhiteSpace(req))
            {
                return;
            }
            string json = JsonSerializer.Serialize(new { role = "user", content = req });
            JsonDocument document = JsonDocument.Parse(json);
            messageHistory.Add(document.RootElement);
        }

        private static void addResponse(string ans)
        {
            if (String.IsNullOrWhiteSpace(ans))
            {
                return;
            }
            string json = JsonSerializer.Serialize(new { role = "assistant", content = ans });
            JsonDocument document = JsonDocument.Parse(json);
            messageHistory.Add(document.RootElement);

        }

        public static void AddMessageToHistory(string role, string content)
        {
            if (String.IsNullOrWhiteSpace(content))
            {
                return;
            }
            string json = JsonSerializer.Serialize(new { role = role, content = content });
            JsonDocument document = JsonDocument.Parse(json);
            messageHistory.Add(document.RootElement);
        }

        public static void updateGPTSettings(string authkey, string sys, string model, int timeout)
        {
            setAuthkey(authkey);
            setRole(sys);
            setModel(model);
            setTimeout(timeout);
        }

        public static void setBaseParam(string authkey, string sys, string model, int timeout,List<string> messageList)
        {
            clearHistory();
            setAuthkey(authkey);
            setRole(sys);
            setModel(model);
            setTimeout(timeout);
            foreach (var input in messageList)
            {
                string json = JsonSerializer.Serialize(new { role = "user", content = input });
                JsonDocument document = JsonDocument.Parse(json);
                messageHistory.Add(document.RootElement);
            }
        }

        private class ResponseData
        {
            [JsonPropertyName("choices")]
            public ChoiceData[] choices { get; set; }
        }

        private class ChoiceData
        {
            [JsonPropertyName("message")]
            public MessageData message { get; set; }
        }

        private class MessageData
        {
            [JsonPropertyName("content")]
            public string content { get; set; }
        }
    }
}
