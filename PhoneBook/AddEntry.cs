using System;
using System.Collections.Generic;
using System.IO;

namespace PhoneBook
{
    public class AddEntry
    {
        public static List<string> GetEntryFromUser()
        {
            List<string> list = new List<string> { };

            string name;
            string surname;
            string phonenumber;
            string email;
            string company;
            string allInformation;

            Console.WriteLine("Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Surname: ");
            surname = Console.ReadLine();

            Console.WriteLine("Phone number: ");
            phonenumber = Console.ReadLine();

            Console.WriteLine("E-mail: ");
            email = Console.ReadLine();

            Console.WriteLine("Company: ");
            company = Console.ReadLine();

            allInformation = name + "," + surname + "," + phonenumber + "," + email + "," + company;
            list.Add(allInformation);

            return list;
        }
        public static void AddEntryToPhoneBook(List<string> entry)
        {
            List<string> list = entry;

            if (File.Exists(Properties.Path))
            {
                var file = File.ReadAllLines(Properties.Path);

                foreach (var line in file)
                {
                    list.Add(line);
                }
                File.Delete(Properties.Path);
                File.AppendAllLines(Properties.Path, list);
            }
            else
            {
                FileStream stream = null;
                try
                {
                    stream = new FileStream(Properties.Path, FileMode.OpenOrCreate);
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        for (int i = 0; list.Count > i; i++)
                        {
                            writer.WriteLine(list[i]);
                        }
                    }
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Dispose();
                    }
                }
            }
        }
    }
}
