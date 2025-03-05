using System;
using biplibrary; // Import the namespace of your library

class Program
{
    static void Main()
    {
        Console.WriteLine("🚀 BipApp is running!");

        // Create an instance of a class from biplibrary
        var helper = new Helper(); 
        Console.WriteLine(helper.GetMessage());
    }
}
