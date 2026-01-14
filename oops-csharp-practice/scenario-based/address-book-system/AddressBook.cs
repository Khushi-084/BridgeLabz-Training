using System;

// Implementation of Address Book System
    class AddressBook : IAddressBook{
        public void DisplayWelcomeMessage(){
            Console.WriteLine("Welcome to Address Book Program");
        }
        // UC-2: Add new contact
        public void AddContact(Contact contact)
        {
            Console.WriteLine("\nContact Added Successfully!");
            Console.WriteLine("Contact Details:");
            Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
            Console.WriteLine($"Address: {contact.Address}");
            Console.WriteLine($"City: {contact.City}");
            Console.WriteLine($"State: {contact.State}");
            Console.WriteLine($"Zip: {contact.Zip}");
            Console.WriteLine($"Phone: {contact.PhoneNumber}");
            Console.WriteLine($"Email: {contact.Email}");
        }
    }

