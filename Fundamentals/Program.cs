namespace Fundamentals;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(GetDay(89));
        //LearnWhileLoop();
        int[ , ] grid =
        {
            {3,4}, {5,6},{5,9 }
        };

        TwoDimensionalArray(grid);

        Console.ReadLine();
    }
    static void TwoDimensionalArray(int[,] grid)
    {
        for(int i = 0; i < grid.Length; ++i)
        {
            Console.WriteLine(grid[i, 0]);
        }
    }

    static void LearnWhileLoop()
    {
        int index = 1;
        while(index <= 5)
        {
            Console.WriteLine(index);
            index += 1;
        }
    }

    static string GetDay(int dayNum)
    {
        string dayName;

        switch (dayNum)
        {
            case 0:
                dayName = "Sunday";
                break;
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;

            case 7:
                dayName = "Saturday";
                break;
            default:
                dayName = "Invalid Day Number";
                break;

        }
        return dayName;
    }
}

