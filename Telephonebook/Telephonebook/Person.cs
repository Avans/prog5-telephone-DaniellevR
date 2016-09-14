using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephonebook
{
    class Person
    {
        private string firstname;
        private string lastname;

        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public string FullName
        {
            get
            {
                return firstname + " " + lastname;
            }
        }

        public string TelephoneNumber { get; set; }

        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.TelephoneNumber = "0612345678";
        }
    }
}
