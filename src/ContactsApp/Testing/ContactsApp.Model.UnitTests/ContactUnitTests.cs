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
    public class ContactUnitTests
    {
        [Test(Description = "Позитивный тест конструктора без параметров")]
        public void Constructor_SetStandardParameters_ReturnsStandardValues()
        {
            //Setup
            var expectedFullName = "";
            var expectedEmail = "";
            var expectedPhoneNumber = "";
            var expectedDateOfBirth = new DateTime(2000, 1, 1);
            var expectedVkId = "";

            //Act
            Contact contact = new Contact();

            var actualFullName = contact.FullName;
            var actualEmail = contact.Email;
            var actualPhoneNumber = contact.PhoneNumber;
            var actualDateOfBirth = contact.DateOfBirth;
            var actualIdVk = contact.VkId;

            //Assert
            Assert.Multiple(
                () =>
                {
                    Assert.AreEqual(expectedFullName, actualFullName);
                    Assert.AreEqual(expectedEmail, actualEmail);
                    Assert.AreEqual(expectedPhoneNumber, actualPhoneNumber);
                    Assert.AreEqual(expectedDateOfBirth, actualDateOfBirth);
                    Assert.AreEqual(expectedVkId, actualIdVk);
                }
                );
        }

        [Test(Description = "Позитивный тест конструктора с параметрами")]
        public void Constructor_SetCorrectParameters_ReturnsCorrectValues()
        {
            //Setup

            var correctFullName = "Ivan Ivanovich";
            var expectedFullName = correctFullName;

            var correctEmail = "ivan@email.com";
            var expectedEmail = correctEmail;

            var correctPhoneNumber = "8 900 100 00 11";
            var expectedPhoneNumber = correctPhoneNumber;

            var correctDateOfBirth = new DateTime(2000, 1, 1);
            var expectedDateOfBirth = correctDateOfBirth;

            var correctVkId = "1234567890";
            var expectedVkId = correctVkId;

            //Act
            Contact contact = new Contact(correctFullName, correctEmail, correctPhoneNumber, correctDateOfBirth, correctVkId);

            var actualFullName = contact.FullName;
            var actualEmail = contact.Email;
            var actualPhoneNumber = contact.PhoneNumber;
            var actualDateOfBirth = contact.DateOfBirth;
            var actualIdVk = contact.VkId;

            //Assert
            Assert.Multiple(
                () =>
                {
                    Assert.AreEqual(expectedFullName, actualFullName);
                    Assert.AreEqual(expectedEmail, actualEmail);
                    Assert.AreEqual(expectedPhoneNumber, actualPhoneNumber);
                    Assert.AreEqual(expectedDateOfBirth, actualDateOfBirth);
                    Assert.AreEqual(expectedVkId, actualIdVk);
                }
                );
        }

        [Test(Description = "Негативный тест конструктора с параметрами")]
        public void Constructor_SetInvalidParameter_ArgumentException()
        {
            // Setup
            var wrongFullName = "Laurence Alon Aloys Aloysius Alphece Alun Alured Alwyn Alysandyr" +
                "Ambie Ambrose Ambrosius Amias Amiot Amyas Anders Andre Andrea"+
                "Andreas Andrew Andy Aneirin Anguish Anleifr Anthin Anthony Antonio";
            var message = "Должно возникать исключение, если имя содержит больше 100 символов";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                new Contact(wrongFullName, "ivan@email.com", "8 900 100 00 11", new DateTime(2022, 1, 1), "1234567890");
            },
            message);
        }

        [Test(Description = "Позитивный тест присвоения полного имени")]
        public void FullName_SetCorrectValue_ReturnsCorrectValue()
        {
            // Setup
            Contact contact = new Contact();
            var correctFullName = "Ivan Ivanov";
            var expectedFullName = correctFullName;

            // Act
            contact.FullName = correctFullName;

            var actualFullName = contact.FullName;

            // Assert
            Assert.AreEqual(expectedFullName, actualFullName);
        }

        [Test(Description = "Негативный тест присвоения полного имени")]
        public void FullName_SetInvalidValue_ArgumentException()
        {
            // Setup
            Contact contact = new Contact();
            var wrongFullName = "Laurence Alon Aloys Aloysius Alphece Alun Alured Alwyn Alysandyr" +
                "Ambie Ambrose Ambrosius Amias Amiot Amyas Anders Andre Andrea" +
                "Andreas Andrew Andy Aneirin Anguish Anleifr Anthin Anthony Antonio";
            var message = "Должно возникать исключение, если имя содержит более 100 символов";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.FullName = wrongFullName;
            },
            message);
        }

        [Test(Description = "Позитивный тест присвоения Email")]
        public void Email_SetCorrectValue_ReturnsCorrectValue()
        {
            // Setup
            Contact contact = new Contact();
            var correctEmail = "ivan@email.com";
            var expectedEmail = correctEmail;

            // Act
            contact.Email = correctEmail;
            var actualEmail = contact.Email;

            // Assert
            Assert.AreEqual(expectedEmail, actualEmail);
        }

        [Test(Description = "Негативный тест присвоения Email")]
        public void Email_SetIncorrectValue_ArgumentException()
        {
            // Setup
            Contact contact = new Contact();
            var wrongEmail = "LaurenceAlon AloysAloysiusAlpheceAlunAluredAlwynAlysandyr" +
                "AmbieAmbroseAmbrosiusAmiasAmiotAmyasAndersAndreAndrea" +
                "AndreasAndrewAndyAneirinAnguishAnleifrAnthinAnthonyAntonio@email.com";
            var message = "Должно возникать исключение, если Email содержит более 100 символов";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.FullName = wrongEmail;
            },
            message);
        }

        [Test(Description = "Позитивный тест присвоения номера телефона")]
        public void PhoneNumber_SetCorrectValue_ReturnsCorrectValue()
        {
            // Setup
            Contact contact = new Contact();
            var correctPhoneNumber = "8 900 100 00 11";
            var expectedPhoneNumber = correctPhoneNumber;

            // Act
            contact.PhoneNumber = correctPhoneNumber;
            var actualPhoneNumber = contact.PhoneNumber;

            // Assert
            Assert.AreEqual(expectedPhoneNumber, actualPhoneNumber);
        }

        [Test(Description = "Негативный тест присвоения номера телефона")]
        public void PhoneNumber_SetIncorrectValue_ArgumentException()
        {
            // Setup
            Contact contact = new Contact();
            var wrongPhoneNumber = "qwerty";
            var message = "Должно возникать исключение, если номеру телефона пытаются присвоить "
                + "некорректные данные";

            //Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.PhoneNumber = wrongPhoneNumber;
            },
            message);
        }

        [Test(Description = "Позитивный тест присвоения даты")]
        public void DateOfBirth_SetCorrectValue_ReturnsCorrectValue()
        {
            // Setup
            Contact contact = new Contact();
            var correctDateOfBirth = new DateTime(2001, 7, 3);
            var expectedDateOfBirth = correctDateOfBirth;

            // Act
            contact.DateOfBirth = correctDateOfBirth;
            var actualDateOfBirth = contact.DateOfBirth;

            // Assert
            Assert.AreEqual(expectedDateOfBirth, actualDateOfBirth);
        }

        [Test(Description = "Негативный тест присвоения даты")]
        public void DateOfBirth_SetLittleDate_ArgumetException()
        {
            // Setup
            Contact contact = new Contact();
            var wrongDateOfBirth = new DateTime(1800, 1, 1);
            var message = "Должно возникать исключение, если дата меньше 1900.1.1";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.DateOfBirth = wrongDateOfBirth;
            },
            message);
        }

        [Test(Description = "Негативный тест присвоения даты")]
        public void DateOfBirth_SetBigDate_ArgumetException()
        {
            // Setup
            Contact contact = new Contact();
            var wrongDateOfBirth = DateTime.Now.AddDays(1);
            var message = "Должно возникать исключение, если дата больше сегодняшней";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.DateOfBirth = wrongDateOfBirth;
            },
            message);
        }

        [Test(Description = "Позитивный тест присвоения vk id")]
        public void IdVk_SetCorrectValue_ReturnsCorrectValue()
        {
            // Setup
            Contact contact = new Contact();
            var correctVkId = "1234567890";
            var expectedVkId = correctVkId;

            //Act
            contact.VkId = correctVkId;
            var actualVkId = contact.VkId;

            //Assert
            Assert.AreEqual(expectedVkId, actualVkId);
        }

        [Test(Description = "Негативный тест присвоения vk id")]
        public void IdVk_SetInvalidValue_ArgumentException()
        {
            // Setup
            Contact contact = new Contact();
            var wrongVkId = "00000000000000000000000000000000000000000000"+
                "000000000000000000000000000000000000000000000000000000000";
            var message = "Должно возникать исключение, если vk id содержит " +
                "более 50 символов";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.VkId = wrongVkId;
            },
            message);
        }

        [Test(Description = "Позитивный тест метода клонирования")]
        public void CloneMethod_CloneObject_ReturnsCorrectValues()
        {
            // Setup
            var fullName = "Ivan Ivanovich";
            var email = "ivan@email.com";
            var phoneNumber = "8 900 100 00 11";
            var dateOfBirth = new DateTime(2001, 7, 3);
            var vkId = "1234567890";
            var expectedContact = new Contact(fullName, email, phoneNumber, dateOfBirth, vkId);

            // Act
            var actualContact = (Contact)expectedContact.Clone();

            // Assert
            UnitTestService.AssertComparedContacts(expectedContact, actualContact);
        }
    }
}
