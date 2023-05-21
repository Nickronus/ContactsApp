using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model.UnitTests
{
    using NUnit.Framework;
    using ContactsApp.Model;
    public class UnitTestService
    {
        /// <summary>
        /// Сравнение двух контактов.
        /// </summary>
        /// <param name="contact1"></param>
        /// <param name="contact2"></param>
        public static void AssertComparedContacts(Contact contact1, Contact contact2)
        {
            Assert.Multiple(
                () =>
                {
                    Assert.AreEqual(contact1.FullName, contact2.FullName);
                    Assert.AreEqual(contact1.Email, contact2.Email);
                    Assert.AreEqual(contact1.PhoneNumber, contact2.PhoneNumber);
                    Assert.AreEqual(contact1.DateOfBirth, contact2.DateOfBirth);
                    Assert.AreEqual(contact1.VkId, contact2.VkId);
                }
                );
        }

        /// <summary>
        /// Сравнение двух списков контактов.
        /// </summary>
        /// <param name="expectedList"></param>
        /// <param name="actualList"></param>
        public static void AssertCompareContactsLists(List<Contact> expectedList, List<Contact> actualList)
        {
            for (int i = 0; i < actualList.Count; i++)
            {
                AssertComparedContacts(expectedList[i], actualList[i]);
            }
        }
    }
}
