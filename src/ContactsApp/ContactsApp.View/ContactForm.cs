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
    /// <summary>
    /// Форма контакта.
    /// </summary>
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
                if(value != null)
                {
                    UpdateForm();
                }
            }
        }

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            _contact = new Contact();
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
        }

        private void oKButton_Click(object sender, EventArgs e)
        {
            if(CheckFormOnError())
            {
                UpdateContact();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Contact = null;
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addPhotoButton_MouseEnter(object sender, EventArgs e)
        {
            this.addPhotoButton.Image = Properties.Resources.add_photo_32x32;
            this.addPhotoButton.BackColor = ContactsAppColors.MouseEnter;
        }

        private void addPhotoButton_MouseLeave(object sender, EventArgs e)
        {
            this.addPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
            this.addPhotoButton.BackColor = ContactsAppColors.MouseLeave;
        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact contact = new Contact();
                contact.FullName = fullNameTextBox.Text;
                _fullNameError = "";
                fullNameTextBox.BackColor = ContactsAppColors.AllOkColor;
            }
            catch (ArgumentException exception)
            {
                _fullNameError = exception.Message;
                fullNameTextBox.BackColor = ContactsAppColors.ErrorColor;
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact contact = new Contact();
                contact.Email = emailTextBox.Text;
                _emailError = "";
                emailTextBox.BackColor = ContactsAppColors.AllOkColor;
            }
            catch (ArgumentException exception)
            {
                _emailError = exception.Message;
                emailTextBox.BackColor = ContactsAppColors.ErrorColor;
            }
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact contact = new Contact();
                contact.PhoneNumber = phoneNumberTextBox.Text;
                _phoneNumberError = "";
                phoneNumberTextBox.BackColor = ContactsAppColors.AllOkColor;
            }
            catch (ArgumentException exception)
            {
                _phoneNumberError = exception.Message;
                phoneNumberTextBox.BackColor = ContactsAppColors.ErrorColor;
            }
        }

        private void vkTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact contact = new Contact();
                contact.VkId = vkTextBox.Text;
                _vkIdError = "";
                vkTextBox.BackColor = ContactsAppColors.AllOkColor;
            }
            catch (ArgumentException exception)
            {
                _vkIdError = exception.Message;
                vkTextBox.BackColor = ContactsAppColors.ErrorColor;
            }
        }

        private void dateOfBirthTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Contact contact = new Contact();
                contact.DateOfBirth = dateOfBirthTimePicker.Value;
                _dateOfBirthError = "";
                dateOfBirthTimePicker.BackColor = ContactsAppColors.AllOkColor;
            }
            catch (ArgumentException exception)
            {
                _dateOfBirthError = exception.Message;
                dateOfBirthTimePicker.BackColor = ContactsAppColors.ErrorColor;
            }
        }

        private void addPhotoButton_Click(object sender, EventArgs e)
        {/*Раскомментировать после добавления логики в кнопку добавления фото.
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Изображения (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            fileDialog.Title = "Выберите изображение";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                personPictureBox.ImageLocation = fileDialog.FileName;
            }
            */
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
            string errorMessage = "";
            if(_fullNameError != "")
            {
                errorMessage += _fullNameError + " in Full Name.";
            }
            if (_emailError != "")
            {
                errorMessage += "\n" + _emailError + " in Email.";
            }
            if (_phoneNumberError != "")
            {
                errorMessage += "\n" + _phoneNumberError;
            }
            if (_vkIdError != "")
            {
                errorMessage += "\n" + _vkIdError + " in Vk Id.";
            }
            if (_dateOfBirthError != "")
            {
                errorMessage += "\n" + _dateOfBirthError;
            }
            MessageBox.Show(errorMessage);
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
