using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OutlineStorming
{
    internal class DeepLCall
    {
        private static string ep_free = "https://api-free.deepl.com/v2/translate";
        private static string ep_pro = "https://api.deepl.com/v2/translate";

        private static string currentAuthkey = Properties.Settings.Default.deepLAuthKey;
        private static bool currentFreeProFlg = Properties.Settings.Default.deepLFreeProFlg;
        private static int currentTimeout = Properties.Settings.Default.deepLTimeout;

        private static string currentUserLang = Properties.Settings.Default.deepLUserLang;
        private static string currentGPTLang = Properties.Settings.Default.deepLGPTLang;
        private static bool currentUserLangAuto = Properties.Settings.Default.deepLUserLangAuto;
        private static bool currentGPTLangAuto = Properties.Settings.Default.deepLGPTLangAuto;

        internal enum translateType
        {
            TRANSLATE_TYPE_SEND,
            TRANSLATE_TYPE_RET
        }

        private class Responsedata
        {
            [JsonPropertyName("translations")]
            public Translatedata[] translations { get; set; }
        }

        private class Translatedata
        {
            [JsonPropertyName("tetected_source_language")]
            public string detected_source_language { get; set; }

            [JsonPropertyName("text")]
            public string text { get; set; }
        }


        public static async Task<string[]> CallDeepLTranslateAsync(string req, translateType msgType, IHttpClientFactory clientFactory)
        {
            string currentSrcLang = currentUserLang;
            string currentDstLang = currentGPTLang;
            if (msgType== translateType.TRANSLATE_TYPE_RET)
            {
                currentSrcLang = currentGPTLang;
                currentDstLang = currentUserLang;
            }
            if (currentSrcLang == "PT-BR" || currentSrcLang == "PT-PT")
            {
                currentSrcLang = "PT";
            }
            else if (currentSrcLang == "EN-GB" || currentSrcLang == "EN-US")
            {
                currentSrcLang = "EN";
            }

            string endpoint = currentFreeProFlg ? ep_pro : ep_free;
            var request = new HttpRequestMessage(HttpMethod.Post, endpoint);
            var contentList = new List<string>
            {
                "auth_key=" + currentAuthkey,
//                "source_lang=" + currentSrcLang,
                "text=" + req,
                "target_lang=" + currentDstLang
            };
            if (!currentUserLangAuto && msgType == translateType.TRANSLATE_TYPE_SEND)
            {
                contentList.Add("source_lang=" + currentSrcLang);
            }
            else if (!currentGPTLangAuto && msgType == translateType.TRANSLATE_TYPE_RET)
            {
                contentList.Add("source_lang=" + currentSrcLang);
            }
            request.Content = new StringContent(string.Join("&", contentList));
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded");

            HttpClient client = clientFactory.CreateClient("DeepL_API_Pro");
            client.Timeout = TimeSpan.FromMilliseconds(currentTimeout*1000);

            HttpResponseMessage response = await client.SendAsync(request);
            string responseBody = await response.Content.ReadAsStringAsync();
            string[] ret_data = new string[2];
            ret_data[0] = response.StatusCode.ToString();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonoptions = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                Responsedata responsedata = JsonSerializer.Deserialize<Responsedata>(responseBody, jsonoptions);
                ret_data[1] = responsedata.translations[0].text;
            }
            else
            {
                if (string.IsNullOrEmpty(response.ReasonPhrase))
                {
                    ret_data[1] = "CallDeepLTranslateAsync : Some errors has occurred.";
                }
                else
                {
                    ret_data[1] = response.ReasonPhrase;
                }
            }
            return ret_data;
        }

        public static void SetAuthKey(string authKey)
        {
            if (string.IsNullOrWhiteSpace(authKey))
            {
                return;
            }
            currentAuthkey = authKey;
        }

        public static void SetFreeProFlag(bool freeProFlag)
        {
            currentFreeProFlg = freeProFlag;
        }

        public static void SetTimeout(int timeout)
        {
            currentTimeout = timeout;
        }

        public static void SetSrcLang(string srcLang)
        {
            currentUserLang = srcLang;
        }

        public static void SetDstLang(string dstLang)
        {
            currentGPTLang = dstLang;
        }

        public static void SetUserLangAuto(bool userLangAuto)
        {
            currentUserLangAuto = userLangAuto;
        }

        public static void SetGPTLangAuto(bool gptLangAuto)
        {
            currentGPTLangAuto = gptLangAuto;
        }
    }
}
