using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlineStorming
{
    public partial class FormGPTSetting : Form
    {
        public FormGPTSetting()
        {
            //this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();

            textBoxAuthkey.Text = Properties.Settings.Default.dataAuthKey;
            textBoxGPTModel.Text = Properties.Settings.Default.dataGPTmodel;
            textBoxGPTsystem.Text = Properties.Settings.Default.dataGPTsystem;
            textBoxResetTimeout.Text = Properties.Settings.Default.dataGPTTimeout.ToString();
        }

        private void btnLoadDefault_Click(object sender, EventArgs e)
        {
            textBoxGPTModel.Text = "gpt-3.5-turbo";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int timeout = 60;
            Properties.Settings.Default.dataAuthKey = textBoxAuthkey.Text;
            Properties.Settings.Default.dataGPTmodel = textBoxGPTModel.Text;
            Properties.Settings.Default.dataGPTsystem = textBoxGPTsystem.Text;
            if (int.TryParse(textBoxResetTimeout.Text, out timeout))
            {
                if (timeout >= 600)
                {
                    timeout = 600;
                }
                Properties.Settings.Default.dataGPTTimeout = timeout;
            }
            else
            {
                Properties.Settings.Default.dataGPTTimeout = 60;
            }

            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnResetTimeout_Click(object sender, EventArgs e)
        {
            textBoxResetTimeout.Text = "60";
        }

        private void textBoxResetTimeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
