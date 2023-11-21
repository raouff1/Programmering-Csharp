using _01AdressBookprojekt.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01AdressBookprojekt.Menu
{
    public class ShowOneContactMenu
    {
        private static readonly ContactService _contactService = new ContactService();
        public static void Show()
        {
            Console.WriteLine("Ange Namnet på kontakten: ");
            var name = Console.ReadLine();
            var contacts = _contactService.GetAllContacts();
            var contact = contacts.FirstOrDefault(x => x.FirstName == name);

            if (contact != null)
            {
                Console.WriteLine(contact?.FullName);
                Console.WriteLine(contact?.Address?.FullAddress);
            }
            else
            {
                Console.WriteLine("Kontakten hittades inte.");
            }

        }
    }
}
