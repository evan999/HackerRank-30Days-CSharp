using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {
	
	static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> binaryNumbers = new List<int>();
        int remainder;

        while (n > 0)
        {
            remainder = n % 2;
            n = n / 2;
            binaryNumbers.Insert(0, remainder);
        }

        int counter = 0;
        int max = 0;

        for (int index = 0; index < binaryNumbers.Count; index++)
        {
            if(binaryNumbers[index] == 1)
            {
                counter++;
                continue;
            }
            else
            {
                if (counter > max)
                {
                    max = counter;
                }
                counter = 0;
            }
        }
        if (counter > max)
        {
            max = counter;
        }

        Console.WriteLine(max); 
    }
}