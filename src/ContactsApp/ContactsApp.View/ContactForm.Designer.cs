namespace ContactsApp.View
{
    partial class ContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.vkTextBox = new System.Windows.Forms.TextBox();
            this.vkLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.personPictureBox = new System.Windows.Forms.PictureBox();
            this.addPhotoButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okPanel = new System.Windows.Forms.Panel();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).BeginInit();
            this.okPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // vkTextBox
            // 
            this.vkTextBox.Location = new System.Drawing.Point(118, 282);
            this.vkTextBox.Name = "vkTextBox";
            this.vkTextBox.Size = new System.Drawing.Size(204, 20);
            this.vkTextBox.TabIndex = 21;
            // 
            // vkLabel
            // 
            this.vkLabel.AutoSize = true;
            this.vkLabel.Location = new System.Drawing.Point(118, 266);
            this.vkLabel.Name = "vkLabel";
            this.vkLabel.Size = new System.Drawing.Size(24, 13);
            this.vkLabel.TabIndex = 20;
            this.vkLabel.Text = "VK:";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(118, 203);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.dateOfBirthLabel.TabIndex = 19;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(118, 156);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(204, 20);
            this.phoneNumberTextBox.TabIndex = 17;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(118, 140);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneNumberLabel.TabIndex = 16;
            this.phoneNumberLabel.Text = "PhoneNumber:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(118, 15);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fullNameLabel.TabIndex = 12;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Location = new System.Drawing.Point(118, 92);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(394, 20);
            this.emailTextBox.TabIndex = 15;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(118, 76);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "E-mail:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTextBox.Location = new System.Drawing.Point(118, 31);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(394, 20);
            this.fullNameTextBox.TabIndex = 13;
            // 
            // personPictureBox
            // 
            this.personPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personPictureBox.BackgroundImage")));
            this.personPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.personPictureBox.Location = new System.Drawing.Point(12, 12);
            this.personPictureBox.Name = "personPictureBox";
            this.personPictureBox.Size = new System.Drawing.Size(100, 100);
            this.personPictureBox.TabIndex = 11;
            this.personPictureBox.TabStop = false;
            // 
            // addPhotoButton
            // 
            this.addPhotoButton.BackColor = System.Drawing.Color.White;
            this.addPhotoButton.BackgroundImage = global::ContactsApp.View.Properties.Resources.add_photo_32x32_gray;
            this.addPhotoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addPhotoButton.FlatAppearance.BorderSize = 0;
            this.addPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPhotoButton.Location = new System.Drawing.Point(12, 118);
            this.addPhotoButton.Name = "addPhotoButton";
            this.addPhotoButton.Size = new System.Drawing.Size(100, 47);
            this.addPhotoButton.TabIndex = 23;
            this.addPhotoButton.UseVisualStyleBackColor = false;
            this.addPhotoButton.MouseEnter += new System.EventHandler(this.addPhotoButton_MouseEnter);
            this.addPhotoButton.MouseLeave += new System.EventHandler(this.addPhotoButton_MouseLeave);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(346, 21);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.oKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(427, 21);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okPanel
            // 
            this.okPanel.BackColor = System.Drawing.Color.Azure;
            this.okPanel.Controls.Add(this.okButton);
            this.okPanel.Controls.Add(this.cancelButton);
            this.okPanel.Location = new System.Drawing.Point(-3, 321);
            this.okPanel.Name = "okPanel";
            this.okPanel.Size = new System.Drawing.Size(529, 60);
            this.okPanel.TabIndex = 24;
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(118, 219);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(204, 20);
            this.BirthdayDateTimePicker.TabIndex = 25;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 377);
            this.Controls.Add(this.BirthdayDateTimePicker);
            this.Controls.Add(this.okPanel);
            this.Controls.Add(this.addPhotoButton);
            this.Controls.Add(this.vkTextBox);
            this.Controls.Add(this.vkLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.personPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactForm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).EndInit();
            this.okPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vkTextBox;
        private System.Windows.Forms.Label vkLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.PictureBox personPictureBox;
        private System.Windows.Forms.Button addPhotoButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel okPanel;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
    }
}