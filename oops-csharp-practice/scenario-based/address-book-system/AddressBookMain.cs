using System;
// Main class for Address Book System
    class AddressBookMain{
        public static void Main(string[] args){
            IAddressBook addressBook = new AddressBook();
            addressBook.DisplayWelcomeMessage();
        }
    }

