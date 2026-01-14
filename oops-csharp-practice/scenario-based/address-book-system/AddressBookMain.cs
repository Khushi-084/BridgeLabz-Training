using System;
// Main class for Address Book System
    class AddressBookMain{

        public static void Main(string[] args){
            // Creating an instance of AddressBook and displaying welcome message
            IAddressBook addressBook = new AddressBook();
            addressBook.DisplayWelcomeMessage();
        }
    }

