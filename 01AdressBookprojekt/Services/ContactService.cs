

using _01AdressBookprojekt.Models;
using Newtonsoft.Json;

namespace _01AdressBookprojekt.Services
{
    
    public class ContactService
    {


      private List<Contact> contacts = new List<Contact>();
        


        public void AddContact(Contact contact)
        
        {
            contacts.Add(contact);
            var json = JsonConvert.SerializeObject(contacts);
            FileService.SaveToFile(JsonConvert.SerializeObject(json));
           

            

        }

        public IEnumerable<Contact> GetAllContacts()

        {
            return contacts;

        }

        public Contact GetOneContact(string email)
        {
            return contacts.FirstOrDefault(x => x.Email == email)!;
        }

        public void RemoveContact(string name) 
        
        {
            var contact = GetOneContact(name);

            contacts.Remove(contact);


        }




    }

    



    

}


