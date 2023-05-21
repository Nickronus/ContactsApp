using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model.UnitTests
{
    using NUnit.Framework;
    using ContactsApp.Model;

    [TestFixture]
    public class ContactsServiceUnitTests
    {
        [Test(Description = "Позитивный тест приведения строки к  стилю Каждое Слово С Заглавной Буквы")]
        public void ToCapitalLettersStyle_ConvertString_ConvertedString()
        {
            // Setup
            var convertedString = "Ivan Ivanovich";
            var expectedString = convertedString;

            // Act
            var convertingString = "ivan ivanovich";
            var actualString = ContactsService.ToCapitalLettersStyle(convertingString);

            // Assert
            Assert.AreEqual(expectedString, actualString);
        }

        [Test(Description = "Негативный тест проверки длины строки")]
        public void CheckLengthOfTheString_LengthCheck_SuccessfulVerification()
        {
            // Setup
            var verifiableString = "1234567890";
            var maxLength = 3;
            var message = "Должно возникать исключение, если длина строки больше максимально допустимой";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                ContactsService.CheckLengthOfTheString(verifiableString, maxLength);
            },
            message);
        }
    }
}
