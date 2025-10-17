using System;
/*
 Question 1) Write a C# program that accepts an integer from the user and determines
whether the number is positive, negative, or zero using the ternary operator (?:). 

Output:-
Enter a number: -8
The number is Negative

Enter a number: 0
The number is Zero

Enter a number: 42
The number is Positive
 */
public class Que1
{
	static void Main(string[] args)
	{
		Console.Write("Enter a number: ");
		int number = Convert.ToInt32(Console.ReadLine());

		string result = (number > 0) ? "Positive" : (number < 0) ? "Negative" : "Zero";
    }
}
