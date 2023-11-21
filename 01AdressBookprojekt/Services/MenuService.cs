

using _01AdressBookprojekt.Menu;
using _01AdressBookprojekt.Models;

namespace _01AdressBookprojekt.Services
{
    public class MenuService
    {
        private static readonly ContactService _contactService = new ContactService();

        public static void AddContactMenu()
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
            contact.Address.PostalCode= Console.ReadLine();
            Console.WriteLine("Stad/Ort: ");
            contact.Address.City = Console.ReadLine();

            _contactService.AddContact(contact);











        }


         public static void DisplayAllContactsMenu()

         {



            Console.WriteLine("Kontaktlista:");
            foreach (var contact in _contactService.GetAllContacts())
            {

                Console.WriteLine(contact.FullName);
                Console.WriteLine(contact.Address?.FullAddress);
                Console.WriteLine();

            }



        }

        public static void ShowOneContactMenu()
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
       
        
            


        

        public static void RemoveOneContactMenu()
        
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

        public static void MainMenu() 
        
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Välkommen till Adressboken");
                Console.WriteLine("1. Lägg till en kontakt");
                Console.WriteLine("2. Lista alla kontakter");
                Console.WriteLine("3. Visa detaljerad information om en kontakt");
                Console.WriteLine("4. Ta bort en kontakt");
                Console.WriteLine("5. Avsluta");
                Console.Write("Välj något av följande alternativ: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddContactMenu();
                        break;

                    case "2":
                        DisplayAllContactsMenu();
                       
                        break;

                    case "3":
                        ShowOneContactMenu();
                        break;

                    case "4":
                        RemoveOneContactMenu();
                        break;

                    case "5":
                        Environment.Exit(0);
                        break;

                }



                Console.ReadKey();

            }while (true);
        
        
        
        }
        
        
           

    }

    

    

}








    





        
    

    

