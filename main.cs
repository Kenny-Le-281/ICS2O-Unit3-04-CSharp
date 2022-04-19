// Created by: Kenny Le
// Created on: Apr 2022
//
// This program converts Fahrenheit to Celsius

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function converts Fahrenheit to Celsius
        double fahrenheit;
        double celsius;

        // input
        Console.WriteLine("This program converts Fahrenheit to Celsius.");
        Console.WriteLine("");
        Console.WriteLine("The formula is: ℃ = (℉ − 32) × 5 / 9");

        Console.WriteLine("");
        Console.Write("Input the Fahrenheit (℉ ): ");
        fahrenheit = Convert.ToDouble(Console.ReadLine());

        // process
        Console.WriteLine("");
        celsius = (fahrenheit - 32) * 5.0 / 9.0;

        // output
        Console.WriteLine(fahrenheit + " ℉ in celsius is equal to: " + celsius.ToString("0.00") + " ℃.");

        Console.WriteLine("\nDone.");
    }
}