namespace OutlineStorming
{
    partial class MessageHistoryForm
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
            messageListBox = new ListBox();
            deleteButton = new Button();
            buttonOK = new Button();
            buttonReset = new Button();
            SuspendLayout();
            // 
            // messageListBox
            // 
            messageListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messageListBox.FormattingEnabled = true;
            messageListBox.ItemHeight = 15;
            messageListBox.Location = new Point(12, 12);
            messageListBox.Name = "messageListBox";
            messageListBox.Size = new Size(920, 409);
            messageListBox.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.Location = new Point(470, 439);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 50);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Delete line message";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // buttonOK
            // 
            buttonOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOK.Location = new Point(782, 439);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(150, 50);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonReset.Location = new Point(626, 439);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(150, 50);
            buttonReset.TabIndex = 3;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // MessageHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(buttonReset);
            Controls.Add(buttonOK);
            Controls.Add(deleteButton);
            Controls.Add(messageListBox);
            Name = "MessageHistoryForm";
            Text = "MessageHistoryForm";
            VisibleChanged += MessageHistoryForm_VisibleChanged;
            ResumeLayout(false);
        }

        #endregion

        private ListBox messageListBox;
        private Button deleteButton;
        private Button buttonOK;
        private Button buttonReset;
    }
}