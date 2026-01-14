using System;
// Main class to run Address Book System
    class AddressBookMain{
        static void Main(string[] args){
            IAddressBook addressBook = new AddressBook();
            addressBook.DisplayWelcomeMessage();

            Console.Write("\nEnter number of contacts to add: ");
            int numberOfContacts = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfContacts; i++){
                Console.WriteLine($"\nEnter details for Contact {i + 1}");

                Contact contact = new Contact();

                Console.Write("Enter First Name: ");
                contact.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                contact.LastName = Console.ReadLine();

                Console.Write("Enter Address: ");
                contact.Address = Console.ReadLine();

                Console.Write("Enter City: ");
                contact.City = Console.ReadLine();

                Console.Write("Enter State: ");
                contact.State = Console.ReadLine();

                Console.Write("Enter Zip: ");
                contact.Zip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                contact.PhoneNumber = Console.ReadLine();

                Console.Write("Enter Email: ");
                contact.Email = Console.ReadLine();

                addressBook.AddContact(contact);
            }
            // Display all contacts added
            addressBook.DisplayAllContacts();
            
            // Edit a contact by first name
            Console.Write("\nEnter First Name to Edit Contact: ");
            addressBook.EditContact(Console.ReadLine());
            
            // Display all contacts after editing
            Console.Write("\nEnter First Name to Delete Contact: ");
            addressBook.DeleteContact(Console.ReadLine());

            // Display all contacts after deletion
            addressBook.DisplayAllContacts();
        }
    }
