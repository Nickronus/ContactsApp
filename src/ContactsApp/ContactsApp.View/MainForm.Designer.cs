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
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.removeContactButton = new System.Windows.Forms.Button();
            this.editContactButton = new System.Windows.Forms.Button();
            this.addContactButton = new System.Windows.Forms.Button();
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findLabel = new System.Windows.Forms.Label();
            this.birthdayInfoPanel = new System.Windows.Forms.Panel();
            this.closeInfoButton = new System.Windows.Forms.Button();
            this.birthdayNamesLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.birthdayInfoPictureBox = new System.Windows.Forms.PictureBox();
            this.vkTextBox = new System.Windows.Forms.TextBox();
            this.vkLabel = new System.Windows.Forms.Label();
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
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.birthdayInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayInfoPictureBox)).BeginInit();
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
            this.MainSplitContainer.Panel1.Controls.Add(this.buttonsTableLayoutPanel);
            this.MainSplitContainer.Panel1.Controls.Add(this.contactsListBox);
            this.MainSplitContainer.Panel1.Controls.Add(this.findTextBox);
            this.MainSplitContainer.Panel1.Controls.Add(this.findLabel);
            this.MainSplitContainer.Panel1.Margin = new System.Windows.Forms.Padding(3);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.birthdayInfoPanel);
            this.MainSplitContainer.Panel2.Controls.Add(this.vkTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.vkLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.dateOfBirthLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.dateOfBirthTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.phoneNumberTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.phoneNumberLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.fullNameLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.emailTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.emailLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.fullNameTextBox);
            this.MainSplitContainer.Panel2.Controls.Add(this.personPictureBox);
            this.MainSplitContainer.Panel2.Margin = new System.Windows.Forms.Padding(3);
            this.MainSplitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainSplitContainer_Panel2_Paint);
            this.MainSplitContainer.Size = new System.Drawing.Size(800, 450);
            this.MainSplitContainer.SplitterDistance = 264;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.ColumnCount = 3;
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTableLayoutPanel.Controls.Add(this.removeContactButton, 2, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.editContactButton, 1, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.addContactButton, 0, 0);
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(4, 407);
            this.buttonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(257, 40);
            this.buttonsTableLayoutPanel.TabIndex = 14;
            // 
            // removeContactButton
            // 
            this.removeContactButton.BackColor = System.Drawing.Color.White;
            this.removeContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.removeContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeContactButton.FlatAppearance.BorderSize = 0;
            this.removeContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeContactButton.Image = global::ContactsApp.View.Properties.Resources.remove_contact_32x32_gray;
            this.removeContactButton.Location = new System.Drawing.Point(170, 0);
            this.removeContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.removeContactButton.Name = "removeContactButton";
            this.removeContactButton.Size = new System.Drawing.Size(87, 40);
            this.removeContactButton.TabIndex = 12;
            this.removeContactButton.UseVisualStyleBackColor = false;
            this.removeContactButton.MouseEnter += new System.EventHandler(this.removeContactButton_MouseEnter);
            this.removeContactButton.MouseLeave += new System.EventHandler(this.removeContactButton_MouseLeave);
            // 
            // editContactButton
            // 
            this.editContactButton.BackColor = System.Drawing.Color.White;
            this.editContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editContactButton.FlatAppearance.BorderSize = 0;
            this.editContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editContactButton.Image = global::ContactsApp.View.Properties.Resources.edit_contact_32x32_gray;
            this.editContactButton.Location = new System.Drawing.Point(85, 0);
            this.editContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.editContactButton.Name = "editContactButton";
            this.editContactButton.Size = new System.Drawing.Size(85, 40);
            this.editContactButton.TabIndex = 11;
            this.editContactButton.UseVisualStyleBackColor = false;
            this.editContactButton.Click += new System.EventHandler(this.editContactButton_Click);
            this.editContactButton.MouseEnter += new System.EventHandler(this.editContactButton_MouseEnter);
            this.editContactButton.MouseLeave += new System.EventHandler(this.editContactButton_MouseLeave);
            // 
            // addContactButton
            // 
            this.addContactButton.BackColor = System.Drawing.Color.White;
            this.addContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addContactButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addContactButton.ForeColor = System.Drawing.Color.White;
            this.addContactButton.Image = global::ContactsApp.View.Properties.Resources.add_contact_32x32_gray;
            this.addContactButton.Location = new System.Drawing.Point(0, 0);
            this.addContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(85, 40);
            this.addContactButton.TabIndex = 3;
            this.addContactButton.UseVisualStyleBackColor = false;
            this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
            this.addContactButton.MouseEnter += new System.EventHandler(this.addContactButton_MouseEnter);
            this.addContactButton.MouseLeave += new System.EventHandler(this.addContactButton_MouseLeave);
            // 
            // contactsListBox
            // 
            this.contactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactsListBox.FormattingEnabled = true;
            this.contactsListBox.IntegralHeight = false;
            this.contactsListBox.Items.AddRange(new object[] {
            "Авшарян Витя",
            "Банников Саня",
            "Бутылкина Алёна",
            "Врач Василий",
            "Дроздов Владимир",
            "Зорин Петя",
            "Макаров Макар",
            "Яша Иванов"});
            this.contactsListBox.Location = new System.Drawing.Point(3, 29);
            this.contactsListBox.Margin = new System.Windows.Forms.Padding(0);
            this.contactsListBox.Name = "contactsListBox";
            this.contactsListBox.Size = new System.Drawing.Size(258, 378);
            this.contactsListBox.TabIndex = 13;
            // 
            // findTextBox
            // 
            this.findTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findTextBox.Location = new System.Drawing.Point(39, 3);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(222, 20);
            this.findTextBox.TabIndex = 1;
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Location = new System.Drawing.Point(0, 6);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(30, 13);
            this.findLabel.TabIndex = 0;
            this.findLabel.Text = "Find:";
            this.findLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // birthdayInfoPanel
            // 
            this.birthdayInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayInfoPanel.BackColor = System.Drawing.Color.Azure;
            this.birthdayInfoPanel.Controls.Add(this.closeInfoButton);
            this.birthdayInfoPanel.Controls.Add(this.birthdayNamesLabel);
            this.birthdayInfoPanel.Controls.Add(this.birthdayLabel);
            this.birthdayInfoPanel.Controls.Add(this.birthdayInfoPictureBox);
            this.birthdayInfoPanel.Location = new System.Drawing.Point(3, 367);
            this.birthdayInfoPanel.Name = "birthdayInfoPanel";
            this.birthdayInfoPanel.Size = new System.Drawing.Size(525, 80);
            this.birthdayInfoPanel.TabIndex = 11;
            // 
            // closeInfoButton
            // 
            this.closeInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeInfoButton.BackgroundImage")));
            this.closeInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeInfoButton.FlatAppearance.BorderSize = 0;
            this.closeInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeInfoButton.Location = new System.Drawing.Point(475, 6);
            this.closeInfoButton.Name = "closeInfoButton";
            this.closeInfoButton.Size = new System.Drawing.Size(42, 37);
            this.closeInfoButton.TabIndex = 3;
            this.closeInfoButton.UseVisualStyleBackColor = true;
            this.closeInfoButton.Click += new System.EventHandler(this.closeInfoButton_Click);
            // 
            // birthdayNamesLabel
            // 
            this.birthdayNamesLabel.AutoSize = true;
            this.birthdayNamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayNamesLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.birthdayNamesLabel.Location = new System.Drawing.Point(86, 40);
            this.birthdayNamesLabel.Name = "birthdayNamesLabel";
            this.birthdayNamesLabel.Size = new System.Drawing.Size(291, 13);
            this.birthdayNamesLabel.TabIndex = 2;
            this.birthdayNamesLabel.Text = "Афоня Иванов, Альфред Зюзьков, Карл Лысый";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdayLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.birthdayLabel.Location = new System.Drawing.Point(86, 16);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(124, 13);
            this.birthdayLabel.TabIndex = 1;
            this.birthdayLabel.Text = "Today is Birthday of:";
            // 
            // birthdayInfoPictureBox
            // 
            this.birthdayInfoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("birthdayInfoPictureBox.BackgroundImage")));
            this.birthdayInfoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.birthdayInfoPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("birthdayInfoPictureBox.InitialImage")));
            this.birthdayInfoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.birthdayInfoPictureBox.Name = "birthdayInfoPictureBox";
            this.birthdayInfoPictureBox.Size = new System.Drawing.Size(76, 76);
            this.birthdayInfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.birthdayInfoPictureBox.TabIndex = 0;
            this.birthdayInfoPictureBox.TabStop = false;
            this.birthdayInfoPictureBox.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // vkTextBox
            // 
            this.vkTextBox.Location = new System.Drawing.Point(109, 273);
            this.vkTextBox.Name = "vkTextBox";
            this.vkTextBox.Size = new System.Drawing.Size(204, 20);
            this.vkTextBox.TabIndex = 10;
            this.vkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vKTextBox_KeyPress);
            // 
            // vkLabel
            // 
            this.vkLabel.AutoSize = true;
            this.vkLabel.Location = new System.Drawing.Point(109, 257);
            this.vkLabel.Name = "vkLabel";
            this.vkLabel.Size = new System.Drawing.Size(24, 13);
            this.vkLabel.TabIndex = 9;
            this.vkLabel.Text = "VK:";
            this.vkLabel.Click += new System.EventHandler(this.VKLabel_Click);
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(109, 194);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.dateOfBirthLabel.TabIndex = 8;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // dateOfBirthTextBox
            // 
            this.dateOfBirthTextBox.Location = new System.Drawing.Point(109, 210);
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.Size = new System.Drawing.Size(204, 20);
            this.dateOfBirthTextBox.TabIndex = 7;
            this.dateOfBirthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateOfBirthTextBox_KeyPress);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(109, 147);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(204, 20);
            this.phoneNumberTextBox.TabIndex = 6;
            this.phoneNumberTextBox.Text = "8-900-123-17-71";
            this.phoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberTextBox_KeyPress);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(109, 131);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneNumberLabel.TabIndex = 5;
            this.phoneNumberLabel.Text = "PhoneNumber:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(109, 6);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fullNameLabel.TabIndex = 1;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Location = new System.Drawing.Point(109, 83);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(419, 20);
            this.emailTextBox.TabIndex = 4;
            this.emailTextBox.Text = "vova@pinguin.ru";
            this.emailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailTextBox_KeyPress);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(109, 67);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "E-mail:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTextBox.Location = new System.Drawing.Point(109, 22);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(419, 20);
            this.fullNameTextBox.TabIndex = 2;
            this.fullNameTextBox.Text = "Дядя Вова";
            this.fullNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.fullNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fullNameTextBox_KeyPress);
            // 
            // personPictureBox
            // 
            this.personPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personPictureBox.BackgroundImage")));
            this.personPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.personPictureBox.Location = new System.Drawing.Point(3, 3);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel1.PerformLayout();
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.birthdayInfoPanel.ResumeLayout(false);
            this.birthdayInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayInfoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.PictureBox personPictureBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.TextBox dateOfBirthTextBox;
        private System.Windows.Forms.TextBox vkTextBox;
        private System.Windows.Forms.Label vkLabel;
        private System.Windows.Forms.Button removeContactButton;
        private System.Windows.Forms.Button editContactButton;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.ListBox contactsListBox;
        private System.Windows.Forms.Panel birthdayInfoPanel;
        private System.Windows.Forms.PictureBox birthdayInfoPictureBox;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label birthdayNamesLabel;
        private System.Windows.Forms.Button closeInfoButton;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
    }
}

