using System;
using System.Collections.Generic;

namespace FirstHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Do your testing here.

            Console.ReadKey();
        }
    }

    public class PhoneBook
    {
        // TODO: Implement phone book without changing method signature. Replace comments with your code to succeed in this task. Good luck!

        Dictionary<string, int> _phoneBook = new Dictionary<string, int>();
        public PhoneBook(PhoneBookEntry[] initialValues)
        {
            // TODO: Remove and implement initial assignment from array (initialValues) to dictionary (_phoneBook).
            for (int i = 0; i < initialValues.Length; i++ )
            {
                _phoneBook.Add(initialValues[i].Name, initialValues[i].Number);
            }
            return;
        }

        public void Add(PhoneBookEntry entry)
        {
            // TODO: Add passed value (entry) to dictionary
            _phoneBook.Add(entry.Name, entry.Number);
        }

        public bool Remove(string name)
        {
            // TODO: Remove phone book entry from phone book.
            return (_phoneBook.Remove(name));
        }

        public bool Update(PhoneBookEntry entry)
        {
            // TODO: Update phone book entry information. If entry does not exist, return false, otherwise update and return true;
            if (_phoneBook.ContainsKey(entry.Name)) {
                _phoneBook[entry.Name] = entry.Number;
                return true;

            } else
            {
                return false;
            }
        }

        public int Dial(string name)
        {
            // TODO: Return phone number for give person. If non existing return -1;
            if (_phoneBook.ContainsKey(name))
            {
                return _phoneBook[name];

            }
            else
            {
                return -1;
            }
        }

        public string[] Name(int number)
        {
            // TODO: Return name of people names who's phone number it is.
            List<string> nameList = new List<string>();
            foreach (KeyValuePair<string, int> entry in _phoneBook)
            {
                if (entry.Value == number)
                {
                    nameList.Add(entry.Key);
                }
            }

            return nameList.ToArray();
        }

        public Dictionary<string, int> Addresses { get { return _phoneBook; } }
    }
}
