using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
//TODU ContApp.M - Свойства - прилож виндоус поменять на библиотека классов
//назначиь вьюху запускаемым проектом
namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает контакт.
    /// </summary>
    internal class Contact : System.ICloneable
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
        /// Пустой конструктор.
        /// </summary>
        public Contact()
        {
            this.Email = "";
            this.PhoneNumber = "";
            this.FullName = "";
            this.DateOfBirth = DateTime.Now;
            this.VkId = "";
        }

        /// <summary>
        /// Конструктор, принимащий и задающий все поля класса.
        /// </summary>
        public Contact(string fullName, string email, string phoneNumber, string dateOfBirth, string vkId)
        {
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.FullName = FullName;
            this.DateOfBirth = DateOfBirth;
            this.VkId = VkId;
        }

        /// <summary>
        /// Возвращает или задает полное имя.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set 
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException(String.Format("Error. Size more 100."));
                }
                this._fullName = this.ToCapitalLettersStyle(value);
            }
        }

        /// <summary>
        /// Возвращает или задает Е-маил.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException(String.Format("Error. Size more 100."));
                }
                _email = value;
            }
        }

        /// <summary>
        /// Возвращает или задает номер телефона.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
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
            get { return _dateOfBirth; }
            set
            {
                DateTime minDate = new DateTime(1900);
                if ((value > DateTime.Now)||(value < minDate))
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
            get { return _vkId; }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException(String.Format("Error. Size more 100."));
                }
                this._vkId = value;
            }
        }

        /// <summary>
        /// Клониование данного объекта.
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

    }

    class MainClass
    {
       public static void Main(string[] argc)
        {
            Contact c = new Contact();
            c.FullName = "qwe ewqewq gh";
            c.PhoneNumber = "wrew9234-g wtw2324dfg  +";
            Console.WriteLine(c.PhoneNumber);
            
        }
    }
}

