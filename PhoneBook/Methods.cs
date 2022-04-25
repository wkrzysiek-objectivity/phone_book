using System;
using System.Collections.Generic;
using System.IO;

namespace PhoneBook
{
    public class Methods
    {
        public static List<Entry> GetListOfEntries()
        {
            List<Entry> list = new List<Entry>();

            int lp = 0;
            if (File.Exists(Properties.Path))
            {
                var file = File.ReadAllLines(Properties.Path);
                foreach (var line in file)
                {
                    lp++;
                    string[] iteration = line.Split(',');
                    list.Add(new Entry() { Lp = lp, Name = iteration[0], Surname = iteration[1], PhoneNumber = iteration[2], Email = iteration[3], Company = iteration[4] });
                }
            }
            else
            {
                Console.WriteLine("List is empty.");
            }
            return list;
        }
        public static void DeleteEntry(string entrytoDelete)
        {

            List<Entry> entry = GetListOfEntries();
            if (entry.Count > 0)
            {
                entry.RemoveAt(int.Parse(entrytoDelete) - 1);

                List<string> list = new List<string>();
                foreach (var l in entry)
                {
                    list.Add(l.Name + "," + l.Surname + "," + l.PhoneNumber + "," + l.Email + "," + l.Company);
                    Console.WriteLine("");
                }

                File.Delete(Properties.Path);
                File.AppendAllLines(Properties.Path, list);
                Console.WriteLine("Entry was deleted.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No entries to delete.");
            }
        }
        public static void RemoveFile()
        {
            File.Delete(Properties.Path);
        }

        public static void DisplayEntries()
        {
            List<Entry> list = GetListOfEntries();
            DisplayFoundedEntries(list);
        }
        public static void DisplayFoundedEntries(List<Entry> list)
        {
            Header();
            foreach (var element in list)
            {
                Console.Write(element.Lp.ToString().PadRight(3) + " ");
                Console.Write(element.Name.PadRight(15) + " ");
                Console.Write(element.Surname.PadRight(15) + " ");
                Console.Write(element.PhoneNumber.PadRight(15) + " ");
                Console.Write(element.Email.PadRight(15) + " ");
                Console.Write(element.Company.PadRight(15) + " ");
                Console.WriteLine();
            }
        }
        public static void Header()
        {
            Console.Write("Lp.".PadRight(3) + " ");
            Console.Write("Name".PadRight(15) + " ");
            Console.Write("Surname".PadRight(15) + " ");
            Console.Write("Phone number".PadRight(15) + " ");
            Console.Write("E-mail".PadRight(15) + " ");
            Console.Write("Company".PadRight(15) + " ");
            Console.WriteLine();
        }
    }
}
