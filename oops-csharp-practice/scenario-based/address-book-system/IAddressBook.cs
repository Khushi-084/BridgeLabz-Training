using System;
// Interface for Address Book System
    interface IAddressBook{
        
        void DisplayWelcomeMessage();
        void AddContact(Contact contact);      // UC-2 added
        void EditContact(string firstName);    // UC-3 added
    }

