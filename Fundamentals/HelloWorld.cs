namespace Fundamentals;

class Program1
{
 
    static void x(string[] args)
    {
        Console.WriteLine("<<<<Numbers>>>");
        // Numbers
        Console.WriteLine(Math.Abs(-45));
        Console.WriteLine(Math.Pow(46.67,10));
        Console.WriteLine(Math.Round(Math.Sqrt(45), 2));
        Console.WriteLine(Math.Floor(45.76));
        Console.WriteLine(Math.Ceiling(45.76));
        Console.WriteLine(Math.Max(45.76, 43.56));
        Console.WriteLine(Math.Min(45.76, 43.56));

        int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
        string[] friends = new string[5];
        friends[0] = "David";
        friends[1] = "Paul";
        friends[2] = "James";
        friends[3] = "Kevin";
        friends[4] = "Joel";


       
        int num1 = Convert.ToInt32("45");
        int num2 = Convert.ToInt32("34");
        Console.WriteLine(num1 + num2);

        //Strings
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("<<<<Strings>>>");

        string phrase = "Hello Programmers";

        Console.WriteLine(phrase);
        Console.WriteLine(phrase.Length);
        Console.WriteLine(phrase.ToUpper());
        Console.WriteLine(phrase.ToLower());
        Console.WriteLine(phrase.Contains("Hello"));

        // Access Chracter
        Console.WriteLine(phrase[1]);

        //extract string
        Console.WriteLine("Welcome to the world of Programming".Substring(6, 12));

        //Read Input from user
        Console.WriteLine("Enter your First Name: ");
        String ? firstName = Console.ReadLine();

        Console.WriteLine("Hello " + firstName);


        Console.ReadLine();
    }
}

