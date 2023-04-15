//TODO ContactApp.Model - Свойства - поменять на библиотеку классов,
//назначиь вьюху запускаемым проектом.
namespace ContactsApp.Model
{
    using System;
    using System.Linq;
    using System.Globalization;

    /// <summary>
    /// Контакт.
    /// </summary>
    public class Contact : System.ICloneable
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
            Email = Email;
            PhoneNumber = PhoneNumber;
            FullName = FullName;
            DateOfBirth = DateOfBirth;
            VkId = VkId;
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
                CheckLengthOfTheString(value, 100);
                _fullName = ToCapitalLettersStyle(value);
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
                CheckLengthOfTheString(value, 100);
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
                    throw new ArgumentException(String.Format("Error. Incorrect data."));
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
                CheckLengthOfTheString(value, 50);
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

        /// <summary>
        /// Приведение строки к стилю "Каждое слово с заглавной буквы".
        /// </summary>
        private string ToCapitalLettersStyle(string value)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(value);
        }

        /// <summary>
        /// Проверка длины строки на соответствие необходимой длине.
        /// </summary>
        private void CheckLengthOfTheString(string value, int maxLength)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException(String.Format("Error. Size more then max."));
            }
        }
    }
}

