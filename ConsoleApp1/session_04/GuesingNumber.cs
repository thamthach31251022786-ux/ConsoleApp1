using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.session_04
{
    internal class GuesingNumber
    {
        static void Main4(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random random = new Random();
            

            string tl = "y";
            do
            {
                int numberToGuess = random.Next(1, 101);
                Console.WriteLine(numberToGuess);
                
                for (int i = 0; i < 7; i++)
                {
                    Console.Write(" Bạn đoán số mấy?<1-100>:");
                    int userGuess = int.Parse(Console.ReadLine());

                    if (userGuess == numberToGuess)
                    {
                        Console.WriteLine($"Chúc mừng bạn đã đón đúng sau {i + 1} lần");
                        break;
                    }
                    else if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("Số bạn đoán nhỏ hơn số máy đoán");

                    }
                    else
                    {
                        Console.WriteLine("Số bạn đoán lớn hơn số máy đoán:");
                    }
                }

                Console.Write("Bạn có muốn chơi tiếp không?(y/n): ");
                tl = Console.ReadLine().ToLower();
                
            }
            while(tl != "n") ;

            Console.WriteLine("Bye, chiều chơi nữa nhé");

        }
    }
}
