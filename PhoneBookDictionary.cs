using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {

        int n = int.Parse(Console.ReadLine());
        Dictionary<string, int> phoneBook = new Dictionary<string, int>();

        for (int input = 0; input < n; input++)
        {
            string[] entry = Console.ReadLine().Split(' '); 
            string name = entry[0];
            int phoneNumber = int.Parse(entry[1]);

            phoneBook.Add(name, phoneNumber);   
        }
        
        for (int entry = 0; entry < n; entry++)
        {
            string name = Console.ReadLine();

            if(phoneBook.ContainsKey(name))
            {
                int phoneNumber = phoneBook[name];
                Console.WriteLine(name + "=" + phoneNumber);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}

