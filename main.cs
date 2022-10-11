//Created by: Timothy Manwell
//Created on: Oct 2022
//
//This program calculates the area and perimeter of a rectangle

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("The dimensions of a rectangle are: 27cm and 52cm.");
        Console.WriteLine("\nThe area of the rectangle is: " + (27 * 52) + " cm.");
        Console.WriteLine("\nThe perimeter of the rectangle is: " + (2*(27 + 52)) + " cm².");
        
        Console.WriteLine("\nDone.");
    }
}