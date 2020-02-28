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
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }


        int? largestHourglass = null;

            for(int row = 0; row < 4; row++)
            {
                //int hourglass = 0;
                //int hourglassTopRow = 0;
                //int hourglassMidRow = 0;
                //int hourglassBottomRow = 0;
                //hourglassTotal = 0;

                for(int column = 0; column < 4; column++)
                {
                    int hourglasstotal = 0
                    hourglasstotal += arr[row][column] + arr[row][column+1] + arr                           [row][column+2];
                    hourglasstotal += arr[row+1][column+1];

                    int hourglassBottomRow = arr[row+2][column] + arr[row+2][column+1] +                        arr[row+2][column+2];

                    int hourglassTotal = hourglassTopRow + hourglassMidRow +
                        hourglassBottomRow;
                    
                    if(hourglassTotal > largestHourglass || (largestHourglass == null))
                    {
                        largestHourglass = hourglassTotal;
                        //Console.WriteLine(largestHourglass);
                    } 
                }    
            }
        Console.WriteLine(largestHourglass);
    }
}