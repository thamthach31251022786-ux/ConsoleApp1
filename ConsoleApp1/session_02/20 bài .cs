using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.session_02
{
    internal class EX_01
    {
        public static void Bai_1()
        {
            //            1.Print Hello and Name
            //Write a C# Sharp program to print Hello and your name in a separate line.
            //Expected Output :
            //Hello: Alexandra Abramov

            Console.WriteLine("Hello : Thắm");
        }
        public static void Bai_2()
        {

            //            2.Sum of Two Numbers
            //Write a C# Sharp program to print the sum of two numbers.

            int a = 5;
            int b = 10;
            int sum = a + b;
            Console.WriteLine(sum);
        }
        public static void Bai_3()
        {

            //3.Divide Two Numbers
            //Write a C# Sharp program to print the result of dividing two numbers.

            int c = 20;
            int d = 4;
            int divide = c / d;
            Console.WriteLine(divide);
        }
        public static void Bai_4()
        {

            //        4.Specified Operations Results
            //Write a C# Sharp program to print the results of the specified operations.
            //Test data:
            //• -1 + 4 * 6
            //• (35 + 5) % 7
            //• 14 + -4 * 6 / 11
            //• 2 + 15 / 6 * 1 - 7 % 2
            //Expected Output:
            //23
            //5
            //12
            //3

            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine(35 + 5 % 7);
            Console.WriteLine(14 - 4 * 7 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }
        public static void Bai_5()
        {

            //            5.Swap Two Numbers
            //Write a C# Sharp program to swap two numbers.
            //Test Data:
            //            Input the First Number : 5
            //Input the Second Number : 6
            //Expected Output:
            //After Swapping :
            //First Number : 6
            //Second Number : 5

            Console.Write("Input the First Number : ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number : ");
            int f = int.Parse(Console.ReadLine());

            int temp = e;
            e = f;
            f = temp;
            Console.Write("After swapping:\n");
            Console.WriteLine($"First Number :{e}");
            Console.WriteLine($"Second Number :{f}");
        }
        public static void Bai_6()
        {

            //            6.Multiply Three Numbers
            //Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
            //Test Data:
            //            Input the first number to multiply: 2
            //Input the second number to multiply: 3
            //Input the third number to multiply: 6
            //Expected Output:
            //2 x 3 x 6 = 36

            Console.Write("Input the first number to multiply: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            int third = int.Parse(Console.ReadLine());

            int result = first * second * third;
            Console.WriteLine($"{first} x {second} x {third} = {result}");
        }
        public static void Bai_7()
        {
            //            7.Arithmetic Operations
            //Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing
            //two numbers entered by the user.
            //Test Data:
            //Input the first number: 25
            //Input the second number: 4
            //Expected Output:
            //25 + 4 = 29
            //25 - 4 = 21
            //25 x 4 = 100
            //25 / 4 = 6
            //25 mod 4 = 1

            Console.Write("Input the first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} x {y} = {x * y}");
            Console.WriteLine($"{x} / {y} = {x / y}");
            Console.WriteLine($"{x} mod {y} = {x % y}");
        }
        public static void Bai_8()
        {

            //            8.Multiplication Table
            //Write a C# Sharp program that prints the multiplication table of a number as input.
            //Test Data:
            //Enter the number: 5
            //Expected Output:
            //5 * 0 = 0
            //5 * 1 = 5
            //5 * 2 = 10
            //5 * 3 = 15....5 * 10 = 50

            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Expected Output:\n");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }

        }
        public static void Bai_9() {
            //            9.Average of Four Numbers
            //Write a C# Sharp program that takes four numbers as input to calculate and print the average.
            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the third number: 20
            //Enter the four number: 30
            //3
            //Expected Output:
            //The average of 10 , 15 , 20 , 30 is: 18

            Console.Write("Enter the First number: ");
            int s1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            int s2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int s3 = int.Parse(Console.ReadLine());
            Console.Write("Enter the four number: ");
            int s4 = int.Parse(Console.ReadLine());

            int average = (s1 + s2 + s3 + s4) / 4;
            Console.WriteLine($"The average of {s1}, {s2}, {s3}, {s4} is: {average}");
        }
        public static void Bai_10()
        {

            //            10.Specified Formula with Three Numbers
            //Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
            //Test Data:
            //            Enter first number - 5
            //Enter second number - 6
            //Enter third number - 7
            //Expected Output:
            //Result of specified numbers 5, 6 and 7, (x + y).z is 77 and x.y + y.z is 72

            Console.Write("Enter first number - ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number - ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter third number - ");
            int z = int.Parse(Console.ReadLine());

            int result1 = (x + y) * z;
            int result2 = x * y + y * z;
            Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, (x + y).z is {result1} and x.y + y.z is {result2}");
        }
        public static void Bai_11()
        {
            //            11.Print Age Message
            //Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You
            //look older than 20".
            //Test Data:
            //Enter your age - 25
            //Expected Output:
            //You look older than 25

            Console.Write("Enter your age - ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"You look older than {age}");
        }

        public static void Bai_12()
        {
            //            14.Celsius to Kelvin and Fahrenheit
            //Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
            //Test Data:
            //            Enter the amount of celsius: 30
            //Expected Output:
            //Kelvin = 303
            //Fahrenheit = 86

            Console.Write("Enter the amount of celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double kelvin = celsius + 273.15;
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Kelvin = {Math.Round(kelvin)}");
            Console.WriteLine($"Fahrenheit = {Math.Round(fahrenheit)}");
        }
        public static void Bai_13()
        {
            //            18.Check Positive and Negative Pair
            //Write a C# program to check a pair of integers and return true if one is negative and one is positive.
            //Sample Output:
            //            Input first integer:
            //            -5
            //Input second integer:
            //            25
            //Check if one is negative and one is positive:
            //True

            Console.Write("Input first integer: \n");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Input second integer: \n");
            int second = int.Parse(Console.ReadLine());
            bool result = (first < 0 && second > 0) || (first > 0 && second < 0);
            Console.WriteLine($"Check if one is negative and one is positive:\n{result}");
        }
        public static void Bai_14()
        {

            //            19.Sum or Triple Sum of Integers
            //Write a C# program to compute the sum of two given integers. If two values are the same, return the
            //triple of their sum.

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine($"Triple of their sum: {(a + b) * 3}");
            }
            else
            {
                Console.WriteLine($"Sum of two given integers: {a + b}");
            }
        }
        public static void Bai_15()
        {

            //                20.Absolute Difference or Double It
            //Write a C# program to get the absolute value of the difference between two given numbers. Return
            //double the absolute value of the difference if the first number is greater than the second number.

            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int gia_tri_tuyet_doi = Math.Abs(c - d);

            if (c > d)
            {
                Console.WriteLine(gia_tri_tuyet_doi * 2);
            }
            else
            {
                Console.WriteLine(gia_tri_tuyet_doi);
            }
        }

        public static void Bai_16()
        {

            //21.Check for 20 or Sum Equals 20
            //Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20
            //or if their sum is 20.

            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());

            bool check = (e == 20 || f == 20 || (e + f) == 20);
            Console.WriteLine(check);
        }

        public static void Bai_17()
        {


            //                33.Check Multiple of 3 or 7
            //Write a C# program to check if a given positive number is a multiple of 3 or 7.
            //Sample Output:
            //                Input first integer:
            //                15
            //True

            Console.Write("Enter a positive number: ");
            int number = int.Parse(Console.ReadLine());
            bool isMultiple = (number % 3 == 0) || (number % 7 == 0);
            Console.WriteLine(isMultiple);
        }

        public static void Bai_18()
        {

            //                35.Check Numbers Less than 100 & Greater than 200
            //Write a C# program to check two given numbers where one is less than 100 and the other is greater
            //than 200.
            //Sample Output:
            //Input a first number(< 100): 75
            //Input a second number(> 100): 250
            //True

            Console.WriteLine("Input a first number(< 100): ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a second number(> 200): ");
            int secondNum = int.Parse(Console.ReadLine());
            bool check2 = (firstNum < 100 && secondNum > 200);
            Console.WriteLine(check2);
        }

        public static void Bai_19()
        {

            //                36.Check Integer in Range - 10 to 10
            //Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
            //Sample Output:
            //                Input a first number: -5
            //Input a second number: 8
            //True

            Console.Write("Input a first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input a second number: ");
            int num2 = int.Parse(Console.ReadLine());

            bool check3 = (num1 >= -10 && num1 <= 10) || (num2 >= -10 && num2 <= 10);
            Console.WriteLine(check3);
        }

        public static void Bai_20()
        {
            //                25.Print Odd Numbers 1 to 99
            //Write a C# program to print odd numbers from 1 to 99. Prints one number per line.
            //Sample Output:
            //                Odd numbers from 1 to 99.Prints one number per line.
            //1
            //3
            //5
            //7
            //9...
            //95
            //97
            //99

            Console.WriteLine("Odd numbers from 1 to 99:");
            for (int i = 1; i <= 99; i += 2)
            {
                Console.WriteLine(i);
            }

        }
        public static void Main( string[] args ) {


        }
    }
}
