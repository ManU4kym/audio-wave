using System;


class Program
{
    static void Main(string[] args)
    {
        //WorkWithStrings();
        void WorkWithStrings ()
        {
            List<string> names = ["jane", "kim", "moses"];
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }


            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            foreach (var number in numbers)
            {
                Console.WriteLine($"This are the numbers {number}");
            }


            Console.WriteLine();

            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }

        List<int> fibonnacci = [1, 2,6];

        var previos = fibonnacci[fibonnacci.Count - 1];

        var previos2 = fibonnacci[fibonnacci.Count - 2];


        fibonnacci.Add(previos + previos2);

        foreach (var number in fibonnacci)
        {
            Console.WriteLine(number);
        }

        //Code to generate 20 numbers in fibonacci

        //List<int> fibonnacciNumbers = [1, 2];

        //for (int i = 2; i < 20; i++)
        //{
        //    var preview = fibonnacciNumbers[i- 1] + fibonnacciNumbers[i-2];
        //    fibonnacciNumbers.Add(preview);
        //}

        //foreach (var item in fibonnacciNumbers)
        //{
        //    Console.WriteLine(item);
        //}


    }
}

