using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Serie_IV
{
    public class PhoneBook
    {
        private Dictionary<string, string> _contacts;
        public PhoneBook()
        {
            _contacts = new Dictionary<string, string>();
        }
        

        private static bool IsValidPhoneNumber(string phoneNumber)
        {
            
            if (Regex.IsMatch(phoneNumber, @"^0[1-9]{8}$"))
            {
                Console.WriteLine("Numéro correct");
                return true;
            }
            else Console.WriteLine("Numéro invalide");
            return false;
        }

        public bool ContainsPhoneContact(string phoneNumber)
        {
            return _contacts.ContainsKey(phoneNumber);
        }

        public void PhoneContact(string phoneNumber)
        {
            if (ContainsPhoneContact(phoneNumber))
            {
                Console.WriteLine($"{phoneNumber} : {_contacts[phoneNumber]}");
            }
            else
            {
                throw new ArgumentException("Numéro non présent");
            }
        }

        public bool AddPhoneNumber(string phoneNumber, string name)
        {

            if (IsValidPhoneNumber(phoneNumber) && !ContainsPhoneContact(phoneNumber))
            {
                _contacts.Add(phoneNumber, name);
                Console.WriteLine("Contact ajouté avec succès");

                return true;
            }
            return false;
        }

        public bool DeletePhoneNumber(string phoneNumber)
        {
            if (_contacts.Remove(phoneNumber))
            {
                return true;

            } return false;
        }

        public void DisplayPhoneBook()
        {
            foreach (var contact in _contacts)
            {
                Console.WriteLine($"{contact.Key} : {contact.Value}");
            }
        }
    }
}
