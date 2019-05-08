using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

class Student : Person{
    private int[] testScores;  
    public Student(string firstName, string lastName, int id, int[] scores){
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        this.testScores = scores;
        
    }
    public char Calculate()
    {
        int sumScores = 0;
        
        for (int testScore = 0; testScore < testScores.Length; testScore++)
        {
            sumScores = sumScores + testScores[testScore];                       
        }

        int averageScore = sumScores / testScores.Length;
        if (averageScore >= 90)
        {
            return 'O';
        }
        else if (averageScore >= 80 && averageScore < 90)
        {
            return 'E';
        }
        else if (averageScore >= 70 && averageScore < 80)
        {
            return 'A';
        }
        else if (averageScore >= 55 && averageScore < 70)
        {
            return 'P';
        }
        else if (averageScore >= 40 && averageScore < 55)
        {
            return 'D';
        }
        else
        {
            return 'T';
        } 
    }
}

class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}