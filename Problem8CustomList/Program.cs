using System;


public class Program
{
    public static void Main()
    {
        CustomList<string> list = new CustomList<string>();

        while (true)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (input[0] == "End")
            {
                break;
            }
            switch (input[0])
            {
                case "Add":
                    list.Add(input[1]);
                    continue;
                case "Remove":
                    list.Remove(int.Parse(input[1]));
                    continue;
                case "Contains":
                    Console.WriteLine(list.Contains(input[1]));
                    continue;
                case "Swap":
                    list.Swap(int.Parse(input[1]), int.Parse(input[2]));
                    continue;
                case "Greater":
                    Console.WriteLine(list.CountGreater(input[1]));
                    continue;
                case "Max":
                    Console.WriteLine(list.Max());
                    continue;
                case "Min":
                    Console.WriteLine(list.Min());
                    continue;
                case "Print":
                    Console.WriteLine(list.ToString());
                    continue;
                case "End":
                    break;
            }
        }
    }
}

