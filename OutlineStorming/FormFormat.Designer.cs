namespace OutlineStorming
{
    partial class FormFormat
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
            comboBoxCode = new ComboBox();
            comboBoxSeparator = new ComboBox();
            comboBoxNewLine = new ComboBox();
            btnDefault = new Button();
            checkBoxExtendedRead = new CheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox1 = new TextBox();
            textBoxNewLine = new TextBox();
            textBoxSeparator = new TextBox();
            textBoxCode = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.Location = new Point(302, 346);
            btnSave.Margin = new Padding(2, 1, 2, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(296, 70);
            btnSave.TabIndex = 0;
            btnSave.Text = "OK";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // comboBoxCode
            // 
            comboBoxCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCode.FormattingEnabled = true;
            comboBoxCode.Items.AddRange(new object[] { "UTF-8 (BOM)", "UTF-8" });
            comboBoxCode.Location = new Point(302, 1);
            comboBoxCode.Margin = new Padding(2, 1, 2, 1);
            comboBoxCode.Name = "comboBoxCode";
            comboBoxCode.Size = new Size(296, 23);
            comboBoxCode.TabIndex = 1;
            // 
            // comboBoxSeparator
            // 
            comboBoxSeparator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSeparator.FormattingEnabled = true;
            comboBoxSeparator.Items.AddRange(new object[] { "TAB", "Comma", "SOH (\\u0001)" });
            comboBoxSeparator.Location = new Point(302, 70);
            comboBoxSeparator.Margin = new Padding(2, 1, 2, 1);
            comboBoxSeparator.Name = "comboBoxSeparator";
            comboBoxSeparator.Size = new Size(296, 23);
            comboBoxSeparator.TabIndex = 4;
            // 
            // comboBoxNewLine
            // 
            comboBoxNewLine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxNewLine.FormattingEnabled = true;
            comboBoxNewLine.Items.AddRange(new object[] { "\\n", "\\r\\n" });
            comboBoxNewLine.Location = new Point(302, 139);
            comboBoxNewLine.Margin = new Padding(2, 1, 2, 1);
            comboBoxNewLine.Name = "comboBoxNewLine";
            comboBoxNewLine.Size = new Size(296, 23);
            comboBoxNewLine.TabIndex = 6;
            // 
            // btnDefault
            // 
            btnDefault.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDefault.Location = new Point(2, 346);
            btnDefault.Margin = new Padding(2, 1, 2, 1);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(296, 70);
            btnDefault.TabIndex = 7;
            btnDefault.Text = "Restore default";
            btnDefault.UseVisualStyleBackColor = true;
            btnDefault.Click += btnDefault_Click;
            // 
            // checkBoxExtendedRead
            // 
            checkBoxExtendedRead.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            checkBoxExtendedRead.AutoSize = true;
            checkBoxExtendedRead.Location = new Point(302, 208);
            checkBoxExtendedRead.Margin = new Padding(2, 1, 2, 1);
            checkBoxExtendedRead.Name = "checkBoxExtendedRead";
            checkBoxExtendedRead.Size = new Size(61, 67);
            checkBoxExtendedRead.TabIndex = 11;
            checkBoxExtendedRead.Text = "Enable";
            checkBoxExtendedRead.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(btnDefault, 0, 5);
            tableLayoutPanel1.Controls.Add(comboBoxNewLine, 1, 2);
            tableLayoutPanel1.Controls.Add(comboBoxSeparator, 1, 1);
            tableLayoutPanel1.Controls.Add(comboBoxCode, 1, 0);
            tableLayoutPanel1.Controls.Add(checkBoxExtendedRead, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 3);
            tableLayoutPanel1.Controls.Add(btnSave, 1, 5);
            tableLayoutPanel1.Controls.Add(textBoxNewLine, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxSeparator, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxCode, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(600, 417);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 210);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(294, 63);
            textBox1.TabIndex = 12;
            textBox1.Text = "Extended Read\r\nWhen there are four or more columns of data, force loading as the third column element.";
            // 
            // textBoxNewLine
            // 
            textBoxNewLine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNewLine.Location = new Point(3, 141);
            textBoxNewLine.Multiline = true;
            textBoxNewLine.Name = "textBoxNewLine";
            textBoxNewLine.ReadOnly = true;
            textBoxNewLine.Size = new Size(294, 63);
            textBoxNewLine.TabIndex = 13;
            textBoxNewLine.Text = "New Line";
            // 
            // textBoxSeparator
            // 
            textBoxSeparator.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSeparator.Location = new Point(3, 72);
            textBoxSeparator.Multiline = true;
            textBoxSeparator.Name = "textBoxSeparator";
            textBoxSeparator.ReadOnly = true;
            textBoxSeparator.Size = new Size(294, 63);
            textBoxSeparator.TabIndex = 14;
            textBoxSeparator.Text = "Separator";
            // 
            // textBoxCode
            // 
            textBoxCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCode.Location = new Point(3, 3);
            textBoxCode.Multiline = true;
            textBoxCode.Name = "textBoxCode";
            textBoxCode.ReadOnly = true;
            textBoxCode.Size = new Size(294, 63);
            textBoxCode.TabIndex = 15;
            textBoxCode.Text = "Charactor Code";
            // 
            // FormFormat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(624, 441);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormFormat";
            Text = "Format";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private ComboBox comboBoxCode;
        private ComboBox comboBoxSeparator;
        private ComboBox comboBoxNewLine;
        private Button btnDefault;
        private CheckBox checkBoxExtendedRead;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private TextBox textBoxNewLine;
        private TextBox textBoxSeparator;
        private TextBox textBoxCode;
    }
}