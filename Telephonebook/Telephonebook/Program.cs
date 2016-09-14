using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            TelephoneBook telephonebook = new TelephoneBook();

            // Size
            Console.WriteLine("Size : " + telephonebook.Size + "\r\n");

            // Sorted list (lastname)
            int i = 0;
            List<Person> sortedPersonsLastname = telephonebook.SortedPersonsLastname();
            Console.WriteLine("### Sorteren op achternaam ###");
            sortedPersonsLastname.ForEach(p => Console.WriteLine(i++ + ". " + p.FullName + " - " + p.TelephoneNumber));
            Console.WriteLine("");

            // Sorted list (lastname) where firstname begins with given char
            i = 0;
            List<Person> sortedPersonsWithFirstChar = telephonebook.SortedPersonsLastnameWithFirstLetterFirstname('A');
            Console.WriteLine("### Firstname begint met 'A' ###");
            sortedPersonsWithFirstChar.ForEach(p => Console.WriteLine(i++ + ". " + p.FullName + " - " + p.TelephoneNumber));
            Console.WriteLine("");

            // Lastname longer than 5
            i = 0;
            List<Person> personsLastnamesWithBiggerLength = telephonebook.TelephonebookLastnameWithBiggerLength(5);
            Console.WriteLine("### Lastname langer dan 5 ###");
            personsLastnamesWithBiggerLength.ForEach(p => Console.WriteLine(i++ + ". " + p.FullName + " - " + p.TelephoneNumber));
            Console.WriteLine("");

            // Sorted by length lastname
            i = 0;
            List<Person> sortedPersonsLastnamesByLength = telephonebook.TelephonebookSortedLastnamesByLength();
            Console.WriteLine("### Sorteren op achternaam lengte ###");
            sortedPersonsLastnamesByLength.ForEach(p => Console.WriteLine(i++ + ". " + p.FullName + " - " + p.TelephoneNumber));
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
