namespace ContactsApp.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.contactsAppLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.githubLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.oKButton = new System.Windows.Forms.Button();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.gitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.usedImagesLabel = new System.Windows.Forms.Label();
            this.usedImagesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // contactsAppLabel
            // 
            this.contactsAppLabel.AutoSize = true;
            this.contactsAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactsAppLabel.Location = new System.Drawing.Point(13, 13);
            this.contactsAppLabel.Name = "contactsAppLabel";
            this.contactsAppLabel.Size = new System.Drawing.Size(146, 25);
            this.contactsAppLabel.TabIndex = 0;
            this.contactsAppLabel.Text = "ContactsApp";
            this.contactsAppLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(18, 42);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(28, 13);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "v1.0";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(21, 76);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "Author:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(21, 101);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "E-mail:";
            // 
            // githubLabel
            // 
            this.githubLabel.AutoSize = true;
            this.githubLabel.Location = new System.Drawing.Point(21, 126);
            this.githubLabel.Name = "githubLabel";
            this.githubLabel.Size = new System.Drawing.Size(41, 13);
            this.githubLabel.TabIndex = 6;
            this.githubLabel.Text = "Github:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(105, 76);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(77, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Nikita Golubev";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(105, 101);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(94, 13);
            this.mailLabel.TabIndex = 8;
            this.mailLabel.Text = "nickronus@mail.ru";
            // 
            // oKButton
            // 
            this.oKButton.Location = new System.Drawing.Point(431, 395);
            this.oKButton.Name = "oKButton";
            this.oKButton.Size = new System.Drawing.Size(75, 23);
            this.oKButton.TabIndex = 10;
            this.oKButton.Text = "OK";
            this.oKButton.UseVisualStyleBackColor = true;
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.Location = new System.Drawing.Point(12, 157);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.Size = new System.Drawing.Size(494, 208);
            this.infoRichTextBox.TabIndex = 11;
            this.infoRichTextBox.Text = resources.GetString("infoRichTextBox.Text");
            // 
            // gitLinkLabel
            // 
            this.gitLinkLabel.AutoSize = true;
            this.gitLinkLabel.Location = new System.Drawing.Point(105, 126);
            this.gitLinkLabel.Name = "gitLinkLabel";
            this.gitLinkLabel.Size = new System.Drawing.Size(148, 13);
            this.gitLinkLabel.TabIndex = 12;
            this.gitLinkLabel.TabStop = true;
            this.gitLinkLabel.Text = "https://github.com/Nickronus";
            // 
            // usedImagesLabel
            // 
            this.usedImagesLabel.Location = new System.Drawing.Point(9, 368);
            this.usedImagesLabel.Name = "usedImagesLabel";
            this.usedImagesLabel.Size = new System.Drawing.Size(190, 18);
            this.usedImagesLabel.TabIndex = 0;
            this.usedImagesLabel.Text = "All used images are downloaded from";
            // 
            // usedImagesLinkLabel
            // 
            this.usedImagesLinkLabel.AutoSize = true;
            this.usedImagesLinkLabel.Location = new System.Drawing.Point(189, 368);
            this.usedImagesLinkLabel.Name = "usedImagesLinkLabel";
            this.usedImagesLinkLabel.Size = new System.Drawing.Size(127, 13);
            this.usedImagesLinkLabel.TabIndex = 13;
            this.usedImagesLinkLabel.TabStop = true;
            this.usedImagesLinkLabel.Text = "https://www.flaticon.com";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 451);
            this.Controls.Add(this.usedImagesLinkLabel);
            this.Controls.Add(this.usedImagesLabel);
            this.Controls.Add(this.gitLinkLabel);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.oKButton);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.githubLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.contactsAppLabel);
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contactsAppLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label githubLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Button oKButton;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.LinkLabel gitLinkLabel;
        private System.Windows.Forms.Label usedImagesLabel;
        private System.Windows.Forms.LinkLabel usedImagesLinkLabel;
    }
}