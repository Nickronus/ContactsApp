namespace ContactsApp.Model
{
    using System;
    using System.Globalization;

    public class ContactsService
    {
        /// <summary>
        /// Приведение строки к стилю "Каждое слово с заглавной буквы".
        /// </summary>
        public static string ToCapitalLettersStyle(string value)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(value);
        }

        /// <summary>
        /// Проверка длины строки на соответствие необходимой длине.
        /// </summary>
        public static void CheckLengthOfTheString(string value, int maxLength)
        {
                if (value.Length > maxLength)
                {
                    throw new ArgumentException(String.Format("Error. Size more then max."));
                }
        }
    }
}
