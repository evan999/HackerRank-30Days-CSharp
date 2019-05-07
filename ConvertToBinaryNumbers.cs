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

        int consecutiveOnes = 0;
        int max = 0;
        int num = 0;
        bool isOne = false;

        foreach (int digit in binaryNumbers)
        {
            num = digit;
            if (num == 1)
            {
                if (isOne && num == 1)
                {
                    consecutiveOnes++;
                }
                else if (!isOne && num == 1)
                {
                    isOne = true;
                    consecutiveOnes++;
                    continue;
                }                
                else
                {
                    if (max < consecutiveOnes)
                    {
                        max = consecutiveOnes;
                    }
                    else
                    {
                        isOne = false;
                        consecutiveOnes = 0;
                        continue;
                    }
                }
            }
            Console.WriteLine("Digit " + digit);            
        }
        Console.WriteLine("Ones: " + consecutiveOnes);        
    }
}