using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        char[] stringArray = s.ToCharArray();
        
        for(int stringIndex = 0; stringIndex < stringArray.Length; stringIndex++)
        {
            if (stringIndex % 2 == 0)
            {
                Console.Write(stringArray[stringIndex]);
            }
            else if (stringIndex % 2 != 0)
            {
                Console.Write(" " + stringArray[stringIndex]);
            }
        }
        Console.WriteLine();
    }
}