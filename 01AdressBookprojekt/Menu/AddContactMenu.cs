using _01AdressBookprojekt.Models;
using _01AdressBookprojekt.Services;


namespace _01AdressBookprojekt.Menu
{
    public class AddContactMenu
    {
        private static readonly ContactService _contactService = new ContactService();
        public static void Show()
        {
            Contact contact = new Contact();

            Console.WriteLine("Förnamn: ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Efternamn: ");
            contact.Lastname = Console.ReadLine();
            Console.WriteLine("Telefonnummer: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("E-postadress: ");
            contact.Email = Console.ReadLine();

            contact.Address = new Address();
            Console.WriteLine("Gatuadress: ");
            contact.Address.StreetName = Console.ReadLine();
            Console.WriteLine("Gatunummer: ");
            contact.Address.StreetNumber = Console.ReadLine();
            Console.WriteLine("Postnummer: ");
            contact.Address.PostalCode = Console.ReadLine();
            Console.WriteLine("Stad/Ort: ");
            contact.Address.City = Console.ReadLine();

            _contactService.AddContact(contact);


        }
    }
}
