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
            //string t = "";

            for (int j = 0; j < chars.Length; j++)
            {
                if (j % 2 == 0)
                {
                    //t = t + chars[j];
                    Console.Write(chars[j]);
                }
            }

            Console.Write(" ");

            for (int k = 0; k < chars.Length; k++)
            {
                if (k % 2 != 0)
                {
                    Console.Write(chars[k]);
                }
            }
            Console.WriteLine();
        }        
    }
}
