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

        /// <summary>
        /// Отображаемый проект.
        /// </summary>
        Project _currentProject;

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _project = new Project();
            _project.SortContacts();
            _currentProject = new Project();
            _currentProject.Contacts = _project.Contacts;
            this.KeyPreview = true;
            //TODO запихивать в лист при загрузке из файла проект.
        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
            _project.SortContacts();
            UpdateCurrentProject();
            UpdateListBox();
        }

        private void editContactButton_Click(object sender, EventArgs e)
        {
            if(contactsListBox.SelectedIndex != -1)
            {
                int index = _project.Contacts.IndexOf(_currentProject.Contacts[contactsListBox.SelectedIndex]);
                EditContact(index);
                UpdateCurrentProject();
                UpdateListBox();
                if(_currentProject.Contacts.Count == 0)
                {
                    findTextBox.Text = "";
                    UpdateCurrentProject();
                    UpdateListBox();
                    UpdateSelectedContact(index);
                    contactsListBox.SelectedIndex = index;
                }
                else
                {
                    UpdateSelectedContact(0);
                }
            }
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
            if(contactsListBox.SelectedIndex != -1)
            {
                RemoveContact(_project.Contacts.IndexOf(_currentProject.Contacts[contactsListBox.SelectedIndex]));
                UpdateCurrentProject();
                UpdateListBox();
                if (contactsListBox.Items.Count != 0)
                {
                    UpdateSelectedContact(0);
                }
                else
                {
                    ClearSelectedContact();
                }
            }
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

        private void findTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateCurrentProject();
            UpdateListBox();
        }

        /// <summary>
        /// Обновление ListBox с загрузкой в него данных из _project.
        /// </summary>
        private void UpdateListBox()
        {
            contactsListBox.Items.Clear();
            for (int i = 0; i < _currentProject.Contacts.Count(); i++)
            {
                contactsListBox.Items.Add(_currentProject.Contacts[i].FullName);
            }
        }
        /// <summary>
        /// Добавление контактов в проект.
        /// </summary>
        private void AddContact()
        {
            ContactForm contactForm = new ContactForm();
            contactForm.ShowDialog();
            contactForm.Close();
            if ((contactForm.Contact != null) && ((contactForm.Contact.Email != "") || 
            (contactForm.Contact.FullName != "") || (contactForm.Contact.VkId != "") || 
            (contactForm.Contact.PhoneNumber != "")))
            {
                _project.Contacts.Add(contactForm.Contact);
            }
            
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
            fullNameTextBox.Text = _currentProject.Contacts[index].FullName;
            emailTextBox.Text = _currentProject.Contacts[index].Email;
            phoneNumberTextBox.Text = _currentProject.Contacts[index].PhoneNumber;
            dateOfBirthTextBox.Text = _currentProject.Contacts[index].DateOfBirth.Date.ToString().Remove(11);
            vkTextBox.Text = _currentProject.Contacts[index].VkId;
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

        /// <summary>
        /// Добавление рандомного контакта.
        /// </summary>
        private void AddRandomContact()
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
        /// Редактирование контакта.
        /// </summary>
        /// <param name="index"></param>
        private void EditContact(int index)
        {
            ContactForm contactForm = new ContactForm((Contact)_project.Contacts[index].Clone());
            contactForm.ShowDialog();
            contactForm.Close();
            if ((contactForm.Contact != null) && ((contactForm.Contact.Email != "") ||
            (contactForm.Contact.FullName != "") || (contactForm.Contact.VkId != "") ||
            (contactForm.Contact.PhoneNumber != "")))
            {
                _project.Contacts[index] = contactForm.Contact;
            }
        }

        /// <summary>
        /// Обновление отображаемого списка контактов.
        /// </summary>
        private void UpdateCurrentProject()
        {
            if (findTextBox.Text == "")
            {
                _currentProject.Contacts = _project.Contacts;
            }
            else
            {
                _currentProject.Contacts = _project.FindContacts(findTextBox.Text);
            }
        }
    }
}
