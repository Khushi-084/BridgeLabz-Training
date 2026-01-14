using System;

    class AddressBookMain{
        public static void Main(string[] args){
            // Creating instance of AddressBook class
            IAddressBook addressBook = new AddressBook();
            addressBook.DisplayWelcomeMessage();

            // UC-2: Taking contact details from the user 
            Contact contact = new Contact();

            Console.Write("\nEnter First Name: ");
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

             // UC-3: Edit Contact
            Console.Write("\nEnter First Name to Edit Contact: ");
            string nameToEdit = Console.ReadLine();
            addressBook.EditContact(nameToEdit);

             // UC-4: Delete Contact
            Console.Write("\nEnter First Name to Delete Contact: ");
            string deleteName = Console.ReadLine();
            addressBook.DeleteContact(deleteName);
        }
    }

