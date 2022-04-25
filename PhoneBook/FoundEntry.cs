using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class FoundEntry : Methods
    {
        public static List<Entry> FoundByName(string name)
        {
            List<Entry> list = GetListOfEntries();
            return list.Where(p => p.Name == name).ToList();
        }
        public static List<Entry> FoundBySurname(string surname)
        {
            List<Entry> list = GetListOfEntries();
            return list.Where(test => test.Surname == surname).ToList();
        }
        public static List<Entry> FoundByPhoneNumber(string phoneNumber)
        {
            List<Entry> list = GetListOfEntries();
            return list.Where(test => test.PhoneNumber == phoneNumber).ToList();
        }

    }
}