using _01AdressBookprojekt.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01AdressBookprojekt.Menu
{
    
    public class DisplayAllContactsMenu
    {
        private static readonly ContactService _contactService = new ContactService();
        public static void Show()
        {

            Console.WriteLine("Kontaktlista:");
            foreach (var contact in _contactService.GetAllContacts())
            {

                Console.WriteLine(contact.FullName);
                Console.WriteLine(contact.Address?.FullAddress);
                Console.WriteLine();

            }

        }

    }
}
