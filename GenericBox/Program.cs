using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Box<string> box = new Box<string>();

        while (true)
        {
            var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            switch (input[0])
            {
                case "Add":
                    box.Add(input[1]);
                    continue;
                case "Remove":
                    box.Remove(int.Parse(input[1]));
                    continue;
                case "Contains":
                    Console.WriteLine(box.Contains(input[1]));
                    continue;
                case "Swap":
                    box.Swap(int.Parse(input[1]), int.Parse(input[2]));
                    continue;
                case "Greater":
                    Console.WriteLine(box.CountGreater(input[1]));
                    continue;
                case "Max":
                    Console.WriteLine(box.Max());
                    continue;
                case "Min":
                    Console.WriteLine(box.Min());
                    continue;
                case "Print":
                    Console.WriteLine(box.ToString());
                    continue;
                case "End":
                    break;
            }
        }
        

    }
}

