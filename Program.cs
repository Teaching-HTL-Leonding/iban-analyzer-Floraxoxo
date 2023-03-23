if (args.Length == 2) {
    try
    {
        Iban input = new (args[0], args[1]); Console.WriteLine($"{input.BuildIban()}");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
else if (args.Length > 2) {Console.WriteLine("Argument is to long. Please try again!");}
else {Console.WriteLine("Argument is to short. Please try again!");}
