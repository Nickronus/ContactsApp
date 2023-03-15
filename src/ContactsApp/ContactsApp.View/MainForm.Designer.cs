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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.PersonPictureBox = new System.Windows.Forms.PictureBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.VKLabel = new System.Windows.Forms.Label();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.RemoveContactButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
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
            this.MainSplitContainer.Panel1.Controls.Add(this.RemoveContactButton);
            this.MainSplitContainer.Panel1.Controls.Add(this.EditContactButton);
            this.MainSplitContainer.Panel1.Controls.Add(this.AddContactButton);
            this.MainSplitContainer.Panel1.Controls.Add(this.ContactsListBox);
            this.MainSplitContainer.Panel1.Controls.Add(this.FindTextBox);
            this.MainSplitContainer.Panel1.Controls.Add(this.FindLabel);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.VKTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.VKLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.DateOfBirthLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.DateOfBirthTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.PhoneNumberTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.PhoneNumberLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.FullNameLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.EmailTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.EmailLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.FullNameTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.PersonPictureBox);
            this.MainSplitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainSplitContainer_Panel2_Paint);
            this.MainSplitContainer.Size = new System.Drawing.Size(800, 450);
            this.MainSplitContainer.SplitterDistance = 266;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new System.Drawing.Point(14, 36);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(249, 368);
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
            // PersonPictureBox
            // 
            this.PersonPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PersonPictureBox.BackgroundImage")));
            this.PersonPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PersonPictureBox.Location = new System.Drawing.Point(4, 10);
            this.PersonPictureBox.Name = "PersonPictureBox";
            this.PersonPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PersonPictureBox.TabIndex = 0;
            this.PersonPictureBox.TabStop = false;
            this.PersonPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(110, 74);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-mail:";
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
            this.FullNameTextBox.Size = new System.Drawing.Size(417, 20);
            this.FullNameTextBox.TabIndex = 2;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(110, 90);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(417, 20);
            this.EmailTextBox.TabIndex = 4;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(110, 138);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(110, 154);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(204, 20);
            this.PhoneNumberTextBox.TabIndex = 6;
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(110, 217);
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(204, 20);
            this.DateOfBirthTextBox.TabIndex = 7;
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(110, 201);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.DateOfBirthLabel.TabIndex = 8;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(110, 264);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(24, 13);
            this.VKLabel.TabIndex = 9;
            this.VKLabel.Text = "VK:";
            this.VKLabel.Click += new System.EventHandler(this.VKLabel_Click);
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(110, 280);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(204, 20);
            this.VKTextBox.TabIndex = 10;
            // 
            // AddContactButton
            // 
            this.AddContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddContactButton.BackColor = System.Drawing.Color.White;
            this.AddContactButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddContactButton.BackgroundImage")));
            this.AddContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddContactButton.ForeColor = System.Drawing.Color.White;
            this.AddContactButton.Location = new System.Drawing.Point(14, 410);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(83, 40);
            this.AddContactButton.TabIndex = 3;
            this.AddContactButton.UseVisualStyleBackColor = false;
            // 
            // EditContactButton
            // 
            this.EditContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditContactButton.BackColor = System.Drawing.Color.White;
            this.EditContactButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditContactButton.BackgroundImage")));
            this.EditContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditContactButton.Location = new System.Drawing.Point(97, 410);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(83, 40);
            this.EditContactButton.TabIndex = 11;
            this.EditContactButton.UseVisualStyleBackColor = false;
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveContactButton.BackColor = System.Drawing.Color.White;
            this.RemoveContactButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveContactButton.BackgroundImage")));
            this.RemoveContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveContactButton.Location = new System.Drawing.Point(180, 410);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(83, 40);
            this.RemoveContactButton.TabIndex = 12;
            this.RemoveContactButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            ((System.ComponentModel.ISupportInitialize)(this.PersonPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.PictureBox PersonPictureBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox DateOfBirthTextBox;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.Button RemoveContactButton;
        private System.Windows.Forms.Button EditContactButton;
        private System.Windows.Forms.Button AddContactButton;
    }
}

