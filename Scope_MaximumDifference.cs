using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

	// Add your code here
    public Difference(int[] nums){
        elements = nums;
    }

    public int computeDifference(int[] elements){
        for (int element = 0; element < elements.Length(); element++)
        {
            int absoluteElement = Math.Abs(elements[element]);
            if (maximumDifference < absoluteDifference)
            {
                maximumDifference = absoluteDifference;
            }
        }      
        return maximumDifference;
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