namespace OutlineStorming
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OutputHistory = new TextBox();
            dataGridView = new DataGridView();
            btnAddRow = new Button();
            btnDeleteRow = new Button();
            txtType = new TextBox();
            txtValue = new TextBox();
            txtNote = new TextBox();
            btnResetSort = new Button();
            btnMoveUp = new Button();
            btnMoveDown = new Button();
            statusStrip1 = new StatusStrip();
            labelType = new Label();
            labelNote = new Label();
            labelCsvData = new Label();
            btnSendRequest = new Button();
            labelValue = new Label();
            labelAnswer = new Label();
            labelRequest = new Label();
            textBoxRequest = new TextBox();
            btnClearHistory = new Button();
            checkBoxView = new CheckBox();
            menuStrip1 = new MenuStrip();
            newToolStripMenuItem = new ToolStripMenuItem();
            newFileToolStripMenuItem = new ToolStripMenuItem();
            openCSVToolStripMenuItem = new ToolStripMenuItem();
            saveCSVToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            settingToolStripMenuItem = new ToolStripMenuItem();
            fileFormatToolStripMenuItem = new ToolStripMenuItem();
            gPTSettingToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            buttonImport = new Button();
            buttonExport = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // OutputHistory
            // 
            OutputHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OutputHistory.Location = new Point(2, 51);
            OutputHistory.Margin = new Padding(2, 1, 2, 1);
            OutputHistory.Multiline = true;
            OutputHistory.Name = "OutputHistory";
            OutputHistory.ReadOnly = true;
            OutputHistory.ScrollBars = ScrollBars.Vertical;
            OutputHistory.Size = new Size(497, 427);
            OutputHistory.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.AllowDrop = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView.Location = new Point(2, 53);
            dataGridView.Margin = new Padding(2, 1, 2, 1);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 82;
            dataGridView.RowTemplate.Height = 41;
            dataGridView.ScrollBars = ScrollBars.Vertical;
            dataGridView.Size = new Size(495, 677);
            dataGridView.TabIndex = 1;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.ColumnHeaderMouseClick += dataGridView_ColumnHeaderMouseClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            dataGridView.DragDrop += dataGridView_DragDrop;
            dataGridView.DragEnter += dataGridView_DragEnter;
            dataGridView.MouseClick += dataGridView_MouseClick;
            dataGridView.MouseDown += dataGridView_MouseDown;
            // 
            // btnAddRow
            // 
            btnAddRow.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddRow.Location = new Point(2, 732);
            btnAddRow.Margin = new Padding(2, 1, 2, 1);
            btnAddRow.Name = "btnAddRow";
            btnAddRow.Size = new Size(150, 50);
            btnAddRow.TabIndex = 4;
            btnAddRow.Text = "Add Row";
            btnAddRow.UseVisualStyleBackColor = true;
            btnAddRow.Click += btnAddRow_Click;
            // 
            // btnDeleteRow
            // 
            btnDeleteRow.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteRow.Location = new Point(2, 784);
            btnDeleteRow.Margin = new Padding(2, 1, 2, 1);
            btnDeleteRow.Name = "btnDeleteRow";
            btnDeleteRow.Size = new Size(150, 50);
            btnDeleteRow.TabIndex = 5;
            btnDeleteRow.Text = "Delete Row";
            btnDeleteRow.UseVisualStyleBackColor = true;
            btnDeleteRow.Click += btnDeleteRow_Click;
            // 
            // txtType
            // 
            txtType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtType.Location = new Point(2, 51);
            txtType.Margin = new Padding(2, 1, 2, 1);
            txtType.MaxLength = 2000;
            txtType.Name = "txtType";
            txtType.Size = new Size(242, 23);
            txtType.TabIndex = 6;
            txtType.TextChanged += txtType_TextChanged;
            // 
            // txtValue
            // 
            txtValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtValue.Location = new Point(2, 126);
            txtValue.Margin = new Padding(2, 1, 2, 1);
            txtValue.MaxLength = 2000;
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(242, 23);
            txtValue.TabIndex = 7;
            txtValue.TextChanged += txtValue_TextChanged;
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNote.Location = new Point(2, 203);
            txtNote.Margin = new Padding(2, 1, 2, 1);
            txtNote.MaxLength = 2000;
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.ScrollBars = ScrollBars.Vertical;
            txtNote.Size = new Size(242, 527);
            txtNote.TabIndex = 8;
            txtNote.TextChanged += txtNote_TextChanged;
            // 
            // btnResetSort
            // 
            btnResetSort.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnResetSort.Location = new Point(310, 785);
            btnResetSort.Margin = new Padding(2, 1, 2, 1);
            btnResetSort.Name = "btnResetSort";
            btnResetSort.Size = new Size(150, 50);
            btnResetSort.TabIndex = 10;
            btnResetSort.Text = "Reset Sort";
            btnResetSort.UseVisualStyleBackColor = true;
            btnResetSort.Click += btnResetSort_Click;
            // 
            // btnMoveUp
            // 
            btnMoveUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMoveUp.Location = new Point(156, 732);
            btnMoveUp.Margin = new Padding(2, 1, 2, 1);
            btnMoveUp.Name = "btnMoveUp";
            btnMoveUp.Size = new Size(150, 50);
            btnMoveUp.TabIndex = 11;
            btnMoveUp.Text = "Up";
            btnMoveUp.UseVisualStyleBackColor = true;
            btnMoveUp.Click += btnMoveUp_Click;
            // 
            // btnMoveDown
            // 
            btnMoveDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMoveDown.Location = new Point(156, 784);
            btnMoveDown.Margin = new Padding(2, 1, 2, 1);
            btnMoveDown.Name = "btnMoveDown";
            btnMoveDown.Size = new Size(150, 50);
            btnMoveDown.TabIndex = 12;
            btnMoveDown.Text = "Down";
            btnMoveDown.UseVisualStyleBackColor = true;
            btnMoveDown.Click += btnMoveDown_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Location = new Point(0, 899);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 8, 0);
            statusStrip1.Size = new Size(1264, 22);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelType
            // 
            labelType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelType.Location = new Point(2, 0);
            labelType.Margin = new Padding(2, 0, 2, 0);
            labelType.Name = "labelType";
            labelType.Size = new Size(242, 50);
            labelType.TabIndex = 14;
            labelType.Text = "Type";
            labelType.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelNote
            // 
            labelNote.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNote.Location = new Point(2, 152);
            labelNote.Margin = new Padding(2, 0, 2, 0);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(242, 50);
            labelNote.TabIndex = 16;
            labelNote.Text = "Note";
            labelNote.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelCsvData
            // 
            labelCsvData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelCsvData.Location = new Point(2, 0);
            labelCsvData.Margin = new Padding(2, 0, 2, 0);
            labelCsvData.Name = "labelCsvData";
            labelCsvData.Size = new Size(291, 50);
            labelCsvData.TabIndex = 17;
            labelCsvData.Text = "Data Set";
            labelCsvData.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnSendRequest
            // 
            btnSendRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSendRequest.Location = new Point(2, 732);
            btnSendRequest.Margin = new Padding(2, 1, 2, 1);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(497, 50);
            btnSendRequest.TabIndex = 19;
            btnSendRequest.Text = "Send Request";
            btnSendRequest.UseVisualStyleBackColor = true;
            btnSendRequest.Click += btnSendRequest_Click;
            // 
            // labelValue
            // 
            labelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelValue.Location = new Point(2, 75);
            labelValue.Margin = new Padding(2, 0, 2, 0);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(242, 50);
            labelValue.TabIndex = 15;
            labelValue.Text = "Value";
            labelValue.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelAnswer
            // 
            labelAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelAnswer.Location = new Point(4, 0);
            labelAnswer.Margin = new Padding(2, 0, 2, 0);
            labelAnswer.Name = "labelAnswer";
            labelAnswer.Size = new Size(291, 50);
            labelAnswer.TabIndex = 20;
            labelAnswer.Text = "History (GPT's Answer)";
            labelAnswer.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelRequest
            // 
            labelRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelRequest.Location = new Point(2, 479);
            labelRequest.Margin = new Padding(2, 0, 2, 0);
            labelRequest.Name = "labelRequest";
            labelRequest.Size = new Size(497, 50);
            labelRequest.TabIndex = 21;
            labelRequest.Text = "Request to GPT";
            labelRequest.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBoxRequest
            // 
            textBoxRequest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxRequest.Location = new Point(2, 530);
            textBoxRequest.Margin = new Padding(2, 1, 2, 1);
            textBoxRequest.MaxLength = 2000;
            textBoxRequest.Multiline = true;
            textBoxRequest.Name = "textBoxRequest";
            textBoxRequest.Size = new Size(497, 200);
            textBoxRequest.TabIndex = 22;
            // 
            // btnClearHistory
            // 
            btnClearHistory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClearHistory.Location = new Point(299, 0);
            btnClearHistory.Margin = new Padding(2, 1, 2, 1);
            btnClearHistory.Name = "btnClearHistory";
            btnClearHistory.Size = new Size(200, 50);
            btnClearHistory.TabIndex = 24;
            btnClearHistory.Text = "Clear history";
            btnClearHistory.UseVisualStyleBackColor = true;
            btnClearHistory.Click += btnClearHistory_Click;
            // 
            // checkBoxView
            // 
            checkBoxView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxView.Appearance = Appearance.Button;
            checkBoxView.Location = new Point(297, 1);
            checkBoxView.Margin = new Padding(2, 1, 2, 1);
            checkBoxView.Name = "checkBoxView";
            checkBoxView.Size = new Size(200, 50);
            checkBoxView.TabIndex = 18;
            checkBoxView.Text = "View change";
            checkBoxView.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxView.UseVisualStyleBackColor = true;
            checkBoxView.CheckedChanged += checkBoxView_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { newToolStripMenuItem, settingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 28;
            menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newFileToolStripMenuItem, openCSVToolStripMenuItem, saveCSVToolStripMenuItem, exitToolStripMenuItem });
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(37, 20);
            newToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            newFileToolStripMenuItem.Size = new Size(126, 22);
            newFileToolStripMenuItem.Text = "New";
            newFileToolStripMenuItem.Click += newFileToolStripMenuItem_Click;
            // 
            // openCSVToolStripMenuItem
            // 
            openCSVToolStripMenuItem.Name = "openCSVToolStripMenuItem";
            openCSVToolStripMenuItem.Size = new Size(126, 22);
            openCSVToolStripMenuItem.Text = "Open CSV";
            openCSVToolStripMenuItem.Click += openCSVToolStripMenuItem_Click;
            // 
            // saveCSVToolStripMenuItem
            // 
            saveCSVToolStripMenuItem.Name = "saveCSVToolStripMenuItem";
            saveCSVToolStripMenuItem.Size = new Size(126, 22);
            saveCSVToolStripMenuItem.Text = "Save CSV";
            saveCSVToolStripMenuItem.Click += saveCSVToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(126, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileFormatToolStripMenuItem, gPTSettingToolStripMenuItem });
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(56, 20);
            settingToolStripMenuItem.Text = "Setting";
            // 
            // fileFormatToolStripMenuItem
            // 
            fileFormatToolStripMenuItem.Name = "fileFormatToolStripMenuItem";
            fileFormatToolStripMenuItem.Size = new Size(139, 22);
            fileFormatToolStripMenuItem.Text = "File format";
            fileFormatToolStripMenuItem.Click += fileFormatToolStripMenuItem_Click;
            // 
            // gPTSettingToolStripMenuItem
            // 
            gPTSettingToolStripMenuItem.Name = "gPTSettingToolStripMenuItem";
            gPTSettingToolStripMenuItem.Size = new Size(139, 22);
            gPTSettingToolStripMenuItem.Text = "GPT settings";
            gPTSettingToolStripMenuItem.Click += gPTSettingToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1264, 841);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(buttonImport);
            panel3.Controls.Add(buttonExport);
            panel3.Controls.Add(OutputHistory);
            panel3.Controls.Add(textBoxRequest);
            panel3.Controls.Add(btnClearHistory);
            panel3.Controls.Add(btnSendRequest);
            panel3.Controls.Add(labelAnswer);
            panel3.Controls.Add(labelRequest);
            panel3.Location = new Point(760, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(501, 835);
            panel3.TabIndex = 2;
            // 
            // buttonImport
            // 
            buttonImport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonImport.Location = new Point(95, 785);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(200, 46);
            buttonImport.TabIndex = 26;
            buttonImport.Text = "Import history";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // buttonExport
            // 
            buttonExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExport.Location = new Point(298, 785);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(200, 46);
            buttonExport.TabIndex = 25;
            buttonExport.Text = "Export history";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(txtType);
            panel2.Controls.Add(txtNote);
            panel2.Controls.Add(txtValue);
            panel2.Controls.Add(labelType);
            panel2.Controls.Add(labelNote);
            panel2.Controls.Add(labelValue);
            panel2.Location = new Point(508, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 835);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(checkBoxView);
            panel1.Controls.Add(dataGridView);
            panel1.Controls.Add(btnResetSort);
            panel1.Controls.Add(btnMoveDown);
            panel1.Controls.Add(btnDeleteRow);
            panel1.Controls.Add(btnAddRow);
            panel1.Controls.Add(btnMoveUp);
            panel1.Controls.Add(labelCsvData);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 835);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1264, 921);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 1, 2, 1);
            MinimumSize = new Size(960, 540);
            Name = "Form1";
            Text = "Outline Storming GPT v1.4";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OutputHistory;
        private DataGridView dataGridView;
        private Button btnAddRow;
        private Button btnDeleteRow;
        private TextBox txtType;
        private TextBox txtValue;
        private TextBox txtNote;
        private Button btnResetSort;
        private Button btnMoveUp;
        private Button btnMoveDown;
        private StatusStrip statusStrip1;
        private Label labelType;
        private Label labelNote;
        private Label labelCsvData;
        private Button btnSendRequest;
        private Label labelValue;
        private Label labelAnswer;
        private Label labelRequest;
        private TextBox textBoxRequest;
        private Button btnClearHistory;
        private CheckBox checkBoxView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem newFileToolStripMenuItem;
        private ToolStripMenuItem openCSVToolStripMenuItem;
        private ToolStripMenuItem saveCSVToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem fileFormatToolStripMenuItem;
        private ToolStripMenuItem gPTSettingToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button buttonExport;
        private Button buttonImport;
    }
}