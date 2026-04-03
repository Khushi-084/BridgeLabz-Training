using System;
class TicketReservationSystem{
    // Circular Linked List Node
    class Node{
        // Data members of the class
        public int Id;
        public string Name;
        public string MovieName;
        public string SeatNumber;
        public string BookingTime;
        public Node Next;
    }
    static Node head = null;    // Head of the list
    // Add ticket at end
    static void AddTicket(int id, string customer, string movie, string seat, string time){
        // Creates a new node
        Node newNode = new Node();
        newNode.Id = id;
        newNode.Name = customer;
        newNode.MovieName = movie;
        newNode.SeatNumber = seat;
        newNode.BookingTime = time;
        if (head == null){    // If the list is empty
            head = newNode;     // Adding at the beginning
            newNode.Next = head;    // Adding at the end
        }
        else{
            Node temp = head;        // Traversing the list
            while (temp.Next != head)      // Adding at the end
                temp = temp.Next;          // Adding at the end

            temp.Next = newNode;
            newNode.Next = head;
        }
        Console.WriteLine("Ticket booked successfully");
    }
    // Remove ticket by ID
    static void RemoveTicket(int id){
        if (head == null){      // If the list is empty
            Console.WriteLine("No tickets to remove");
            return;
        }
        Node curr = head, prev = null;       // Traversing the list 
        do{
            if (curr.Id == id){      // If the ticket is found
                if (curr == head){
                    Node last = head;
                    while (last.Next != head){     // Traversing the list
                        last = last.Next;
                    }
                    if (head.Next == head){     // If the list has only one node
                        head = null;
                    }else{
                        head = head.Next;
                        last.Next = head;
                    }
                }
                else{
                    prev.Next = curr.Next;      // Adding at the end
                }
                Console.WriteLine("Ticket removed");
                return;
            }
            prev = curr;
            curr = curr.Next;
        } while (curr != head);       // Traversing the list 
        Console.WriteLine("Ticket not found.");
    }
    // Display tickets
    static void DisplayTickets(){
        if (head == null){
            Console.WriteLine("No tickets booked.");
            return;
        }
        Node temp = head;
        Console.WriteLine("\nCurrent Booked Tickets:");
        do{
            Console.WriteLine("ID: " + temp.Id +", Customer: " + temp.Name +", Movie: " + temp.MovieName +", Seat: " + temp.SeatNumber +", Time: " + temp.BookingTime);
            temp = temp.Next;         // Adding at the end
        } while (temp != head);
    }
    // Search by customer name or movie name
    static void SearchTicket(string key){
        if (head == null){
            Console.WriteLine("No tickets available.");
            return;
        }
        Node temp = head;   // Traversing the list  
        bool found = false;
        do{
            if (temp.Name == key || temp.MovieName == key){      // If the ticket is found
                Console.WriteLine("ID: " + temp.Id +", Customer: " + temp.Name +", Movie: " + temp.MovieName +", Seat: " + temp.SeatNumber +", Time: " + temp.BookingTime);
                found = true;
            }
            temp = temp.Next;     // Adding at the end
        } while (temp != head);      
        if (!found)
            Console.WriteLine("No matching ticket found.");
    }

    // Count tickets
    static void CountTickets(){
        if (head == null){
            Console.WriteLine("Total Tickets: 0");
            return;
        }
        // Traversing the list
        int count = 0;
        Node temp = head;
        do{
            count++;
            temp = temp.Next;     // Adding at the end
        } while (temp != head);   
        Console.WriteLine("Total Booked Tickets: " + count);
    }
    public static void Main(string[] args){
        int choice;
        do{
            // Main menu
            Console.WriteLine("\n--- Online Ticket Reservation System ---");
            Console.WriteLine("1. Book Ticket");
            Console.WriteLine("2. Cancel Ticket");
            Console.WriteLine("3. Display Tickets");
            Console.WriteLine("4. Search Ticket");
            Console.WriteLine("5. Count Tickets");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice){
                case 1:
                    Console.Write("Ticket ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Customer Name: ");
                    string cname = Console.ReadLine();
                    Console.Write("Movie Name: ");
                    string mname = Console.ReadLine();
                    Console.Write("Seat Number: ");
                    string seat = Console.ReadLine();
                    Console.Write("Booking Time: ");
                    string time = Console.ReadLine();
                    AddTicket(id, cname, mname, seat, time);
                    break;

                case 2:
                    Console.Write("Enter Ticket ID to cancel: ");
                    RemoveTicket(int.Parse(Console.ReadLine()));
                    break;

                case 3:
                    DisplayTickets();
                    break;

                case 4:
                    Console.Write("Enter Customer or Movie Name: ");
                    SearchTicket(Console.ReadLine());
                    break;

                case 5:
                    CountTickets();
                    break;
            }

        } while (choice != 6);
    }
}