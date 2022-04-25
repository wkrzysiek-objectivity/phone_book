using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneBook;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class PhoneBookTests
    {
        [TestMethod]
        public void FoundByNameTest()
        {
            List<string> entry = new List<string> { "Jan,Roman,722122322,Jan.Nowak@gmail.com,Objectivity" };
            string foundedNameTrue = "Jan";
            string foundedNameFalse = "Roman";
            
            AddEntry.AddEntryToPhoneBook(entry);
            List<PhoneBook.Entry> foundedList = FoundEntry.FoundByName(foundedNameTrue);

            Assert.AreEqual(foundedNameTrue, foundedList[0].Name);
            Assert.IsFalse(foundedNameFalse.Equals(foundedList[0].Name));
        }

        [TestMethod]
        public void AddEntryTest()
        {
            List<string> entry = new List<string> { "Roman,Kowalski,722122322,Roman.Kowalski@gmail.com,Objectivity" };
            string foundedNameTrue = "Roman";
           
            AddEntry.AddEntryToPhoneBook(entry);

            Assert.AreEqual(foundedNameTrue, Methods.GetListOfEntries()[0].Name);
        }

        [TestMethod]
        public void deleteEntryTest()
        {
            List<string> entry = new List<string> { "Oskar,Nowak,722122322,Roman.Kowalski@gmail.com,Objectivity", "Miros³aw,Testowy,722122322,Roman.Kowalski@gmail.com,Objectivity" };
            string foundedNameTrue = "Miros³aw";
            string foundedNameFalse = "Oskar";

            AddEntry.AddEntryToPhoneBook(entry);
            Methods.DeleteEntry("1");

            Assert.AreEqual(foundedNameTrue, Methods.GetListOfEntries()[0].Name);
            Assert.IsFalse(foundedNameFalse.Equals(Methods.GetListOfEntries()[0].Name));
        }

        [TestInitialize]
        public void setUpTests()
        {
            Properties.Path = "C:/Users/wkrzysiek/Documents/Objectivity/AQE/Projects/PhoneBook/PhoneBook/phonebook_test.txt";
        }

        [TestCleanup]
        public void cleanupTests()
        {
            Methods.RemoveFile();
        }
    }
}
