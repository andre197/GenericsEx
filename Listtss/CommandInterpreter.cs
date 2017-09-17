using System;

public class CommandInterpreter
{
    private Box<string> box;

    public CommandInterpreter(Box<string> box)
    {
        this.box = box;
    }

    public void Interpred(string[] input)
    {
        switch (input[0])
        {
            case "Add":
                box.Add(input[1]);
                break;

            case "Remove":
                box.Remove(int.Parse(input[1]));
                break;

            case "Contains":
                Console.WriteLine(box.Contains(input[1]));
                break;

            case "Swap":
                box.SwapElements(int.Parse(input[1]), int.Parse(input[2]));
                break;

            case "Greater":
                Console.WriteLine(box.CountGreaterEmelements(input[1]));
                break;

            case "Max":
                Console.WriteLine(box.Max());
                break;

            case "Min":
                Console.WriteLine(box.Min());
                break;

            case "Sort":

                break;

            case "Print":
                Console.WriteLine(box.Print());
                break;
        }
    }
}
