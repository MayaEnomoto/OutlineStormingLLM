using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Csv;
using System.Text;
using System.Text.Encodings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;
using System.Reflection.Emit;
using System.Security.Cryptography.Xml;
using System.Diagnostics.Eventing.Reader;
using System.Text.Json;

namespace OutlineStorming
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;
        private BindingSource bindingSource;

        private string ApiKey = Properties.Settings.Default.dataAuthKey;
        private string Model = Properties.Settings.Default.dataGPTmodel;
        private string System = Properties.Settings.Default.dataGPTsystem;

        public Form1()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();
            InitializeDataTable();
        }

        private void InitializeDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("OriginalIndex", typeof(int));
            dataTable.Columns.Add("Type");
            dataTable.Columns.Add("Value");
            dataTable.Columns.Add("Note");
            dataTable.Columns.Add("IsChecked", typeof(bool));
            dataTable.Columns["IsChecked"].DefaultValue = true;

            bindingSource = new BindingSource { DataSource = dataTable };
            dataGridView.DataSource = bindingSource;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns["Note"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.Columns["OriginalIndex"].Visible = false;
            dataGridView.Columns["IsChecked"].HeaderText = "\u2611";

            dataGridView.Columns["Type"].ReadOnly = true;
            dataGridView.Columns["Value"].ReadOnly = true;
            dataGridView.Columns["Note"].ReadOnly = true;

            dataGridView.AllowUserToResizeColumns = true;
            dataGridView.AllowUserToResizeRows = true;
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Add();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        dataGridView.Rows.RemoveAt(row.Index);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select the entire row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dataGridView.PointToClient(new Point(e.X, e.Y));
            int destRowIndex = dataGridView.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            if (destRowIndex != -1)
            {
                DataRow row = (DataRow)e.Data.GetData(typeof(DataRow));
                DataRow newRow = dataTable.NewRow();
                newRow.ItemArray = row.ItemArray;
                dataTable.Rows.RemoveAt(row.Table.Rows.IndexOf(row));
                dataTable.Rows.InsertAt(newRow, destRowIndex);
            }
        }

        private void dataGridView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hitTestInfo = dataGridView.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex != -1 && hitTestInfo.RowIndex < dataTable.Rows.Count)
                {
                    dataGridView.DoDragDrop(dataTable.Rows[hitTestInfo.RowIndex], DragDropEffects.Move);
                }
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                txtType.Text = selectedRow.Cells["Type"].Value.ToString();
                txtValue.Text = selectedRow.Cells["Value"].Value.ToString();
                txtNote.Text = selectedRow.Cells["Note"].Value.ToString();
                txtType.Enabled = true;
                txtValue.Enabled = true;
                txtNote.Enabled = true;
            }
            else
            {
                txtType.Text = "";
                txtValue.Text = "";
                txtNote.Text = "";
                txtType.Enabled = false;
                txtValue.Enabled = false;
                txtNote.Enabled = false;
            }
        }

        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = dataGridView.Columns[e.ColumnIndex];
            ListSortDirection sortDirection;

            if (column.HeaderCell.SortGlyphDirection == SortOrder.Ascending)
            {
                sortDirection = ListSortDirection.Descending;
            }
            else
            {
                sortDirection = ListSortDirection.Ascending;
            }

            dataGridView.Sort(column, sortDirection);
        }

        private void btnResetSort_Click(object sender, EventArgs e)
        {
            DataView dataView = dataTable.DefaultView;
            dataView.Sort = "OriginalIndex ASC";
            dataTable = dataView.ToTable();
            dataGridView.DataSource = dataTable;
            dataGridView.Columns["OriginalIndex"].Visible = false;
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;
                if (selectedIndex > 0)
                {
                    DataRow row = dataTable.Rows[selectedIndex];
                    DataRow newRow = dataTable.NewRow();
                    newRow.ItemArray = row.ItemArray;
                    dataTable.Rows.RemoveAt(selectedIndex);
                    dataTable.Rows.InsertAt(newRow, selectedIndex - 1);
                    dataGridView.ClearSelection();
                    dataGridView.Rows[selectedIndex - 1].Selected = true;
                }
            }
            else
            {
                MessageBox.Show("Please select the entire row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;
                if (selectedIndex < dataTable.Rows.Count - 1)
                {
                    DataRow row = dataTable.Rows[selectedIndex];
                    DataRow newRow = dataTable.NewRow();
                    newRow.ItemArray = row.ItemArray;
                    dataTable.Rows.RemoveAt(selectedIndex);
                    dataTable.Rows.InsertAt(newRow, selectedIndex + 1);
                    dataGridView.ClearSelection();
                    dataGridView.Rows[selectedIndex + 1].Selected = true;
                }
            }
            else
            {
                MessageBox.Show("Please select the entire row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["IsChecked"].Index && e.RowIndex >= 0)
            {
                bool currentValue = dataGridView.Rows[e.RowIndex].Cells["IsChecked"].Value == DBNull.Value ? false : (bool)dataGridView.Rows[e.RowIndex].Cells["IsChecked"].Value;
                dataGridView.Rows[e.RowIndex].Cells["IsChecked"].Value = !currentValue;
            }
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitTestInfo = dataGridView.HitTest(e.X, e.Y);

            if (hitTestInfo.Type == DataGridViewHitTestType.Cell &&
                hitTestInfo.ColumnIndex == dataGridView.Columns["IsChecked"].Index &&
                hitTestInfo.RowIndex >= 0)
            {
                dataGridView.Rows[hitTestInfo.RowIndex].Cells["IsChecked"].Value =
                    !(bool)dataGridView.Rows[hitTestInfo.RowIndex].Cells["IsChecked"].Value;
            }
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                selectedRow.Cells["Type"].Value = txtType.Text;
            }
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                selectedRow.Cells["Value"].Value = txtValue.Text;
            }
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                selectedRow.Cells["Note"].Value = txtNote.Text;
            }
        }

        private async Task ProcessGptAsync(string explanation)
        {
            IServiceCollection services = new ServiceCollection();
            services.AddHttpClient();
            var provider = services.BuildServiceProvider();
            IHttpClientFactory _clientFactory = provider.GetRequiredService<IHttpClientFactory>();


            if (String.IsNullOrWhiteSpace(OutputHistory.Text))
            {
                var inputs = new List<string>();
                var checkedRows = new List<DataRow>();
                foreach (DataRow row in dataTable.Rows)
                {
                    if ((bool)row["IsChecked"])
                    {
                        String inputValue = "Type = " + row["Type"].ToString() + "\nValue = " + row["Value"].ToString() + "\nNote = " + row["Note"].ToString();
                        inputs.Add(inputValue);
                        checkedRows.Add(row);
                    }
                }
                //if (checkedRows.Count == 0)
                //{
                //    return;
                //}
                GptCall.setBaseParam(Properties.Settings.Default.dataAuthKey, Properties.Settings.Default.dataGPTsystem, Properties.Settings.Default.dataGPTmodel, Properties.Settings.Default.dataGPTTimeout, inputs);
            }

            if (String.IsNullOrWhiteSpace(explanation))
            {
                DialogResult result = MessageBox.Show("Please set request to GPT.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);
                return;
            }

            OutputHistory.Focus();
            OutputHistory.AppendText("\r\n\r\n<You>\r\n" + textBoxRequest.Text);


            //string retGPT = await GptCall.CallGptAsync(explanation, _clientFactory);
            // GptCall.CallGptAsyncメソッドを別のスレッドで呼び出す
            Task<string> task = Task.Run(() => GptCall.CallGptAsync(explanation, _clientFactory));
            FormLoading formLoading = new FormLoading();
            formLoading.Show();
            string retGPT = await task;
            OutputHistory.AppendText("\r\n\r\n<GPT>\r\n" + retGPT.Replace("\n", "\r\n"));
            formLoading.Close();
        }

        private async void btnSendRequest_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            await ProcessGptAsync(textBoxRequest.Text);
            textBoxRequest.Text = "";
            this.Enabled = true;
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            OutputHistory.Text = "";
            textBoxRequest.Text = "";
            GptCall.clearHistory();
        }

        private void checkBoxView_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkBox = (CheckBox)sender;
            if (chkBox.Checked)
            {
                dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells);
                dataGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            else
            {
                int minimumHeight = (int)Form1.DefaultFont.GetHeight() + 9;

                dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells);
                dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    row.Height = minimumHeight;
                }
            }
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Enter a new data set.\r\nAll currently loaded data will be cleared, is that OK?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                dataTable.Clear();
                OutputHistory.Text = "";
                textBoxRequest.Text = "";
                GptCall.clearHistory();
            }
            else
            {
                ;
            }
        }

        private void openCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFormat formFormat = new FormFormat();
            DialogResult result = formFormat.ShowDialog(this);
            formFormat.Dispose();
            if (result == DialogResult.Cancel)
            {
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV file (*.csv)|*.csv|All file (*.*)|*.*",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataTable.Clear();

                int index = 0;
                CsvOptions options = new CsvOptions();
                if (Properties.Settings.Default.formatSeparator == 2)
                {
                    options.Separator = '\u0001';
                }
                else if (Properties.Settings.Default.formatSeparator == 1)
                {
                    options.Separator = ',';
                }
                else
                {
                    options.Separator = '\t';
                }
                options.HeaderMode = HeaderMode.HeaderAbsent;
                options.AllowNewLineInEnclosedFieldValues = true;
                if (Properties.Settings.Default.formatNewLine == 1)
                {
                    options.NewLine = "\r\n";
                }
                else
                {
                    options.NewLine = "\n";
                }
                string csvText;
                if (Properties.Settings.Default.formatUTF == 1)
                {
                    csvText = File.ReadAllText(openFileDialog.FileName);
                }
                else
                {
                    csvText = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);
                }
                foreach (var line in CsvReader.ReadFromText(csvText, options))
                {
                    if (line.ColumnCount >= 3)
                    {
                        if (Properties.Settings.Default.formatExtendedRead == true && line.ColumnCount >= 4)
                        {
                            string content = "";
                            for (int cnt = 2; cnt < line.ColumnCount; cnt++)
                            {
                                string header = "\\nNote" + cnt.ToString() + "= ";
                                content += header;
                                content += line[cnt];
                            }
                            dataTable.Rows.Add(index, line[0], line[1], content, true);
                        }
                        else
                        {
                            dataTable.Rows.Add(index, line[0], line[1], line[2], true);
                        }
                    }
                    else if (line.ColumnCount >= 2)
                    {
                        dataTable.Rows.Add(index, line[0], line[1], "", true);
                    }
                    else if (line.ColumnCount >= 1)
                    {
                        dataTable.Rows.Add(index, line[0], "", "", true);
                    }
                    else
                    {
                        dataTable.Rows.Add(index, "", "", "", true);
                    }
                    index++;
                }

                if (checkBoxView.Checked)
                {
                    dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    dataGridView.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells);
                    dataGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                    dataGridView.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCells);
                }
            }

        }

        private void saveCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFormat formFormat = new FormFormat();
            DialogResult result = formFormat.ShowDialog(this);
            formFormat.Dispose();
            if (result == DialogResult.Cancel)
            {
                return;
            }


            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV file (*.csv)|*.csv|All file (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                int index = 0;
                string[][] exportdata = new string[dataGridView.Rows.Count][];
                CsvOptions options = new CsvOptions();
                if (Properties.Settings.Default.formatSeparator == 2)
                {
                    options.Separator = '\u0001';
                }
                else if (Properties.Settings.Default.formatSeparator == 2)
                {
                    options.Separator = ',';
                }
                else
                {
                    options.Separator = '\t';
                }
                options.HeaderMode = HeaderMode.HeaderAbsent;
                options.AllowNewLineInEnclosedFieldValues = true;
                if (Properties.Settings.Default.formatNewLine == 1)
                {
                    options.NewLine = "\r\n";
                }
                else
                {
                    options.NewLine = "\n";
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    string[] values = row.ItemArray.Select(i => i.ToString()).ToArray();
                    exportdata[index] = new string[] { values[1], values[2], values[3] };
                    index++;
                }

                string s_csv = null;
                string[] header = { "Type", "Value", "Note" };
                s_csv = CsvWriter.WriteToText(header, exportdata, options.Separator, true);
                if (Properties.Settings.Default.formatUTF == 1)
                {
                    File.WriteAllText(saveFileDialog.FileName, s_csv);
                }
                else
                {
                    File.WriteAllText(saveFileDialog.FileName, s_csv, Encoding.UTF8);
                }
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFormat formFormat = new FormFormat();
            formFormat.ShowDialog(this);
            formFormat.Dispose();
        }

        private void gPTSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGPTSetting formGPTSetting = new FormGPTSetting();
            formGPTSetting.ShowDialog(this);
            formGPTSetting.Dispose();
            GptCall.updateGPTSettings(Properties.Settings.Default.dataAuthKey, Properties.Settings.Default.dataGPTsystem, Properties.Settings.Default.dataGPTmodel, Properties.Settings.Default.dataGPTTimeout);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            dataGridView.Rows[e.RowIndex].Selected = true;
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Message History";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    GptCall.SaveMessageHistoryToFile(filePath);
                }
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Re-input the Message history.\r\nThe current work data will be cleared.\r\nIs that ok?\r\n*In the current version, reading the history is not reflected in the DataSet.",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                ;
            }
            else
            {
                return;
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Input Message History";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dataTable.Clear();
                    OutputHistory.Text = "";
                    textBoxRequest.Text = "";
                    GptCall.clearHistory();

                    string filePath = openFileDialog.FileName;
                    GptCall.LoadMessageHistoryFromFile(filePath);

                    List<Dictionary<string, object>> messages = GptCall.GetMessages();
                    for (int i = 0; i < messages.Count; i++)
                    {
                        var message = messages[i];
                        string role = message.ContainsKey("role") ? message["role"].ToString() : "";

                        if (role == "user")
                        {
                            string content = message.ContainsKey("content") ? message["content"].ToString() : "";

                            // Extract Type, Value, and Note from the content
                            string[] lines = content.Split('\n');
                            string type = lines.Length > 0 ? lines[0].Replace("Type = ", "").Trim() : "";
                            string value = lines.Length > 1 ? lines[1].Replace("Value = ", "").Trim() : "";
                            string note = lines.Length > 2 ? string.Join("\n", lines.Skip(2)).Replace("Note = ", "").Trim() : "";

                            // Add a new row to the DataTable with the data
                            dataTable.Rows.Add(i, type, value, note, true);
                        }
                        else if (role == "assistant" && dataTable.Rows.Count > 0)
                        {
                            // Remove the last row added to the DataTable
                            dataTable.Rows.RemoveAt(dataTable.Rows.Count - 1);
                            for (int j = i - 1; j < messages.Count; j++)
                            {
                                var outputMessage = messages[j];
                                string outputRole = outputMessage.ContainsKey("role") ? outputMessage["role"].ToString() : "";
                                string outputContent = outputMessage.ContainsKey("content") ? outputMessage["content"].ToString() : "";
                                outputContent = outputContent.Replace("\n", "\r\n");

                                string roleTag = outputRole == "user" ? "\r\n<You>" : "\r\n<GPT>";
                                OutputHistory.AppendText($"{roleTag}\r\n{outputContent}\r\n");
                            }

                            // Exit the loop, since we have reached the end of the data
                            break;
                        }
                    }
                    bindingSource.ResetBindings(false);

                    OutputHistory.Text += "\r\n<system>\r\nReady for input.\r\nThe following request is a continuation of the previous input.\r\nThe system and model use the app settings; if you use a different system model than History, the response of subsequent GPTs may change.";

                    OutputHistory.SelectionStart = OutputHistory.Text.Length;
                    OutputHistory.ScrollToCaret();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (MessageHistoryForm messageHistoryForm = new MessageHistoryForm())
            {
                messageHistoryForm.ShowDialog();
            }
        }
    }
}
