using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1.session_07
{
    internal class _13_btap
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào một chuỗi:");
            string str = Console.ReadLine();
            IN(str);
            DoDai(str);
            Tach_kiTu(str);
            Console.Write("4. Chuoi sau khi dao nguoc: ");
            Dao_nguoc(str);
            Dem_Tu(str);

            Dem1(str);
            DemNA_PA(str);
            Console.Write("Nhap chuoi con: ");
            string chuoiCon = Console.ReadLine();
            KT_ChuoiCon(str, chuoiCon);
            ViTri_ChuoiCon(str, chuoiCon);
            KT_InHoa(str);
            Dem_chuoiCon(str, chuoiCon);
            Chen_chuoiCon(str, chuoiCon);
        }
        /// <summary>
        /// Function to input a string and print it.
        /// </summary>
        /// <param name="str"></param>
        static string IN(string str)
        {
            return str;
        }
        //to find the length of a string without using a library function.
        static int DoDai(string str)
        {
            int dodai = 0;
            for(int i=0; i<str.Length;i++)
            {
                dodai++;
            }
            return dodai;
        }
        //to separate individual characters from a string.
        static string Tach_kiTu(string str)
        {
            Console.Write("3. Cac ki tu trong chuoi:");
            foreach (char c in str) {
                Console.Write($"{c} ");
            }
            Console.WriteLine();
            return str;
           
        }
        //to print individual characters of the string in reverse order.
        static void Dao_nguoc(string str)
        {
            for (int i=str.Length-1; i>=0;i--)
            {
                Console.Write($"{str[i]}");
            }
            Console.WriteLine();
            
        }
        //to count the total number of words in a string.
        static int Dem_Tu(string str)
        {

            string sep = " ";
            string[] words = str.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        //to count the number of alphabets, digits and special characters in a string.
        static void Dem1(string str)
        {
            int chu = 0, so = 0, dacBiet = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    chu++;
                }
                else if (c >= '0' && c <= '9')
                {
                    so++;
                }
                else if (c != ' ')
                {
                    dacBiet++;
                }

            }
            Console.WriteLine($"7. Số chữ cái: {chu} \n Số chữ số: {so} \n Số ký tự đặc biệt: {dacBiet}");
        }
        //to count the number of vowels or consonants in a string.
        static void DemNA_PA(string str)
        {
            int nguyenam = 0, phuam = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    if ("aeiouAEIOU".IndexOf(c) >= 0)
                    {
                        nguyenam++;
                    }
                    else
                    {
                        phuam++;
                    }
                }
            }
            Console.WriteLine($"8. Số nguyên âm: {nguyenam}, Số phụ âm: {phuam}");
        }
        //to check whether a given substring is present in the given string.
        static void KT_ChuoiCon(string str, string chuoiCon)
        {

            bool tonTai = false;
            for (int i = 0; i <= str.Length - chuoiCon.Length; i++)
            {
                if (str.Substring(i, chuoiCon.Length) == chuoiCon)
                {
                    tonTai = true;
                    break;
                }
                //int j;
                //for (j = 0; j < chuoiCon.Length; j++)
                //{
                //    if (str[i + j] != chuoiCon[j])
                //    {
                //        break;
                //    }
                //}
                //if (j == chuoiCon.Length)
                //{
                //    tonTai = true;
                //    break;
                //}
            }

            Console.WriteLine(tonTai ? "9. Tồn tại chuỗi con " : "9. Không tồn tại chuỗi con");

        }
        //to search for the position of a substring within a string.
        static int ViTri_ChuoiCon(string str, string chuoiCon)
        {
            int vitri = -1;
            for (int i = 0; i <= str.Length - chuoiCon.Length; i++)
            {
                if (str.Substring(i, chuoiCon.Length) == chuoiCon)
                {
                    vitri = i;
                    break;
                }
            }
            if (vitri != -1)
            {
                return vitri;

            }
            else
            {
                return -1;
            }
        }
        //to check whether a character is an alphabet and not and if so, check for the case.
        static void KT_InHoa(string str)
        {
            //Console.Write("Nhap vao 1 chuoi de kiem tra:");
            //char kitu = Console.ReadLine()[0];
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("11. Chuoi rong");
                return;
            }
            char kitu = str[0];
            if (kitu >= 'A' && kitu <= 'Z')
            {
                Console.WriteLine($"11.{kitu} la chu In hoa");

            }
            else if (kitu >= 'a' && kitu <= 'z')
            {
                Console.WriteLine($"11. {kitu} la chu in thuong");
            }
            else
            {
                Console.WriteLine("11. Ki tu khong phai chu cai");

            }

        }
        //to find the number of times a substring appears in a given string.
        static void Dem_chuoiCon(string str, string chuoiCon)
        {
            int dem_chuoicon = 0;
            for (int i = 0; i <= str.Length - chuoiCon.Length; i++)
            {
                if (str.Substring(i, chuoiCon.Length) == chuoiCon)
                {
                    dem_chuoicon++;

                }

            }
            Console.WriteLine($"12. Chuoi con xuat hien: {dem_chuoicon} lan");
        }
        //to insert a substring before the first occurrence of a string.
        static void Chen_chuoiCon(string str, string chuoiCon)
        {
            Console.Write("Nhap chuoi con can chen: ");
            string chen = Console.ReadLine();
            int vitri = -1;
            for (int i = 0; i <=str.Length - chuoiCon.Length; i++)
            {
                if (str.Substring(i, chuoiCon.Length) == chuoiCon)
                {
                    vitri = i;
                    break;
                }
            }
            if (vitri!= -1)
            {
                string kq = "";
                for (int i=0; i< vitri; i++)
                {
                    kq += str[i];

                }
                kq += chen + " ";
                for (int i=vitri; i<str.Length; i++)
                {
                    kq += str[i];
                }
                Console.WriteLine("Chuoi sau khi chen: " + kq);
            }
            else
                Console.WriteLine("Khong the chen vi tri chuoi con khong tim thay");
        } 
    }

}
