using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает проект.
    /// </summary>
    internal class Project
    {
        /// <summary>
        /// Контакты.
        /// </summary>
        private List<Contact> _contacts;

        /// <summary>
        /// Возвращает или задаёт контакты.
        /// </summary>
        public List<Contact> Contacts
        {
            get { return _contacts; }
            set
            {
                _contacts = SortContacts(value);
            }
        }

        Project(List<Contact> contacts)
        {
            this._contacts = contacts;
        }

        /// <summary>
        /// Поиск именинников.
        /// </summary>
        public List<Contact> FindBirthdayBoys()
        {
            List<Contact> birthdayBoys;
            DateTime today = DateTime.Today;
            birthdayBoys = _contacts.FindAll(contact => contact.DateOfBirth.Date == today);
            return birthdayBoys;
        }

        /// <summary>
        /// Поиск контакта.
        /// </summary>
        public List<Contact> FindContact(string soughtContact)
        {
            return _contacts.FindAll(contact => (contact.FullName.IndexOf(soughtContact) != -1) ||
            (ToCapitalLettersStyle(contact.FullName).IndexOf(soughtContact) != -1));
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
