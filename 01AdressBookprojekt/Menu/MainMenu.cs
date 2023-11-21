

using _01AdressBookprojekt.Services;

namespace _01AdressBookprojekt.Menu;

public class MainMenu
{
    public static void Show()
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

            Console.Clear();

            switch (option)
            {
                case "1":
                    MenuService.AddContactMenu();
                    break;

                case "2":
                    MenuService.DisplayAllContactsMenu();

                    break;

                case "3":
                    MenuService.ShowOneContactMenu();
                    break;

                case "4":
                    MenuService.RemoveOneContactMenu();
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

            }



            Console.ReadKey();

        } while (true);

    }

}
