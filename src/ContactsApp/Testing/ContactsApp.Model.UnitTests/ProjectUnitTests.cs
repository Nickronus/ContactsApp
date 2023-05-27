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
    public class ProjectUnitTests
    {
        [Test(Description = "Позитивнй тест присвоения контактов")]
        public void Contacts_SetCorrectValue_ReturnsCorrectValue()
        {
            // Setup
            Project project = new Project();
            Contact contact = new Contact();
            List<Contact> expectedListContacts = new List<Contact>();
            expectedListContacts.Add(contact);

            // Act
            project.Contacts.Add(contact);
            var actualListContacts = project.Contacts;

            // Assert
            UnitTestService.AssertCompareContactsLists(expectedListContacts, actualListContacts);
        }

        [Test(Description = "Позитивнй тест конструктора без параметров")]
        public void Constructor_SetCorrectParameters_ReturnsCorrectValues()
        {
            // Setup
            Project project = new Project();
            List<Contact> expectedListContacts = new List<Contact>();

            // Act
            var actualListContacts = project.Contacts;

            // Assert
            Assert.AreEqual(expectedListContacts, actualListContacts);
        }

        [Test(Description = "Позитивнй тест конструктора с передаваемым списком контактов")]
        public void Constructor_SetTransmittedParameters_ReturnsCorrectValues()
        {
            // Setup
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact());
            Project project = new Project(contacts);
            var expectedListContacts = contacts;

            // Act
            var actualListContacts = project.Contacts;

            // Assert
            Assert.AreEqual(expectedListContacts, actualListContacts);
        }

        [Test(Description = "Позитивный тест поиска именинников")]
        public void FindBirthdayContacts_FindContacts_ReturnsBirthdayContactsList()
        {
            // Setup
            var birthDate = DateTime.Today;
            var notTodayDate = new DateTime(2000, 1, 1);

            Project project = new Project();
            List<Contact> birthdayContactsList = new List<Contact>();
            Contact birthdayContact = new Contact();
            birthdayContact.DateOfBirth = birthDate;
            birthdayContactsList.Add(birthdayContact);

            List<Contact> contactsList = new List<Contact>();
            Contact contact = new Contact();
            contact.DateOfBirth = notTodayDate;
            contactsList.Add(contact);
            contactsList.Add(birthdayContact);

            var expectedContactsList = birthdayContactsList;

            // Act
            var actualContactsList = project.FindBirthdayContacts(contactsList);

            // Assert
            UnitTestService.AssertCompareContactsLists(expectedContactsList, actualContactsList);
        }

        [Test(Description = "Позитевный тест поиска контактов")]
        public void FindContacts_FindContacts_ReturnsContactsList()
        {
            // Setup
            Project project = new Project();
            List<Contact> сontactsList = new List<Contact>();
            Contact сontact = new Contact();
            сontact.FullName = "Ivan Ivanovich";
            сontactsList.Add(сontact);
            Contact secondContact = new Contact();
            secondContact.FullName = "Semen Semenovich";
            сontactsList.Add(secondContact);

            var expectedContactsList = сontactsList;

            project.Contacts.Add(сontact);
            project.Contacts.Add(secondContact);
            Contact inappropriateContact = new Contact();
            inappropriateContact.FullName = "Vasya Pupkin";
            project.Contacts.Add(inappropriateContact);
            var substring = "vich";

            // Act
            var actualContactsList = project.FindContacts(substring);

            // Assert
            UnitTestService.AssertCompareContactsLists(expectedContactsList, actualContactsList);
        }

        [Test(Description = "Позитивный тест сортировки контактов")]
        public void SortContacts_SortContacts_SortedContactsList()
        {
            // Setup
            Project project = new Project();
            List<Contact> sortedContacts = new List<Contact>();

            Contact firstContact = new Contact();
            firstContact.FullName = "Andrey Andreyevich";
            Contact secondContact = new Contact();
            secondContact.FullName = "Boris Borisovich";
            Contact thirdContact = new Contact();
            thirdContact.FullName = "Vladimir Vladimirovich";
            sortedContacts.Add(firstContact);
            sortedContacts.Add(secondContact);
            sortedContacts.Add(thirdContact);

            project.Contacts.Add(secondContact);
            project.Contacts.Add(thirdContact);
            project.Contacts.Add(firstContact);

            var expectedContactsList = sortedContacts;

            // Act
            var actualContactsList = project.SortContacts();

            // Assert
            UnitTestService.AssertCompareContactsLists(expectedContactsList, actualContactsList);
        }
    }
}
