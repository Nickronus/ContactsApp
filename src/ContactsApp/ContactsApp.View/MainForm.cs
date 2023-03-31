using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            addContactButton.FlatStyle = FlatStyle.Flat;
            addContactButton.FlatAppearance.BorderSize = 0;
            addContactButton.FlatAppearance.BorderColor = Color.White;
            editContactButton.FlatStyle = FlatStyle.Flat;
            editContactButton.FlatAppearance.BorderSize = 0;
            editContactButton.FlatAppearance.BorderColor = Color.White;
            removeContactButton.FlatStyle = FlatStyle.Flat;
            removeContactButton.FlatAppearance.BorderSize = 0;
            removeContactButton.FlatAppearance.BorderColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainSplitContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void VKLabel_Click(object sender, EventArgs e)
        {

        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.ShowDialog();
        }

        private void editContactButton_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.ShowDialog();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                AboutForm aboutForm = new AboutForm();
                aboutForm.ShowDialog();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void cloeInfoButton_Click(object sender, EventArgs e)
        {
            this.birthdayInfoPanel.Visible = false;
            this.birthdayInfoPictureBox.Visible = false;
            this.birthdayLabel.Visible = false;
            this.birthdayNamesLabel.Visible = false;
        }

        private void addContactButton_MouseEnter(object sender, EventArgs e)
        {
            this.addContactButton.Image = Properties.Resources.add_contact_32x32;
            this.addContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void addContactButton_MouseLeave(object sender, EventArgs e)
        {
            this.addContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            this.addContactButton.BackColor = Color.White;
        }

        private void editContactButton_MouseEnter(object sender, EventArgs e)
        {
            this.editContactButton.Image = Properties.Resources.edit_contact_32x32;
            this.editContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void editContactButton_MouseLeave(object sender, EventArgs e)
        {
            this.editContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            this.editContactButton.BackColor = Color.White;
        }

        private void removeContactButton_MouseEnter(object sender, EventArgs e)
        {
            this.removeContactButton.Image = Properties.Resources.remove_contact_32x32;
            this.removeContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void removeContactButton_MouseLeave(object sender, EventArgs e)
        {
            this.removeContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            this.removeContactButton.BackColor = Color.White;
        }

        private void fullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dateOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void vKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
