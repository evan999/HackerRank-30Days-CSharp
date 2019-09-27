using System;

//Write your code here
class Calculator
{
    public int power(int n, int p)
    {
        if (p < 0 || n < 0)
        {
            throw new System.Exception("n and p should be non-negative");
        }
        else
        {
            int result = Convert.ToInt32(Math.Pow(n, p));
            return result;
        }
    }
}

class Solution{
    static void Main(String[] args){
        Calculator myCalculator=new  Calculator();
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]); 
            try{
                int ans=myCalculator.power(n,p);
                Console.WriteLine(ans);
            }
            catch(Exception e){
               Console.WriteLine(e.Message);

            }
        }        
    }
}