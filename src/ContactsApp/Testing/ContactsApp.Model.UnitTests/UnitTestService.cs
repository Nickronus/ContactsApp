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
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        public static void AssertCompareContactsLists(List<Contact> expected, List<Contact> actual)
        {
            for (int i = 0; i < actual.Count; i++)
            {
                AssertComparedContacts(expected[i], actual[i]);
            }
        }

        /// <summary>
        /// Сравнение данных о контактах.
        /// </summary>
        /// <param name="expectedFullName"></param>
        /// <param name="actualFullName"></param>
        /// <param name="expectedEmail"></param>
        /// <param name="actualEmail"></param>
        /// <param name="expectedPhoneNumber"></param>
        /// <param name="actualPhoneNumber"></param>
        /// <param name="expectedDateOfBirth"></param>
        /// <param name="actualDateOfBirth"></param>
        /// <param name="expectedVkId"></param>
        /// <param name="actualIdVk"></param>
        public static void AssertComparedContactData(string expectedFullName,
                                                     string actualFullName,
                                                     string expectedEmail,
                                                     string actualEmail,
                                                     string expectedPhoneNumber,
                                                     string actualPhoneNumber,
                                                     DateTime expectedDateOfBirth,
                                                     DateTime actualDateOfBirth,
                                                     string expectedVkId,
                                                     string actualIdVk)
        {
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
    }
}
