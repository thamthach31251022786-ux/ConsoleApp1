using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.session_04
{
    internal class Làm_lại_ví_dụ_trên_slide
    {
        static void Ex_01()
        {
            // Write a C# Sharp program to check whether a given number is even or old


            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập vào một số nguyên: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"{number} là số lẻ.");
            }
        }
        static void Ex_02()
        {
            //        Write a C# Sharp program to find the largest of three numbers.

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập vào số thứ nhất: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ hai: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số thứ ba: ");
            int num3 = int.Parse(Console.ReadLine());

            int largest = num1;
            if (num2 > largest && num2 > num3)
            {
                largest = num2;
            }
            if (num3 > largest && num3 > num2)
            {
                largest = num3;
            }

            Console.WriteLine($"Số lớn nhất trong ba số {num1}, {num2} và {num3} là: {largest}");
        }

        static void E_03()
        {
            //Write a C# Sharp program to accept a coordinate point in an XY
            //coordinate system and determine in which quadrant the coordinate
            //point lies.

            Console.Write("Nhập giá trị cho tọa độ X : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập giá trị cho tọa độ Y : ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Điểm nằm ở góc phần tư thứ nhất.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Điểm nằm ở góc phần tư thứ hai.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Điểm nằm ở góc phần tư thứ ba.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Điểm nằm ở góc phần tư thứ tư.");
            }
            else
            {
                Console.WriteLine("Điểm nằm trên một trong các trục tọa độ.");
            }
        }
        static void Ex_04()
        {
            //Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
            Console.Write("Nhập vào độ dài cạnh thứ nhất: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào độ dài cạnh thứ hai: ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào độ dài cạnh thứ ba: ");
            double side3 = double.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Tam giác là tam giác đều.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("Tam giác là tam giác cân.");
            }
            else
            {
                Console.WriteLine("Tam giác là tam giác scalene.");
            }
        }
        static void Ex_05()
        {
                //    Write a program to read 10 numbers and find their average and sum.

                Console.Write("Nhập 1 số bất kỳ: ");
                double number = double.Parse(Console.ReadLine());
                double sum = number;
                for (int i = 1; i < 10; i++)
                {
                    Console.Write($"Nhập số tiếp theo: ");
                    number = double.Parse(Console.ReadLine());
                    sum += number;
                }
                double average = sum / 10;
                Console.WriteLine($"Tổng của 10 số là: {sum}");
                Console.WriteLine($"Trung bình của 10 số là: {average}");
            }
        static void Ex_06()
        {
                //Write a program to display the multiplication table of a given integer.

                Console.WriteLine("Nhập một số để hiển thị bảng cửu chương:");
                int num = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num} x {i} = {num * i}");
                }
        }
        static void Ex_07()
        {
                //Write a program to display a pattern like triangles with a number.
                Console.Write("Nhập số hàng cho tam giác: ");
                int rows = int.Parse(Console.ReadLine());

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
        }
        static void Ex_08()
        {
                // Write a program to display the n terms of harmonic series and their
                //sum. 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5... 1 / n terms
                Console.Write("Nhập số hạng của chuỗi điều hòa:");
                int n = int.Parse(Console.ReadLine());
                double sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += 1.0 / i;
                }
                Console.WriteLine($"Tổng của {n} số hạng là: {sum}");

        }
        static void Ex_09()
        {
                // Write a program to find the ‘perfect’ numbers within a given number
                // range.
                Console.Write("Nhập khoảng số để tìm các số hoàn hảo: ");
                int range = int.Parse(Console.ReadLine());
                Console.WriteLine($"Các số hoàn hảo trong khoảng {range} là:");
                for (int i = 1; i <= range; i++)
                {
                    int sum = 0;
                    for (int j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            sum += j;
                        }
                    }
                    if (sum == i)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
        }
        static void Ex_10()
        {
            // Write a program to determine whether a given number is prime or not.
            Console.Write("Nhập một số để kiểm tra xem nó có phải là số nguyên tố không: ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{num} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{num} không phải là số nguyên tố.");
            }
        }

        public static void Main(string[] args)
        {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Ex_01();
                Ex_02();
                E_03();
                Ex_04();
                Ex_05();
                Ex_06();
                Ex_07();
                Ex_08();
                Ex_09();
                Ex_10();


        }
    }
}