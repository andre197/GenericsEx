using System;

public class Program
{
    public static void Main(string[] args)
    {
        Tuple<string, string> stringString = new Tuple<string, string>();
        Tuple<string, int> stringInt = new Tuple<string, int>();
        Tuple<int, double> intDouble = new Tuple<int, double>();

        var input = Console.ReadLine().Split();
        stringString.Create($"{input[0]} {input[1]}", input[2]);

        input = Console.ReadLine().Split();
        stringInt.Create(input[0],int.Parse(input[1]));

        input = Console.ReadLine().Split();
        intDouble.Create(int.Parse(input[0]),double.Parse(input[1]));

        Console.WriteLine(stringString);
        Console.WriteLine(stringInt);
        Console.WriteLine(intDouble);
    }
}

