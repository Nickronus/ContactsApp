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
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Контакт.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Текст ошибки полного имени.
        /// </summary>
        private string _fullNameError = "";

        /// <summary>
        /// Текст ошибки email.
        /// </summary>
        private string _emailError = "";

        /// <summary>
        /// Текст ошибке номера телефона.
        /// </summary>
        private string _phoneNumberError = "";

        /// <summary>
        /// Текст ошибки Вк ID.
        /// </summary>
        private string _vkIdError = "";

        /// <summary>
        /// Текст ошибки даты рождения.
        /// </summary>
        private string _dateOfBirthError = "";

        /// <summary>
        /// Возвращает или задаёт контакт.
        /// </summary>
        public Contact Contact
        {
            get 
            {
                return _contact; 
            }
            set
            {
                _contact = value;
            }
        }

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            _contact = new Contact();
            //_contact = new Contact("Иван Иванович", "ivashka@ivan.com", "89001003355", new DateTime(2000, 1, 1), "");
        }

        /// <summary>
        /// Конструктор с параметром контакта.
        /// </summary>
        /// <param name="contact"></param>
        public ContactForm(Contact contact)
        {
            InitializeComponent();
            Contact = contact;
            UpdateForm();
            //_contact = new Contact("Иван Иванович", "ivashka@ivan.com", "89001003355", new DateTime(2000, 1, 1), "");
        }

        private void oKButton_Click(object sender, EventArgs e)
        {
            if(CheckFormOnError())
            {
                UpdateContact();
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Не сохранять контакт?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Contact = null;
                this.Close();
            }
        }

        private void addPhotoButton_MouseEnter(object sender, EventArgs e)
        {
            this.addPhotoButton.Image = Properties.Resources.add_photo_32x32;
            this.addPhotoButton.BackColor = ContactsAppColors.mouseEnter;
        }

        private void addPhotoButton_MouseLeave(object sender, EventArgs e)
        {
            this.addPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
            this.addPhotoButton.BackColor = ContactsAppColors.mouseLeave;
        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact contact = new Contact();
                contact.FullName = fullNameTextBox.Text;
                _fullNameError = "";
                fullNameTextBox.BackColor = ContactsAppColors.allOkColor;
            }
            catch (ArgumentException exception)
            {
                _fullNameError = exception.Message;
                fullNameTextBox.BackColor = ContactsAppColors.errorColor;
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact contact = new Contact();
                contact.Email = emailTextBox.Text;
                _emailError = "";
                emailTextBox.BackColor = ContactsAppColors.allOkColor;
            }
            catch (ArgumentException exception)
            {
                _emailError = exception.Message;
                emailTextBox.BackColor = ContactsAppColors.errorColor;
            }
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact contact = new Contact();
                contact.PhoneNumber = phoneNumberTextBox.Text;
                _phoneNumberError = "";
                phoneNumberTextBox.BackColor = ContactsAppColors.allOkColor;
            }
            catch (ArgumentException exception)
            {
                _phoneNumberError = exception.Message;
                phoneNumberTextBox.BackColor = ContactsAppColors.errorColor;
            }
        }

        private void vkTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact contact = new Contact();
                contact.VkId = vkTextBox.Text;
                _vkIdError = "";
                vkTextBox.BackColor = ContactsAppColors.allOkColor;
            }
            catch (ArgumentException exception)
            {
                _vkIdError = exception.Message;
                vkTextBox.BackColor = ContactsAppColors.errorColor;
            }
        }

        private void dateOfBirthTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Contact contact = new Contact();
                contact.DateOfBirth = dateOfBirthTimePicker.Value;
                _dateOfBirthError = "";
                dateOfBirthTimePicker.BackColor = ContactsAppColors.allOkColor;
            }
            catch (ArgumentException exception)
            {
                _dateOfBirthError = exception.Message;
                dateOfBirthTimePicker.BackColor = ContactsAppColors.errorColor;
            }
        }

        /// <summary>
        /// Обновление данных контакта.
        /// </summary>
        private void UpdateForm()
        {
            fullNameTextBox.Text = _contact.FullName;
            emailTextBox.Text = _contact.Email;
            phoneNumberTextBox.Text = _contact.PhoneNumber;
            dateOfBirthTimePicker.Value = _contact.DateOfBirth;
            vkTextBox.Text = _contact.VkId;
        }

        /// <summary>
        /// Возвращает true, если в форме нет ошибок.
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnError()
        {
            if((_fullNameError == "") && (_emailError == "") && 
                (_phoneNumberError == "") && (_vkIdError == "")  && (_dateOfBirthError == ""))
            {
                return true;
            }
            MessageBox.Show(_fullNameError + " " + _emailError +
             " " + _phoneNumberError + " " + _vkIdError + " " + _dateOfBirthError);
            return false;
        }

        /// <summary>
        /// Обновление данных контакта.
        /// </summary>
        private void UpdateContact()
        {
            _contact.Email = emailTextBox.Text;
            _contact.FullName = fullNameTextBox.Text;
            _contact.DateOfBirth = dateOfBirthTimePicker.Value;
            _contact.PhoneNumber = phoneNumberTextBox.Text;
            _contact.VkId = vkTextBox.Text;
        }
    }
}
