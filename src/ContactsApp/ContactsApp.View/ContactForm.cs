﻿using System;
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

        private string _fullNameError;

        private string _emailError;

        private string _phoneNumberError;

        private string _vkIdError;

        private string _dateOfBirthError;

        public ContactForm()
        {
            InitializeComponent();
            addPhotoButton.FlatStyle = FlatStyle.Flat;
            addPhotoButton.FlatAppearance.BorderSize = 1;
            addPhotoButton.FlatAppearance.BorderColor = Color.White;
            _contact = new Contact("Иван Иванович", "ivashka@ivan.com", "89001003355", new DateTime(2000, 1, 1), "");
            UpdateForm();
        }

        private void oKButton_Click(object sender, EventArgs e)
        {
            if(CheckFormOnError())
            {
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPhotoButton_MouseEnter(object sender, EventArgs e)
        {
            this.addPhotoButton.Image = Properties.Resources.add_photo_32x32;
            this.addPhotoButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void addPhotoButton_MouseLeave(object sender, EventArgs e)
        {
            this.addPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
            this.addPhotoButton.BackColor = Color.White;
        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.FullName = fullNameTextBox.Text;
                _fullNameError = "";
                fullNameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                _fullNameError = exception.Message;
                fullNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = emailTextBox.Text;
                _emailError = "";
                emailTextBox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                _emailError = exception.Message;
                emailTextBox.BackColor = Color.LightPink;
            }
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.PhoneNumber = phoneNumberTextBox.Text;
                _phoneNumberError = "";
                phoneNumberTextBox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                _phoneNumberError = exception.Message;
                phoneNumberTextBox.BackColor = Color.LightPink;
            }
        }

        private void vkTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.VkId = vkTextBox.Text;
                _vkIdError = "";
                vkTextBox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                _vkIdError = exception.Message;
                vkTextBox.BackColor = Color.LightPink;
            }
        }

        private void dateOfBirthTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.DateOfBirth = dateOfBirthTimePicker.Value;
                _dateOfBirthError = "";
                dateOfBirthTimePicker.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                _dateOfBirthError = exception.Message;
                dateOfBirthTimePicker.BackColor = Color.LightPink;
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
            if((_fullNameError != "") || (_emailError != "") || 
                (_phoneNumberError != "") || (_vkIdError != "")  || (_dateOfBirthError != ""))
            {
                MessageBox.Show(_fullNameError + " " + _emailError + 
                    " " + _phoneNumberError + " " + _vkIdError + " " + _dateOfBirthError);
                return false;
            }
            return true;
        }
    }
}
