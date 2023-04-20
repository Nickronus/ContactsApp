using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Проект.
        /// </summary>
        Project _project;

        public MainForm()
        {
            InitializeComponent();
            _project = new Project();
            this.KeyPreview = true;
        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.ShowDialog();

            AddContact();
            UpdateListBox();
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

        private void closeInfoButton_Click(object sender, EventArgs e)
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

        private void removeContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(contactsListBox.SelectedIndex);
            UpdateListBox();
        }

        private void contactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (contactsListBox.SelectedIndex == -1)
            {
                ClearSelectedContact();
            }
            else
            {
                UpdateSelectedContact(contactsListBox.SelectedIndex);
            }
        }

        /// <summary>
        /// Обновление ListBox с загрузкой в него данных из _project.
        /// </summary>
        private void UpdateListBox()
        {
            contactsListBox.Items.Clear();
            for (int i = 0; i < _project.Contacts.Count(); i++)
            {
                contactsListBox.Items.Add(_project.Contacts[i].FullName);
            }
        }
        /// <summary>
        /// Добавление контактов в проект (random).
        /// </summary>
        private void AddContact()
        {
            Random rnd = new Random();
            string[] firstNames = { "Иван ", "Катя ", "Владимир ", "Артём ",
                          "Дмитрий ", "Яна ", "Гриша ", "Семён ",
                          "Добрыня ", "Маруся " };
            string[] secondNames = { "Авакян", "Аматуни", "Багратуни", "Брутян",
                            "Галустян", "Григорян", "Дарбинян", "Есаянц",
                            "Иоаннисян", "Луспекян" };

            Contact contact = new Contact();
            int fIndex = rnd.Next(firstNames.Length);
            int sIndex = rnd.Next(secondNames.Length);
            contact.FullName = firstNames[fIndex] + secondNames[sIndex];
            _project.Contacts.Add(contact);
        }

        /// <summary>
        /// Удаляет контакт под указанным индексом из списка.
        /// </summary>
        /// <param name="index"></param>
        private void RemoveContact(int index)
        {
            if (index != -1)
            {
                string message = "Do you really want to remove " +
                    _project.Contacts[index].FullName + "?";
                DialogResult result;
                result = MessageBox.Show(message, "", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    _project.Contacts.Remove(_project.Contacts[index]);
                }
            }
        }

        /// <summary>
        /// Обновление панели данных контакта в соответствии с выбранным контактом.
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            fullNameTextBox.Text = _project.Contacts[index].FullName;
            emailTextBox.Text = _project.Contacts[index].Email;
            phoneNumberTextBox.Text = _project.Contacts[index].PhoneNumber;
            dateOfBirthTextBox.Text = _project.Contacts[index].DateOfBirth.Date.ToString().Remove(11);
            vkTextBox.Text = _project.Contacts[index].VkId;
        }

        /// <summary>
        /// Отчистка панели контакта.
        /// </summary>
        private void ClearSelectedContact()
        {
            fullNameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            dateOfBirthTextBox.Text = "";
            vkTextBox.Text = "";
        }
    }
}
