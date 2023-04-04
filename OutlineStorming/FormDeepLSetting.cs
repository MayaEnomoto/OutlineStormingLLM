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
    public partial class FormDeepLSetting : Form
    {
        public FormDeepLSetting()
        {
            InitializeComponent();
            radioButtonFree.CheckedChanged += RadioButtonFree_CheckedChanged;
            radioButtonPro.CheckedChanged += RadioButtonPro_CheckedChanged;
        }
        private void FormDeepLSetting_Load(object sender, EventArgs e)
        {
            textBoxAuthkey.Text = Properties.Settings.Default.deepLAuthKey;
            textBoxResetTimeout.Text = Properties.Settings.Default.deepLTimeout.ToString();
            radioButtonFree.Checked = !Properties.Settings.Default.deepLFreeProFlg;
            radioButtonPro.Checked = Properties.Settings.Default.deepLFreeProFlg;
            checkBoxTranslateRequest.Checked = Properties.Settings.Default.deepLTranslateRequestFlg;
            checkBoxTranslateResponse.Checked = Properties.Settings.Default.deepLTranslateResponseFlg;
            checkBoxUserAuto.Checked = Properties.Settings.Default.deepLUserLangAuto;
            checkBoxGPTAuto.Checked = Properties.Settings.Default.deepLGPTLangAuto;
            InitializeComboBox(comboBoxUserLang, Properties.Settings.Default.deepLUserLang);
            InitializeComboBox(comboBoxGPTLang, Properties.Settings.Default.deepLGPTLang);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int timeout = 60;
            Properties.Settings.Default.deepLAuthKey = textBoxAuthkey.Text;
            if (int.TryParse(textBoxResetTimeout.Text, out timeout))
            {
                if (timeout > 600)
                {
                    timeout = 600;
                }
                Properties.Settings.Default.deepLTimeout = timeout;
            }
            else
            {
                Properties.Settings.Default.deepLTimeout = 60;
            }
            if (radioButtonFree.Checked == true)
            {
                Properties.Settings.Default.deepLFreeProFlg = false;
            }
            else
            {
                Properties.Settings.Default.deepLFreeProFlg = true;
            }
            Properties.Settings.Default.deepLTranslateRequestFlg = checkBoxTranslateRequest.Checked;
            Properties.Settings.Default.deepLTranslateResponseFlg = checkBoxTranslateResponse.Checked;
            Properties.Settings.Default.deepLUserLangAuto = checkBoxUserAuto.Checked;
            Properties.Settings.Default.deepLGPTLangAuto = checkBoxGPTAuto.Checked;
            Properties.Settings.Default.deepLUserLang = comboBoxUserLang.SelectedValue.ToString();
            Properties.Settings.Default.deepLGPTLang = comboBoxGPTLang.SelectedValue.ToString();

            Properties.Settings.Default.Save();

            this.Close();
        }

        private void RadioButtonFree_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.deepLFreeProFlg = !radioButtonFree.Checked;
        }

        private void RadioButtonPro_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.deepLFreeProFlg = radioButtonPro.Checked;
        }

        private void textBoxResetTimeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void InitializeComboBox(ComboBox comboBox, string selectedLanguageCode)
        {
            comboBox.DataSource = new BindingSource(languageDictionary, null);
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
            comboBox.SelectedValue = selectedLanguageCode;
        }

        private Dictionary<string, string> languageDictionary = new Dictionary<string, string>
        {
            {"BG", "Bulgarian"},
            {"CS", "Czech"},
            {"DA", "Danish"},
            {"DE", "German"},
            {"EL", "Greek"},
            {"EN-GB", "English (British)"},
            {"EN-US", "English (American)"},
            {"ES", "Spanish"},
            {"ET", "Estonian"},
            {"FI", "Finnish"},
            {"FR", "French"},
            {"HU", "Hungarian"},
            {"ID", "Indonesian"},
            {"IT", "Italian"},
            {"JA", "Japanese"},
            {"KO", "Korean"},
            {"LT", "Lithuanian"},
            {"LV", "Latvian"},
            {"NB", "Norwegian (Bokmål)"},
            {"NL", "Dutch"},
            {"PL", "Polish"},
            {"PT-BR", "Portuguese(Brazilian)"},
            {"PT-PT", "Portuguese"},
            {"RO", "Romanian"},
            {"RU", "Russian"},
            {"SK", "Slovak"},
            {"SL", "Slovenian"},
            {"SV", "Swedish"},
            {"TR", "Turkish"},
            {"UK", "Ukrainian"},
            {"ZH", "Chinese (simplified)"}
        };

        private void btnResetTimeout_Click(object sender, EventArgs e)
        {
            textBoxResetTimeout.Text = "60";
        }
    }
}
