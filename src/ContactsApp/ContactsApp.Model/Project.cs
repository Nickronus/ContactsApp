using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ContactsApp.Model
{
    internal class Project
    {
        private List<Contact> _contacts;

        public List<Contact> Contacts
        {
            get { return _contacts; }
            set
            {
                _contacts = SortContacts(value);
            }
        }

        private List<Contact> SortContacts(List<Contact> contacts)
        {
            contacts.Sort((c1, c2) => c1.FullName.CompareTo(c2.FullName));
            return contacts;
        }
    }
}
