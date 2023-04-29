using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp.Model;

namespace ContactsApp.View
{
    internal class RandomContactFactory
    {
        /// <summary>
        /// Добавление рандомного контакта.
        /// </summary>
        private static void AddRandomContact(Project project)
        {
            Random random = new Random();
            string[] firstNames = { "Иван ", "Катя ", "Владимир ", "Артём ",
                          "Дмитрий ", "Яна ", "Гриша ", "Семён ",
                          "Добрыня ", "Маруся " };
            string[] secondNames = { "Авакян", "Аматуни", "Багратуни", "Брутян",
                            "Галустян", "Григорян", "Дарбинян", "Есаянц",
                            "Иоаннисян", "Луспекян" };

            Contact contact = new Contact();
            int fIndex = random.Next(firstNames.Length);
            int sIndex = random.Next(secondNames.Length);
            contact.FullName = firstNames[fIndex] + secondNames[sIndex];
            project.Contacts.Add(contact);
        }
    }
}
