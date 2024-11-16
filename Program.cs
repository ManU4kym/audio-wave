using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = ["jane", "kim", "moses"];
        
        foreach (var name in names)
        {
            Console.WriteLine($"Hello { name.ToUpper()}");
        }


        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        foreach (var number in numbers) {
            Console.WriteLine($"This are the numbers {number}");
        }

        string jna =Console.ReadLine();
        Console.WriteLine(jna);
        Console.WriteLine();

        if (Console.ReadLine() == "Hello")
        {
            Console.WriteLine("Hello again");
        }else
        {
            Console.WriteLine("gggg");
        }
        {
            
        }
        names.Add("Maria");
        names.Add("Bill");
        names.Remove("Ana");
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }
    }
}
