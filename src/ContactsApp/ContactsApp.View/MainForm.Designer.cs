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
            this.removeContactButton = new System.Windows.Forms.Button();
            this.editContactButton = new System.Windows.Forms.Button();
            this.addContactButton = new System.Windows.Forms.Button();
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findLabel = new System.Windows.Forms.Label();
            this.vKTextBox = new System.Windows.Forms.TextBox();
            this.vKLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.dateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.personPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).BeginInit();
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
            this.MainSplitContainer.Panel1.Controls.Add(this.removeContactButton);
            this.MainSplitContainer.Panel1.Controls.Add(this.editContactButton);
            this.MainSplitContainer.Panel1.Controls.Add(this.addContactButton);
            this.MainSplitContainer.Panel1.Controls.Add(this.contactsListBox);
            this.MainSplitContainer.Panel1.Controls.Add(this.findTextBox);
            this.MainSplitContainer.Panel1.Controls.Add(this.findLabel);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.vKTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.vKLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.dateOfBirthLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.dateOfBirthTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.phoneNumberTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.phoneNumberLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.fullNameLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.emailTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.emailLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.fullNameTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.personPictureBox);
            this.MainSplitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainSplitContainer_Panel2_Paint);
            this.MainSplitContainer.Size = new System.Drawing.Size(800, 450);
            this.MainSplitContainer.SplitterDistance = 266;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // removeContactButton
            // 
            this.removeContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeContactButton.BackColor = System.Drawing.Color.White;
            this.removeContactButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeContactButton.BackgroundImage")));
            this.removeContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeContactButton.Location = new System.Drawing.Point(180, 410);
            this.removeContactButton.Name = "removeContactButton";
            this.removeContactButton.Size = new System.Drawing.Size(83, 40);
            this.removeContactButton.TabIndex = 12;
            this.removeContactButton.UseVisualStyleBackColor = false;
            // 
            // editContactButton
            // 
            this.editContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editContactButton.BackColor = System.Drawing.Color.White;
            this.editContactButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editContactButton.BackgroundImage")));
            this.editContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editContactButton.Location = new System.Drawing.Point(97, 410);
            this.editContactButton.Name = "editContactButton";
            this.editContactButton.Size = new System.Drawing.Size(83, 40);
            this.editContactButton.TabIndex = 11;
            this.editContactButton.UseVisualStyleBackColor = false;
            this.editContactButton.Click += new System.EventHandler(this.editContactButton_Click);
            // 
            // addContactButton
            // 
            this.addContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addContactButton.BackColor = System.Drawing.Color.White;
            this.addContactButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addContactButton.BackgroundImage")));
            this.addContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addContactButton.ForeColor = System.Drawing.Color.White;
            this.addContactButton.Location = new System.Drawing.Point(14, 410);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(83, 40);
            this.addContactButton.TabIndex = 3;
            this.addContactButton.UseVisualStyleBackColor = false;
            this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
            // 
            // contactsListBox
            // 
            this.contactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactsListBox.FormattingEnabled = true;
            this.contactsListBox.Location = new System.Drawing.Point(14, 36);
            this.contactsListBox.Name = "contactsListBox";
            this.contactsListBox.Size = new System.Drawing.Size(249, 368);
            this.contactsListBox.TabIndex = 2;
            // 
            // findTextBox
            // 
            this.findTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findTextBox.Location = new System.Drawing.Point(49, 10);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(214, 20);
            this.findTextBox.TabIndex = 1;
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Location = new System.Drawing.Point(13, 13);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(30, 13);
            this.findLabel.TabIndex = 0;
            this.findLabel.Text = "Find:";
            this.findLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // vKTextBox
            // 
            this.vKTextBox.Location = new System.Drawing.Point(110, 280);
            this.vKTextBox.Name = "vKTextBox";
            this.vKTextBox.Size = new System.Drawing.Size(204, 20);
            this.vKTextBox.TabIndex = 10;
            // 
            // vKLabel
            // 
            this.vKLabel.AutoSize = true;
            this.vKLabel.Location = new System.Drawing.Point(110, 264);
            this.vKLabel.Name = "vKLabel";
            this.vKLabel.Size = new System.Drawing.Size(24, 13);
            this.vKLabel.TabIndex = 9;
            this.vKLabel.Text = "VK:";
            this.vKLabel.Click += new System.EventHandler(this.VKLabel_Click);
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(110, 201);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.dateOfBirthLabel.TabIndex = 8;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // dateOfBirthTextBox
            // 
            this.dateOfBirthTextBox.Location = new System.Drawing.Point(110, 217);
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.Size = new System.Drawing.Size(204, 20);
            this.dateOfBirthTextBox.TabIndex = 7;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(110, 154);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(204, 20);
            this.phoneNumberTextBox.TabIndex = 6;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(110, 138);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneNumberLabel.TabIndex = 5;
            this.phoneNumberLabel.Text = "PhoneNumber:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(110, 13);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fullNameLabel.TabIndex = 1;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Location = new System.Drawing.Point(110, 90);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(417, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(110, 74);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "E-mail:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTextBox.Location = new System.Drawing.Point(110, 29);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(417, 20);
            this.fullNameTextBox.TabIndex = 2;
            this.fullNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // personPictureBox
            // 
            this.personPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personPictureBox.BackgroundImage")));
            this.personPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.personPictureBox.Location = new System.Drawing.Point(4, 10);
            this.personPictureBox.Name = "personPictureBox";
            this.personPictureBox.Size = new System.Drawing.Size(100, 100);
            this.personPictureBox.TabIndex = 0;
            this.personPictureBox.TabStop = false;
            this.personPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel1.PerformLayout();
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.ListBox contactsListBox;
        private System.Windows.Forms.PictureBox personPictureBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.TextBox dateOfBirthTextBox;
        private System.Windows.Forms.TextBox vKTextBox;
        private System.Windows.Forms.Label vKLabel;
        private System.Windows.Forms.Button removeContactButton;
        private System.Windows.Forms.Button editContactButton;
        private System.Windows.Forms.Button addContactButton;
    }
}

