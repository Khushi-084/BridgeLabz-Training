// Design and implement a basic hash map class with operations for insertion, deletion, and retrieval.

using System;
using System.Collections.Generic;

class ImplementingCustomHashMap{
    // Array of Linked Lists to store key-value pairs
    LinkedList<KeyValuePair<int, int>>[] table = new LinkedList<KeyValuePair<int, int>>[10];

    int Hash(int key) => key % 10;

// Function to insert a key-value pair
    public void Put(int key, int value){
        int index = Hash(key);
        if (table[index] == null)
            table[index] = new LinkedList<KeyValuePair<int, int>>();

        table[index].AddLast(new KeyValuePair<int, int>(key, value));
    }

    // Function to retrieve the value associated with a key
    public int Get(int key){
        int index = Hash(key);   // Hashing the key
        if (table[index] != null)        // If the bucket is not empty
            foreach (var pair in table[index])   // Traversing the bucket
                if (pair.Key == key)        // If the key is found       
                    return pair.Value;          // Return the value
        return -1;
    }

// Main method
    public static void Main(string[] args){
        // Creating a new instance of MyHashMap
        MyHashMap map = new MyHashMap();
        map.Put(1, 100);
        map.Put(11, 200);
        
        // Printing the values
        Console.WriteLine(map.Get(1));
        Console.WriteLine(map.Get(11));
    }
}
