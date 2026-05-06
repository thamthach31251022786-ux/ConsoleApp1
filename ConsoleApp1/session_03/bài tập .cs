using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.session_03
{
    internal class bài_tập
    {
        public static void Bai1()
        {
            Console.Write("Nhap so thu nhat: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Nhap phep toan (+, -, *, /, x): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            double num2 = double.Parse(Console.ReadLine());

            if (op == '+')
            {
                Console.WriteLine("Ket qua: " + (num1 + num2));
            }
            else if (op == '-')
            {
                Console.WriteLine("Ket qua: " + (num1 - num2));
            }
            else if (op == '*' || op == 'x')
            {
                Console.WriteLine("Ket qua: " + (num1 * num2));
            }
            else if (op == '/')
            {
                Console.WriteLine("Ket qua: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Phep toan khong hop le.");
            }
        }

        public static void Bai2()
        {
            Console.Write("Gia tri cua x = y^2 + 2y + 1:");

            for (int y = -5; y <= 5; y++)
            {
                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine("Voi y = " + y + " thi x = " + x);
            }

        }
        public static void Bai4()
        {
            Console.Write("Nhap ban kinh hinh cau: ");
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14159;

            double surfaceArea = 4 * pi * r * r;
            double volume = (4.0 / 3.0) * pi * (r * r * r);

            Console.WriteLine("Dien tich be mat: " + surfaceArea);
            Console.WriteLine("The tich hinh cau: " + volume);
        }

        public static void Main(string[] args)
        {
        }
    }
}
