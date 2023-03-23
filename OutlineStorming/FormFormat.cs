using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OutlineStorming
{
    public partial class FormFormat : Form
    {
        public FormFormat()
        {
            //this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();

            comboBoxCode.SelectedIndex = Properties.Settings.Default.formatUTF;
            comboBoxSeparator.SelectedIndex = Properties.Settings.Default.formatSeparator;
            comboBoxNewLine.SelectedIndex = Properties.Settings.Default.formatNewLine;
            checkBoxExtendedRead.Checked = Properties.Settings.Default.formatExtendedRead;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            comboBoxCode.SelectedIndex = 0;
            comboBoxSeparator.SelectedIndex = 0;
            comboBoxNewLine.SelectedIndex = 0;
            checkBoxExtendedRead.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.formatUTF = comboBoxCode.SelectedIndex;
            Properties.Settings.Default.formatSeparator = comboBoxSeparator.SelectedIndex;
            Properties.Settings.Default.formatNewLine = comboBoxNewLine.SelectedIndex;
            Properties.Settings.Default.formatExtendedRead = checkBoxExtendedRead.Checked;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
