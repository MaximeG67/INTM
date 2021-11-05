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
        

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            
            if (Regex.IsMatch(phoneNumber, @"^0[0-9]{9}$"))
            {
                Console.WriteLine("Numéro correct");
                return true;
            }
            else Console.WriteLine("Numéro invalide");
            return false;
        }

        public bool ContainsPhoneContact(string phoneNumber)
        {
            //TODO
            return false;
        }

        public void PhoneContact(string phoneNumber)
        {
            //TODO
        }

        public bool AddPhoneNumber(string phoneNumber, string name)
        {
            //TODO
            return false;
        }

        public bool DeletePhoneNumber(string phoneNumber)
        {
            //TODO
            return false;
        }

        public void DisplayPhoneBook()
        {
            //TODO
        }
    }
}
