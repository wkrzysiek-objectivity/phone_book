namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Properties.Path = "C:/Users/wkrzysiek/Documents/Objectivity/AQE/Projects/PhoneBook/PhoneBook/phonebook.txt";

            Menu menu = new Menu();
            menu.MenuPhoneBook();
        }
    }
}
