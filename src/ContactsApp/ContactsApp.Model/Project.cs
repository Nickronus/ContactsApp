﻿namespace ContactsApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    /// <summary>
    /// Описывает проект.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Контакты.
        /// </summary>
        private List<Contact> _contacts;

        /// <summary>
        /// Возвращает или задаёт контакты.
        /// </summary>
        public List<Contact> Contacts { get; private set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Project"/>.
        /// </summary>
        public Project()
        {
            _contacts = new List<Contact>();
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Project"/> принимая список.
        /// </summary>
        public Project(List<Contact> contacts)
        {
            _contacts = contacts;
        }

        /// <summary>
        /// Поиск именинников.
        /// </summary>
        public List<Contact> FindBirthdayContacts(List<Contact> contacts)
        {
            List<Contact> birthdayContacts;
            DateTime today = DateTime.Today;
            birthdayContacts = contacts.FindAll(contact => (contact.DateOfBirth.Date.Month == today.Date.Month) &&
            (contact.DateOfBirth.Date.Day == today.Date.Day));
            return birthdayContacts;
        }

        /// <summary>
        /// Поиск контакта.
        /// </summary>
        public List<Contact> FindContact(string subString)
        {
            subString = subString.ToLower();
            return _contacts.FindAll(contact => contact.FullName.ToLower().Contains(subString));
        }

        /// <summary>
        /// Сортировка контактов.
        /// </summary>
        private List<Contact> SortContacts(List<Contact> contacts)
        {
            contacts.Sort((c1, c2) => c1.FullName.CompareTo(c2.FullName));
            return contacts;
        }

        /// <summary>
        /// Приведение строки к стилю "Каждое слово с заглавной буквы".
        /// </summary>
        private string ToCapitalLettersStyle(string value)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(value);
        }
    }
}
