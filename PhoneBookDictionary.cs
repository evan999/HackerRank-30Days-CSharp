using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string name, phoneNumber;
            int n;

            n = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, string> phoneBook =
                new Dictionary<string, string>();

            for (int entry = 0; entry < n; entry++)
            {
                name = Console.ReadLine();
                phoneNumber = Console.ReadLine();
                phoneBook.Add(name, phoneNumber);

                // Console.WriteLine(name + " " + phoneNumber);
            }

            foreach (KeyValuePair<string, string> phoneEntry in phoneBook)
            {
                Console.WriteLine("{0}={1}", phoneEntry.Key, phoneEntry.Value);
            }
        }
    }

