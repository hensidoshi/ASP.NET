//using System;
//using System.Collections;

//Console.WriteLine("Enter number : ");
//try
//{
//    int num = Convert.ToInt32(Console.ReadLine());
//    int result = num / 0;
//    Console.WriteLine("Result is : " + result);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Cannot divide by zero");
//}

//using System;
//using System.Collections;
//class program
//{
//    public static void Main(string[] args)
//    {
//        int[] numbers = new int[5];
//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine("Enter numbers : ");
//            numbers[i] = Convert.ToInt32(Console.ReadLine());
//        }
//        try
//        {
//            Console.WriteLine(args[0]);
//        }
//        catch (IndexOutOfRangeException ex)
//        {
//            Console.WriteLine("index is out of range");
//        }
//    }
//}

//using System;
//using System.Collections;
//abstract class sum
//{
//    public abstract int SumofTwo(int a, int b);
//    public abstract int SumofThree(int a, int b, int c);
//}

//class calculate : sum
//{
//    private int a, b, c;
//    public override int SumofTwo(int a, int b)
//    {
//        return a + b;
//    }
//    public override int SumofThree(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    public void getdata()
//    {
//        Console.WriteLine("Enter a : ");
//        a = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter b : ");
//        b = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter c : ");
//        c = Convert.ToInt32(Console.ReadLine());
//    }

//    public void displaydata()
//    {
//        int result1 = SumofTwo(a, b);
//        Console.WriteLine("sum of two numbers: " + result1);

//        int result2 = SumofThree(a, b, c);
//        Console.WriteLine("sum of three numbers: " + result2);
//    }

//    public static void Main(string[] args)
//    {
//        calculate calc = new calculate();
//        calc.getdata();
//        calc.displaydata();
//    }
//}

//using System;
//using System.Collections;
//interface calculate
//{
//    int Addition(int a, int b);
//    int Subtraction(int a, int b);
//}
//class result : calculate
//{
//    public int Addition(int a, int b)
//    {
//        return a + b;
//    }

//    public int Subtraction(int a, int b)
//    {
//        return a - b;
//    }

//    public static void Main(string[] args)
//    {
//        result result = new result();

//        Console.WriteLine("Enter a number:");
//        int a = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter b number:");
//        int b = Convert.ToInt32(Console.ReadLine());

//        int additionresult = result.Addition(a, b);
//        Console.WriteLine("addition of the two numbers: " + additionresult);

//        int subtractionresult = result.Subtraction(a, b);
//        Console.WriteLine("subtraction of the two numbers: " + subtractionresult);
//    }
//}

//using System;
//using System.Collections;
//using System.Xml.Linq;

//string Name = "Darshan";
//string University = "University";

//int length = Name.Length;

//string joinstring = string.Concat(Name, University);
//joinstring = string.Concat(joinstring, "Rajkot");

//Boolean result1 = Name.Equals(University);

//string str = "This is the \"String\" class.";

//Console.WriteLine(length);
//Console.WriteLine(joinstring);
//Console.WriteLine();
//Console.WriteLine(str);

//Console.WriteLine(Name.ToUpper());
//Console.WriteLine(Name.ToLower());

//bool check = Name.Contains("shan");
//Console.WriteLine(check);

//string result = University.Substring(2);
//string res = University.Substring(0, 9);
//Console.WriteLine(result);
//Console.WriteLine(res);

//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter a string:");
//        string input = Console.ReadLine();

//        string result = SwapCase(input);

//        Console.WriteLine("Resulting string:");
//        Console.WriteLine(result);
//    }

//    static string SwapCase(string input)
//    {
//        char[] chars = input.ToCharArray();

//        for (int i = 0; i < chars.Length; i++)
//        {
//            if (char.IsLower(chars[i]))
//            {
//                chars[i] = char.ToUpper(chars[i]);
//            }
//            else if (char.IsUpper(chars[i]))
//            {
//                chars[i] = char.ToLower(chars[i]);
//            }
//        }

//        return new string(chars);
//    }
//}

//using System;
//using System.Collections;
//interface Shape
//{
//    double Circle(double radius);
//    double Triangle(double baseLength, double height);
//    double Square(double side);
//}

//class ShapeImplementation : Shape
//{
//    public double Circle(double radius)
//    {
//        return Math.PI * radius * radius;
//    }

//    public double Triangle(double baseLength, double height)
//    {
//        return 0.5 * baseLength * height;
//    }

//    public double Square(double side)
//    {
//        return side * side;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Shape shape = new ShapeImplementation();

//        Console.WriteLine("Enter the radius of the circle:");
//        double radius = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine($"Area of Circle: {shape.Circle(radius)}");

//        Console.WriteLine("Enter the base and height of the triangle:");
//        double baseLength = Convert.ToDouble(Console.ReadLine());
//        double height = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine($"Area of Triangle: {shape.Triangle(baseLength, height)}");

//        Console.WriteLine("Enter the side length of the square:");
//        double side = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine($"Area of Square: {shape.Square(side)}");
//    }
//}

//using System;
//using System.Collections;
//using static System.Runtime.InteropServices.JavaScript.JSType;
//Console.WriteLine("Enter number : ");
//try
//{
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (num % 2 != 0)
//    {
//        throw new Exception("The number is odd");
//    }

//    Console.WriteLine("The number is even");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Invalid input. Please enter a valid number");
//}

//using System;
//using System.Collections;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter a string:");
//        string input = Console.ReadLine();

//        string longestWord = FindLongestWord(input);
//        Console.WriteLine($"The longest word is: {longestWord}");
//    }

//    static string FindLongestWord(string input)
//    {
//        string[] words = input.Split(' ');

//        string longestWord = "";
//        int maxLength = 0;

//        foreach (string word in words)
//        {
//            if (word.Length > maxLength)
//            {
//                maxLength = word.Length;
//                longestWord = word;
//            }
//        }

//        return longestWord;
//    }
//}

using System;
using System.Collections;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a character:");
        char inputChar = Console.ReadKey().KeyChar;
        Console.WriteLine();

        char changedCaseChar = ChangeCase(inputChar);
        Console.WriteLine($"Changed case: {changedCaseChar}");
    }

    static char ChangeCase(char c)
    {
        if (char.IsUpper(c))
        {
            return char.ToLower(c);
        }
        else if (char.IsLower(c))
        {
            return char.ToUpper(c);
        }
        else
        {
            return c;
        }
    }
}

