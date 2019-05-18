using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;
    public int difference;

	// Add your code here
    public Difference(int[] elements){
        this.elements = elements;
    }

    public void computeDifference(){
        maximumDifference = 0;

        for (int element = 0; element < elements.Length; element++)
        {
            for (int secondElement = element + 1; secondElement < elements.Length; secondElement++)
            {
                difference = Math.Abs(elements[element] - elements[secondElement]);
                if (difference > maximumDifference)
                {
                    maximumDifference = difference;
                }
            }
        }      
    }

} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}