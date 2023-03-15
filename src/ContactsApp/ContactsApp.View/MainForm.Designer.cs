namespace ContactsApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.RemoveContactButton = new System.Windows.Forms.Button();
            this.PersonPictureBox = new System.Windows.Forms.PictureBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.ButtonTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.ButtonTableLayoutPanel);
            this.MainSplitContainer.Panel1.Controls.Add(this.ContactsListBox);
            this.MainSplitContainer.Panel1.Controls.Add(this.FindTextBox);
            this.MainSplitContainer.Panel1.Controls.Add(this.FindLabel);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.EmailTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.EmailLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.FullNameTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.FullNameLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.PersonPictureBox);
            this.MainSplitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainSplitContainer_Panel2_Paint);
            this.MainSplitContainer.Size = new System.Drawing.Size(800, 450);
            this.MainSplitContainer.SplitterDistance = 266;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // ButtonTableLayoutPanel
            // 
            this.ButtonTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTableLayoutPanel.ColumnCount = 3;
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.ButtonTableLayoutPanel.Controls.Add(this.AddContactButton, 0, 0);
            this.ButtonTableLayoutPanel.Controls.Add(this.EditContactButton, 1, 0);
            this.ButtonTableLayoutPanel.Controls.Add(this.RemoveContactButton, 2, 0);
            this.ButtonTableLayoutPanel.Location = new System.Drawing.Point(14, 417);
            this.ButtonTableLayoutPanel.Name = "ButtonTableLayoutPanel";
            this.ButtonTableLayoutPanel.RowCount = 1;
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonTableLayoutPanel.Size = new System.Drawing.Size(249, 30);
            this.ButtonTableLayoutPanel.TabIndex = 3;
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new System.Drawing.Point(14, 36);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(249, 381);
            this.ContactsListBox.TabIndex = 2;
            // 
            // FindTextBox
            // 
            this.FindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindTextBox.Location = new System.Drawing.Point(49, 10);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(214, 20);
            this.FindTextBox.TabIndex = 1;
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(13, 13);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(30, 13);
            this.FindLabel.TabIndex = 0;
            this.FindLabel.Text = "Find:";
            this.FindLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddContactButton
            // 
            this.AddContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddContactButton.Location = new System.Drawing.Point(3, 3);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(77, 24);
            this.AddContactButton.TabIndex = 0;
            this.AddContactButton.Text = "button1";
            this.AddContactButton.UseVisualStyleBackColor = true;
            // 
            // EditContactButton
            // 
            this.EditContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditContactButton.Location = new System.Drawing.Point(86, 3);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(77, 24);
            this.EditContactButton.TabIndex = 1;
            this.EditContactButton.Text = "button2";
            this.EditContactButton.UseVisualStyleBackColor = true;
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveContactButton.Location = new System.Drawing.Point(169, 3);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(77, 24);
            this.RemoveContactButton.TabIndex = 2;
            this.RemoveContactButton.Text = "button3";
            this.RemoveContactButton.UseVisualStyleBackColor = true;
            // 
            // PersonPictureBox
            // 
            this.PersonPictureBox.Location = new System.Drawing.Point(4, 10);
            this.PersonPictureBox.Name = "PersonPictureBox";
            this.PersonPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PersonPictureBox.TabIndex = 0;
            this.PersonPictureBox.TabStop = false;
            this.PersonPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(110, 13);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(110, 29);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FullNameTextBox.TabIndex = 2;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(110, 73);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-mail:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(110, 89);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTextBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainSplitContainer);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel1.PerformLayout();
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ButtonTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.TableLayoutPanel ButtonTableLayoutPanel;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.Button EditContactButton;
        private System.Windows.Forms.Button RemoveContactButton;
        private System.Windows.Forms.PictureBox PersonPictureBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
    }
}

