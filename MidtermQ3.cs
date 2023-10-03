/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: MidtermQ3
*/

using System;

class MidtermQ3
{

    public static void Main(string[] args)
    {
        int choice;
        string art = "";
        char letter;
        do
        {
            Console.WriteLine("1) Add a letter");
            Console.WriteLine("2) Add a row of letters");
            Console.WriteLine("3) Add a new line");
            Console.WriteLine("4) Quit");
            choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Letter:");
                     letter = char.Parse(Console.ReadLine());
                    art += letter;
                    Console.WriteLine("Added!\n");
                    break;
                case 2:
                    Console.Write("Letter:");
                     letter = char.Parse(Console.ReadLine());
                    Console.Write("number");
                    int number= int.Parse(Console.ReadLine());
                    for(int i = 0; i < number; i++)
                    {
                        art += letter;
                    }
                    Console.WriteLine("Added!\n");
                    break;
                case 3:
                    art += "\n";
                    Console.WriteLine("Added!\n");
                    break;
                    case 4:
                    break;
                default:
                    Console.WriteLine("Not an option. Select again.");
                    break;
            }
        } while (choice != 4);
        Console.WriteLine("[Your Artwork]\n"+art+ "\n[Goodbye!]");
    }
}
