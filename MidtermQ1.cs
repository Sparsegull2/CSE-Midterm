/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: MidtermQ1
*/

using System;

class MidtermQ1
{

    public static void Main(string[] args)
    {
        Console.Write("Current Job:");
        string job= Console.ReadLine();
        Console.Write("Hourly rate:");
        float rate = float.Parse(Console.ReadLine());
        Console.Write("Hours worked per week:");
        float hours=float.Parse(Console.ReadLine());
        Console.Write("Federal taxes withheld (%):");
        float Ftaxes = float.Parse(Console.ReadLine());
        Console.Write("State taxes withheld (%):");
        float Staxes = float.Parse(Console.ReadLine());

        float salary = rate * hours*50;
        float FW =salary * Ftaxes/100;
        float SW = salary* Staxes/100;
        float net = salary - FW - SW; 
        
        Console.WriteLine("Claculating ...");
        Console.WriteLine("Your offical yearly salary is"+ salary);
        Console.WriteLine("Your yearly take-home pay is "+net);
        Console.WriteLine("($"+FW+" withheld for federal taxes, $"+SW+" withheld for state taxes)");
    }
}
