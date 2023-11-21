using _01AdressBookprojekt.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01AdressBookprojekt.Menu
{
    public class RemoveOneContactMenu
    {
        private static readonly ContactService _contactService = new ContactService();

        public static void Show()
        {
            Console.WriteLine("Ange E-postadressen som du vill ta bort: ");
            var email = Console.ReadLine();
            var contacts = _contactService.GetAllContacts();
            var contact = contacts.FirstOrDefault(c => c.Email == email);
            if (contact != null)
            {
                _contactService.RemoveContact(email!);
                Console.WriteLine("Kontakten har tagits bort: ");
            }
            else
            {
                Console.WriteLine("Kontakten hittades inte: ");
            }

        }
    }
}
