// -------------------------------------------------------------------------
//  Copyright (c) Lani Quantum Solutions, Inc..  All rights reserved.
// -------------------------------------------------------------------------

namespace Lani.HelloWorld;

/// <summary>
/// Simple Hello World console application demonstrating basic Lani project structure.
/// This serves as a minimal example for public repository sharing.
/// </summary>
public class Program
{
    /// <summary>
    /// Main entry point for the Hello World application.
    /// </summary>
    /// <param name="args">Command line arguments</param>
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Welcome to Lani Quantum Solutions!");
        
        if (args.Length > 0)
        {
            Console.WriteLine($"Arguments received: {string.Join(", ", args)}");
        }
        
        Console.WriteLine("Press any key to exit...");
        
        try
        {
            Console.ReadKey();
        }
        catch (InvalidOperationException)
        {
            // Handle case where console input is redirected or not available
            Console.WriteLine("Console input not available, exiting...");
        }
    }
}
