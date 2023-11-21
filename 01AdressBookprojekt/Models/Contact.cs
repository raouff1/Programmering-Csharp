using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01AdressBookprojekt.Models
{
    public class Contact
    {
        public string? FirstName { get; set; }
        public string? Lastname { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public Address? Address { get; set; }

        public string? FullName => $"{FirstName} {Lastname}";
    }
}
