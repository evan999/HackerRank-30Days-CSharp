using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {

            int n;

            n = int.Parse(Console.ReadLine());

            
            Dictionary<string, int> PhoneBook =
                new Dictionary<string, int>();
            

            for (int input = 0; input < n; input++)
            {
                var entry = Console.ReadLine().Split(' ');
                var name = entry[0];
                var phoneNumber = int.Parse(entry[1]);

                PhoneBook.Add(name, phoneNumber);
                Console.WriteLine(name + "=" + phoneNumber);

                /*
                if (PhoneBook.ContainsKey(name))
                {
                    PhoneBook.Add(name, phoneNumber);
                    Console.WriteLine(name + "=" + phoneNumber);
                }  
                else
                {
                    Console.WriteLine("Not found");
                }
                */
            }
        }
    }


