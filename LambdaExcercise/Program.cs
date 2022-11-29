﻿public class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Beispiel 1: Converter");
        decimal[] converted = LambdaTest.Converter(new decimal[] { -10, 0, 10, 20, 30 }, d => d + 273.15M);
        LambdaTest.ForEach(converted, d => Console.WriteLine(d));

        Console.WriteLine("Beispiel 2: Filter");
        decimal[] freezed = LambdaTest.Filter(converted, d => d < 273.15M);
        LambdaTest.ForEach(freezed, d => Console.WriteLine(d));

        Console.WriteLine("Beispiel 3: Division");
        decimal result = LambdaTest.ArithmeticOperation(2, 0, (x, y) => (y == 0)? 0 : x/y);
        Console.WriteLine(result);
        result = LambdaTest.ArithmeticOperation(2, 0, (x, y) => x/y , mes => Console.Error.WriteLine(mes));
        Console.WriteLine(result);

        Console.WriteLine("Beispiel 4: Callback Funktion");
        LambdaTest.RunCommand(
        ()=> {
                Console.WriteLine("Hello World.");
                Console.WriteLine("Hello World again.");
        });

        Console.ReadLine();
    }

    public static decimal CelsiusToKelvin(decimal value)
    {
        return value + 273.15M;
    }

    public static void PrintValue(decimal value)
    {
        Console.WriteLine(value);
    }

    public static decimal Divide(decimal x, decimal y)
    {
        return x / y;
    }

    public static decimal DivideSafe(decimal x, decimal y)
    {
        if (y == 0) { return 0; }
        return x / y;
    }

    public static void PrintError(string message)
    {
        Console.Error.WriteLine(message);
    }

    public static void SayHello()
    {
        Console.WriteLine("Hello World.");
        Console.WriteLine("Hello World again.");
    }

    public static bool WasserGefriert(decimal val)
    {
        return val < 273.15M;
    }
}