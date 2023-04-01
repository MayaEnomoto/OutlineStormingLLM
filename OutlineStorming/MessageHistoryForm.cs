using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlineStorming
{
    public partial class MessageHistoryForm : Form
    {

        private List<object> _originalMessageHistory;

        public MessageHistoryForm()
        {
            InitializeComponent();
            _originalMessageHistory = new List<object>(GptCall.GetMessageHistory());
            LoadMessageHistory();
        }

        private void LoadMessageHistory()
        {
            messageListBox.Items.Clear();
            GptCall.ForEachMessage((role, content) =>
            {
                messageListBox.Items.Add($"{role}: {content}");
            });
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = messageListBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                messageListBox.Items.RemoveAt(selectedIndex);
                GptCall.RemoveMessageAtIndex(selectedIndex);
            }
        }

        private void MessageHistoryForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadMessageHistory();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to save the changes to the message history? This action cannot be undone.", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the message history?", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                GptCall.SetMessageHistory(_originalMessageHistory);
                LoadMessageHistory();
            }
        }
    }
}
