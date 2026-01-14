using System;
using System.Collections.Generic;

    // Implementation of Address Book System
    class AddressBook : IAddressBook{
        private  Contact[] contacts= new Contact[100];     // Array to store contacts
        private int count=0;                               // Counter for number of contacts
        public void DisplayWelcomeMessage(){
            Console.WriteLine("Welcome to Address Book Program");
        }

        // UC-2: Add new contact
        public void AddContact(Contact contact){
            this.contact = contact;
            Console.WriteLine("\nContact Added Successfully!");
            DisplayContact();
        }

        // UC-3: Edit existing contact by first name
        public void EditContact(string firstName){
            if (contact != null && contact.FirstName.Equals(firstName)) {
                Console.WriteLine("\nEditing Contact Details");

                Console.Write("Enter New Address: ");
                contact.Address = Console.ReadLine();

                Console.Write("Enter New City: ");
                contact.City = Console.ReadLine();

                Console.Write("Enter New State: ");
                contact.State = Console.ReadLine();

                Console.Write("Enter New Zip: ");
                contact.Zip = Console.ReadLine();

                Console.Write("Enter New Phone Number: ");
                contact.PhoneNumber = Console.ReadLine();

                Console.Write("Enter New Email: ");
                contact.Email = Console.ReadLine();

                Console.WriteLine("\nContact Updated Successfully!");
                DisplayContact();
            }
            else{
                Console.WriteLine("\nContact Not Found!");
            }
        }

        // UC-4: Delete contact by first name 
        public void DeleteContact(string firstName){
            if (contact != null && contact.FirstName.Equals(firstName)) {
                contact = null;
                Console.WriteLine("\nContact Deleted Successfully!");
            }
            else{
                Console.WriteLine("\nContact Not Found!");
            }
        }

        private void DisplayAllContacts(){
            if(count==0){
                Console.WriteLine("\nNo Contact Available");
                return;
            }
            Console.WriteLine("\nAll Contacts in Address Book:");
            for(int i=0;i<count;i++){
            Console.WriteLine("\nContact Details:");
            Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
            Console.WriteLine($"Address: {contact.Address}");
            Console.WriteLine($"City: {contact.City}");
            Console.WriteLine($"State: {contact.State}");
            Console.WriteLine($"Zip: {contact.Zip}");
            Console.WriteLine($"Phone: {contact.PhoneNumber}");
            Console.WriteLine($"Email: {contact.Email}");
        }
    }
}
