using System;

namespace AddressBookADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AddressBook Ado.net ");
            ContactRepo contact = new ContactRepo();
            ContactModel person = new ContactModel();
            person.firstName = "Suchindra";
            person.lastName = "Chitnis";
            person.address = "Borivali";
            person.phoneNumber = "9087654321";
            person.zip = 400001;
            person.city = "Mumbai";
            person.state = "Maharashtra";
            person.emailId = "asdfg.uio@gmail.com";
            person.addressBookName = "book4";
            person.type = "Family";

            contact.AddEmployee(person);
        }
    }
}
