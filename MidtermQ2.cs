/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: MidtermQ2
*/

using System;

class MidtermQ2
{

    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int num1=rnd.Next(20)+11;
        Random rnd2 = new Random();
        int num2=rnd2.Next(40)+71;
        Console.Write("Guess the number:");
        int guess= int.Parse(Console.ReadLine());

        if (guess< num1) 
        {
            Console.WriteLine("Your guess is too low!");
        }
        if (guess == num1){
            Console.WriteLine("You guessed the first number!");
        }  
        if(guess < num2&&guess>num1) 
        {
            Console.WriteLine("You guessed in-between the two numbers.");
        }
        if(guess == num2)
        {
            Console.WriteLine("You guessed the second number!");
        }
        if (guess > num2)
        {
            Console.WriteLine("Your guess is too high!");
        }

    }
}
