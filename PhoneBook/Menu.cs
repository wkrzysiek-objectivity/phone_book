using System;

namespace PhoneBook
{
    class Menu
    {
        public void MenuPhoneBook()
        {
            bool continue_ = true;

            while (continue_)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Hello! This is your Phone Book.");
                Console.WriteLine("What you want to do?");
                Console.WriteLine("1. Add entry");
                Console.WriteLine("2. Display entries");
                Console.WriteLine("3. Found entry");
                Console.WriteLine("4. Delete entry");
                Console.WriteLine("5. Remove all entries");
                Console.WriteLine("6. Exit");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        AddEntry.AddEntryToPhoneBook(AddEntry.GetEntryFromUser());
                        break;
                    case "2":
                        Console.Clear();
                        FoundEntry.DisplayEntries();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Find entry by:");
                        Console.WriteLine("1. Name");
                        Console.WriteLine("2. Surname");
                        Console.WriteLine("3. Phone Number");

                        var inputFindBy = Console.ReadLine();
                        switch (inputFindBy)
                        {
                            case "1":
                                Console.WriteLine("Enter Name to find:");
                                FoundEntry.DisplayFoundedEntries(FoundEntry.FoundByName(Console.ReadLine()));
                                break;
                            case "2":
                                Console.WriteLine("Enter Surname to find:");
                                FoundEntry.DisplayFoundedEntries(FoundEntry.FoundBySurname(Console.ReadLine()));
                                break;
                            case "3":
                                Console.WriteLine("Enter Phone Number to find:");
                                FoundEntry.DisplayFoundedEntries(FoundEntry.FoundByPhoneNumber(Console.ReadLine()));
                                break;
                            default:
                                break;
                        }
                        break;
                    case "4":
                        Methods.DisplayEntries();
                        Console.WriteLine("Which entry you want to delete? Enter number.");
                        Methods.DeleteEntry(Console.ReadLine());
                        break;
                    case "5":
                        Methods.RemoveFile();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Try one more time.");
                        break;
                }
            }
        }
    }
}
