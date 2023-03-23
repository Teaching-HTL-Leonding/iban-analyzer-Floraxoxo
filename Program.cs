﻿if (args.Length == 3 || args.Length == 2)
{

    if (args[0] == "build")
    {
        try
        {
            Iban input = new(args[1], args[2]); Console.WriteLine($"{input.BuildIban()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    else if (args[0] == "analyze")
    {
        try
        {
            Iban bankInfo = new(args[1]);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    else {Console.WriteLine("Your argument needs to contain 'analyze' or 'build'");}
}
else if (args.Length > 3) { Console.WriteLine("Argument is to long. Please try again!"); }
else { Console.WriteLine("Argument is to short. Please try again!"); }
