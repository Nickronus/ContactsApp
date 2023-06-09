﻿//TODO ContactApp.Model - Свойства - поменять на библиотеку классов,
//назначиь вьюху запускаемым проектом.
namespace ContactsApp.Model
{
    using System;
    using System.Linq;

    /// <summary>
    /// Контакт.
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Полное имя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Е-маил.
        /// </summary>
        private string _email;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Дата рождения.
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// ID "Вконтакте".
        /// </summary>
        private string _vkId;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
            Email = "";
            PhoneNumber = "";
            FullName = "";
            DateOfBirth = new DateTime(2000, 1, 1);
            VkId = "";
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/> с заданными полями.
        /// </summary>
        public Contact(string fullName, string email, string phoneNumber, DateTime dateOfBirth, string vkId)
        {
            Email = email;
            PhoneNumber = phoneNumber;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            VkId = vkId;
        }

        /// <summary>
        /// Возвращает или задает полное имя.
        /// </summary>
        public string FullName
        {
            get 
            { 
                return _fullName; 
            }
            set 
            {
                ContactsService.CheckLengthOfTheString(value, 100);
                _fullName = ContactsService.ToCapitalLettersStyle(value);
            }
        }

        /// <summary>
        /// Возвращает или задает Е-маил.
        /// </summary>
        public string Email
        {
            get 
            { 
                return _email; 
            }
            set
            {
                ContactsService.CheckLengthOfTheString(value, 100);
                _email = value;
            }
        }

        /// <summary>
        /// Возвращает или задает номер телефона.
        /// </summary>
        public string PhoneNumber
        {
            get 
            { 
                return _phoneNumber; 
            }
            set
            {
                string allowedChars = "1234567890+- )(";
                if (! value.All(c => allowedChars.Contains(c)))
                {
                    throw new ArgumentException(String.Format("The phone number contains invalid characters"));
                }
                    value = new string(value.Where(c => allowedChars.Contains(c)).ToArray());
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает или задает дату рождения.
        /// </summary>
        public DateTime DateOfBirth
        {
            get 
            { 
                return _dateOfBirth; 
            }
            set
            {
                if ((value > DateTime.Now)||(value < new DateTime(1900, 1, 1)))
                {
                    throw new ArgumentException(String.Format("Invalid date"));
                }
                _dateOfBirth = value;
            }
        }

        /// <summary>
        /// Возвращает или задает ID "Вконтакте".
        /// </summary>
        public string VkId
        {
            get 
            { 
                return _vkId; 
            }
            set
            {
                ContactsService.CheckLengthOfTheString(value, 50);
                _vkId = value;
            }
        }

        /// <summary>
        /// Клонирование данного объекта.
        /// </summary>
        public object Clone()
        {
            Contact contact = new Contact();
            contact.Email = Email;
            contact.PhoneNumber = PhoneNumber;
            contact.FullName = FullName;
            contact.DateOfBirth = DateOfBirth;
            contact.VkId = VkId;
            return contact;
        }
    }
}

