namespace OutlineStorming
{
    partial class FormDeepLSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSave = new Button();
            textBoxResetTimeout = new TextBox();
            btnResetTimeout = new Button();
            label6 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            checkBoxUserAuto = new CheckBox();
            comboBoxUserLang = new ComboBox();
            textBoxAuthkey = new TextBox();
            label1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            radioButtonPro = new RadioButton();
            label4 = new Label();
            radioButtonFree = new RadioButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            comboBoxGPTLang = new ComboBox();
            label3 = new Label();
            checkBoxGPTAuto = new CheckBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            checkBoxTranslateResponse = new CheckBox();
            checkBoxTranslateRequest = new CheckBox();
            checkBoxTranslateDataset = new CheckBox();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(btnSave, 1, 9);
            tableLayoutPanel1.Controls.Add(textBoxResetTimeout, 0, 6);
            tableLayoutPanel1.Controls.Add(btnResetTimeout, 1, 6);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxAuthkey, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 8);
            tableLayoutPanel1.Controls.Add(label5, 0, 7);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(600, 417);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.Location = new Point(482, 370);
            btnSave.Margin = new Padding(2, 1, 2, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 46);
            btnSave.TabIndex = 0;
            btnSave.Text = "OK";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // textBoxResetTimeout
            // 
            textBoxResetTimeout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxResetTimeout.Location = new Point(2, 247);
            textBoxResetTimeout.Margin = new Padding(2, 1, 2, 1);
            textBoxResetTimeout.Name = "textBoxResetTimeout";
            textBoxResetTimeout.Size = new Size(476, 23);
            textBoxResetTimeout.TabIndex = 11;
            textBoxResetTimeout.KeyPress += textBoxResetTimeout_KeyPress;
            // 
            // btnResetTimeout
            // 
            btnResetTimeout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnResetTimeout.Location = new Point(482, 247);
            btnResetTimeout.Margin = new Padding(2, 1, 2, 1);
            btnResetTimeout.Name = "btnResetTimeout";
            btnResetTimeout.Size = new Size(116, 39);
            btnResetTimeout.TabIndex = 13;
            btnResetTimeout.Text = "Set default";
            btnResetTimeout.UseVisualStyleBackColor = true;
            btnResetTimeout.Click += btnResetTimeout_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(2, 231);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(246, 15);
            label6.TabIndex = 14;
            label6.Text = "Response Timeout (default 60sec max 600sec)";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(checkBoxUserAuto, 2, 0);
            tableLayoutPanel2.Controls.Add(comboBoxUserLang, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 126);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(474, 35);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(77, 10);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 0;
            label2.Text = "User Language";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxUserAuto
            // 
            checkBoxUserAuto.Anchor = AnchorStyles.Left;
            checkBoxUserAuto.AutoSize = true;
            checkBoxUserAuto.Location = new Point(333, 8);
            checkBoxUserAuto.Name = "checkBoxUserAuto";
            checkBoxUserAuto.Size = new Size(90, 19);
            checkBoxUserAuto.TabIndex = 1;
            checkBoxUserAuto.Text = "Enable Auto";
            checkBoxUserAuto.UseVisualStyleBackColor = true;
            // 
            // comboBoxUserLang
            // 
            comboBoxUserLang.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxUserLang.FormattingEnabled = true;
            comboBoxUserLang.Location = new Point(168, 6);
            comboBoxUserLang.Name = "comboBoxUserLang";
            comboBoxUserLang.Size = new Size(159, 23);
            comboBoxUserLang.TabIndex = 2;
            // 
            // textBoxAuthkey
            // 
            textBoxAuthkey.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAuthkey.Location = new Point(2, 83);
            textBoxAuthkey.Margin = new Padding(2, 1, 2, 1);
            textBoxAuthkey.Name = "textBoxAuthkey";
            textBoxAuthkey.Size = new Size(476, 23);
            textBoxAuthkey.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(2, 67);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Auth_key";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel4.Controls.Add(radioButtonPro, 2, 0);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(radioButtonFree, 1, 0);
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(474, 35);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // radioButtonPro
            // 
            radioButtonPro.Anchor = AnchorStyles.Left;
            radioButtonPro.AutoSize = true;
            radioButtonPro.Location = new Point(310, 8);
            radioButtonPro.Name = "radioButtonPro";
            radioButtonPro.Size = new Size(43, 19);
            radioButtonPro.TabIndex = 4;
            radioButtonPro.TabStop = true;
            radioButtonPro.Text = "Pro";
            radioButtonPro.UseVisualStyleBackColor = true;
            radioButtonPro.CheckedChanged += RadioButtonPro_CheckedChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(79, 10);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 2;
            label4.Text = "DeepL API";
            // 
            // radioButtonFree
            // 
            radioButtonFree.Anchor = AnchorStyles.Left;
            radioButtonFree.AutoSize = true;
            radioButtonFree.Location = new Point(145, 8);
            radioButtonFree.Name = "radioButtonFree";
            radioButtonFree.Size = new Size(46, 19);
            radioButtonFree.TabIndex = 3;
            radioButtonFree.TabStop = true;
            radioButtonFree.Text = "Free";
            radioButtonFree.UseVisualStyleBackColor = true;
            radioButtonFree.CheckedChanged += RadioButtonFree_CheckedChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Controls.Add(comboBoxGPTLang, 0, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(checkBoxGPTAuto, 2, 0);
            tableLayoutPanel3.Location = new Point(3, 167);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(474, 35);
            tableLayoutPanel3.TabIndex = 16;
            // 
            // comboBoxGPTLang
            // 
            comboBoxGPTLang.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxGPTLang.FormattingEnabled = true;
            comboBoxGPTLang.Location = new Point(168, 6);
            comboBoxGPTLang.Name = "comboBoxGPTLang";
            comboBoxGPTLang.Size = new Size(159, 23);
            comboBoxGPTLang.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(71, 10);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 1;
            label3.Text = "GPT's Language";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxGPTAuto
            // 
            checkBoxGPTAuto.Anchor = AnchorStyles.Left;
            checkBoxGPTAuto.AutoSize = true;
            checkBoxGPTAuto.Location = new Point(333, 8);
            checkBoxGPTAuto.Name = "checkBoxGPTAuto";
            checkBoxGPTAuto.Size = new Size(90, 19);
            checkBoxGPTAuto.TabIndex = 2;
            checkBoxGPTAuto.Text = "Enable Auto";
            checkBoxGPTAuto.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(checkBoxTranslateResponse, 0, 0);
            tableLayoutPanel5.Controls.Add(checkBoxTranslateRequest, 0, 0);
            tableLayoutPanel5.Controls.Add(checkBoxTranslateDataset, 0, 0);
            tableLayoutPanel5.Location = new Point(3, 331);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(474, 35);
            tableLayoutPanel5.TabIndex = 18;
            // 
            // checkBoxTranslateResponse
            // 
            checkBoxTranslateResponse.Anchor = AnchorStyles.Left;
            checkBoxTranslateResponse.AutoSize = true;
            checkBoxTranslateResponse.Location = new Point(317, 8);
            checkBoxTranslateResponse.Name = "checkBoxTranslateResponse";
            checkBoxTranslateResponse.Size = new Size(76, 19);
            checkBoxTranslateResponse.TabIndex = 4;
            checkBoxTranslateResponse.Text = "Response";
            checkBoxTranslateResponse.UseVisualStyleBackColor = true;
            // 
            // checkBoxTranslateRequest
            // 
            checkBoxTranslateRequest.Anchor = AnchorStyles.Left;
            checkBoxTranslateRequest.AutoSize = true;
            checkBoxTranslateRequest.Location = new Point(160, 8);
            checkBoxTranslateRequest.Name = "checkBoxTranslateRequest";
            checkBoxTranslateRequest.Size = new Size(68, 19);
            checkBoxTranslateRequest.TabIndex = 3;
            checkBoxTranslateRequest.Text = "Request";
            checkBoxTranslateRequest.UseVisualStyleBackColor = true;
            // 
            // checkBoxTranslateDataset
            // 
            checkBoxTranslateDataset.Anchor = AnchorStyles.Left;
            checkBoxTranslateDataset.AutoSize = true;
            checkBoxTranslateDataset.Enabled = false;
            checkBoxTranslateDataset.Location = new Point(3, 8);
            checkBoxTranslateDataset.Name = "checkBoxTranslateDataset";
            checkBoxTranslateDataset.Size = new Size(65, 19);
            checkBoxTranslateDataset.TabIndex = 2;
            checkBoxTranslateDataset.Text = "Dataset";
            checkBoxTranslateDataset.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(2, 313);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(318, 15);
            label5.TabIndex = 19;
            label5.Text = "Translation target (Dataset translation is not yet supported.)";
            // 
            // FormDeepLSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(tableLayoutPanel1);
            Name = "FormDeepLSetting";
            Text = "FormDeepLSetting";
            Load += FormDeepLSetting_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSave;
        private Label label1;
        private TextBox textBoxResetTimeout;
        private TextBox textBoxAuthkey;
        private Button btnResetTimeout;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private CheckBox checkBoxUserAuto;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private CheckBox checkBoxGPTAuto;
        private TableLayoutPanel tableLayoutPanel4;
        private RadioButton radioButtonPro;
        private Label label4;
        private RadioButton radioButtonFree;
        private TableLayoutPanel tableLayoutPanel5;
        private CheckBox checkBoxTranslateDataset;
        private CheckBox checkBoxTranslateResponse;
        private CheckBox checkBoxTranslateRequest;
        private Label label5;
        private ComboBox comboBoxUserLang;
        private ComboBox comboBoxGPTLang;
    }
}