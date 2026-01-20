using System;

class Program {
    static void Main(){
        ParcelLinkedList list = new ParcelLinkedList();
        ParcelMenu menu = new ParcelMenu();

        list.AddDefaultStages();
        menu.ShowMenu(list);
    }
}
