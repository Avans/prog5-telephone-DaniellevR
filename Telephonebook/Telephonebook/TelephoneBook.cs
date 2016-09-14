using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephonebook
{
    class TelephoneBook
    {
        private List<Person> persons = new List<Person>();

        public int Size
        {
            get
            {
                return persons.Count;
            }
        }

        public TelephoneBook()
        {
            this.persons.Add(new Person("Celine", "van Stakkeren"));
            this.persons.Add(new Person("Ad", "Baantjer"));
            this.persons.Add(new Person("Bea", "Knol"));
            this.persons.Add(new Person("A", "A"));
            this.persons.Add(new Person("J", "J"));
            this.persons.Add(new Person("A", "J"));
            this.persons.Add(new Person("B", "I"));
            this.persons.Add(new Person("C", "H"));
            this.persons.Add(new Person("D", "G"));
            this.persons.Add(new Person("E", "F"));
            this.persons.Add(new Person("F", "E"));
            this.persons.Add(new Person("G", "D"));
            this.persons.Add(new Person("H", "C"));
            this.persons.Add(new Person("I", "B"));
            this.persons.Add(new Person("J", "A"));
        }
        
        public List<Person> SortedPersonsLastname()
        {
            return this.persons.OrderBy(p => p.LastName).ToList();
        }
        
        public List<Person> SortedPersonsLastnameWithFirstLetterFirstname(char c)
        {
            return this.persons.Where(p => p.FirstName.First().Equals(c)).OrderBy(p => p.LastName).ToList();
        }
        
        public List<Person> TelephonebookLastnameWithBiggerLength(int length)
        {
            return this.persons.Where(p => p.LastName.Length > length).ToList();
        }
        
        public List<Person> TelephonebookSortedLastnamesByLength()
        {
            return this.persons.OrderBy(p => p.LastName.Length).ToList();
        }
    }
}
