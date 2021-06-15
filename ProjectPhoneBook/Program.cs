using System;

namespace ProjectPhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the PhoneBook app");

            Console.WriteLine("1. Add contact");
            Console.WriteLine("2. Display contact by number");
            Console.WriteLine("3. Display all contacts");
            Console.WriteLine("4. Search contacts");
            Console.WriteLine("5. Delete contact");
            Console.WriteLine("To exit insert 'x'");

            Console.Write("Select operation: ");
            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.Write("Insert number: ");
                        var number = Console.ReadLine();
                        while (number.Length < 9)
                        {
                            Console.Write("The number is too short enter a new one: ");
                            number = Console.ReadLine();
                        }
                        Console.Write("Insert name: ");
                        var name = Console.ReadLine();
                        while (name.Length < 3)
                        {
                            Console.Write("Name is too short enter a new one: ");
                            name = Console.ReadLine();
                        }
                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.Write("Insert number: ");
                        var numberToSearch = Console.ReadLine();
                        phoneBook.DisplayContact(numberToSearch);
                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.Write("Insert search phrase: ");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "5":
                        Console.Write("Enter the username to delete: ");
                        var userName = Console.ReadLine();
                        phoneBook.DeleteContacts(userName);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.Write("Select operation: ");
                userInput = Console.ReadLine();
            }
        }
    }
}
