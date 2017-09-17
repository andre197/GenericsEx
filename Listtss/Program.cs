using System;

public class Program
{
    private static void Main()
    {
        var interpreter = new CommandInterpreter(new Box<string>());
        var input = Console.ReadLine().Split();

        while (input[0] != "END")
        {
            interpreter.Interpred(input);

            input = Console.ReadLine().Split();
        }
    }
}





