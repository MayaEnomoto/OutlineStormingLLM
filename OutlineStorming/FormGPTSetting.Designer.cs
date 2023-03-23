namespace OutlineStorming
{
    partial class FormGPTSetting
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
            btnSave = new Button();
            label1 = new Label();
            textBoxAuthkey = new TextBox();
            label2 = new Label();
            textBoxGPTModel = new TextBox();
            btnLoadDefault = new Button();
            label5 = new Label();
            textBoxGPTsystem = new TextBox();
            label6 = new Label();
            textBoxResetTimeout = new TextBox();
            btnResetTimeout = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(523, 381);
            btnSave.Margin = new Padding(2, 1, 2, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 35);
            btnSave.TabIndex = 0;
            btnSave.Text = "OK";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(2, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Auth_key";
            // 
            // textBoxAuthkey
            // 
            textBoxAuthkey.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAuthkey.Location = new Point(2, 42);
            textBoxAuthkey.Margin = new Padding(2, 1, 2, 1);
            textBoxAuthkey.Name = "textBoxAuthkey";
            textBoxAuthkey.Size = new Size(476, 23);
            textBoxAuthkey.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(2, 108);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 15);
            label2.TabIndex = 3;
            label2.Text = "GPT Model  (default gpt-3.5-turbo)";
            // 
            // textBoxGPTModel
            // 
            textBoxGPTModel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxGPTModel.Location = new Point(2, 124);
            textBoxGPTModel.Margin = new Padding(2, 1, 2, 1);
            textBoxGPTModel.Name = "textBoxGPTModel";
            textBoxGPTModel.Size = new Size(476, 23);
            textBoxGPTModel.TabIndex = 4;
            // 
            // btnLoadDefault
            // 
            btnLoadDefault.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLoadDefault.Location = new Point(482, 124);
            btnLoadDefault.Margin = new Padding(2, 1, 2, 1);
            btnLoadDefault.Name = "btnLoadDefault";
            btnLoadDefault.Size = new Size(116, 39);
            btnLoadDefault.TabIndex = 5;
            btnLoadDefault.Text = "Set default";
            btnLoadDefault.UseVisualStyleBackColor = true;
            btnLoadDefault.Click += btnLoadDefault_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(2, 190);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 8;
            label5.Text = "GPT System";
            // 
            // textBoxGPTsystem
            // 
            textBoxGPTsystem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxGPTsystem.Location = new Point(2, 206);
            textBoxGPTsystem.Margin = new Padding(2, 1, 2, 1);
            textBoxGPTsystem.Name = "textBoxGPTsystem";
            textBoxGPTsystem.Size = new Size(476, 23);
            textBoxGPTsystem.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(2, 272);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(246, 15);
            label6.TabIndex = 10;
            label6.Text = "Response Timeout (default 60sec max 600sec)";
            // 
            // textBoxResetTimeout
            // 
            textBoxResetTimeout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxResetTimeout.Location = new Point(2, 288);
            textBoxResetTimeout.Margin = new Padding(2, 1, 2, 1);
            textBoxResetTimeout.Name = "textBoxResetTimeout";
            textBoxResetTimeout.Size = new Size(476, 23);
            textBoxResetTimeout.TabIndex = 11;
            textBoxResetTimeout.KeyPress += textBoxResetTimeout_KeyPress;
            // 
            // btnResetTimeout
            // 
            btnResetTimeout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnResetTimeout.Location = new Point(482, 288);
            btnResetTimeout.Margin = new Padding(2, 1, 2, 1);
            btnResetTimeout.Name = "btnResetTimeout";
            btnResetTimeout.Size = new Size(116, 39);
            btnResetTimeout.TabIndex = 12;
            btnResetTimeout.Text = "Set default";
            btnResetTimeout.UseVisualStyleBackColor = true;
            btnResetTimeout.Click += btnResetTimeout_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(btnSave, 1, 9);
            tableLayoutPanel1.Controls.Add(btnResetTimeout, 1, 7);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxResetTimeout, 0, 7);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label6, 0, 6);
            tableLayoutPanel1.Controls.Add(textBoxAuthkey, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxGPTsystem, 0, 5);
            tableLayoutPanel1.Controls.Add(textBoxGPTModel, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(btnLoadDefault, 1, 3);
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
            tableLayoutPanel1.Size = new Size(600, 417);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // FormGPTSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormGPTSetting";
            Text = "FormGPTSetting";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private TextBox textBoxAuthkey;
        private Label label2;
        private TextBox textBoxGPTModel;
        private Button btnLoadDefault;
        private Label label5;
        private TextBox textBoxGPTsystem;
        private Label label6;
        private TextBox textBoxResetTimeout;
        private Button btnResetTimeout;
        private TableLayoutPanel tableLayoutPanel1;
    }
}