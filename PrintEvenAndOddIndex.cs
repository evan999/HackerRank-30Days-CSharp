using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
       int T = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {  
            string s = Console.ReadLine();
            char[] chars = s.ToCharArray();

            for (int j = 0; j < chars.Length; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write(chars[j]);
                }
            }

            Console.WriteLine();
        }
		}
}