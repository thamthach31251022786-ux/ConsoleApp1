using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.session_05
{
    internal class baitap
    {
        public static void Main()
        {
            Console.WriteLine(Tong(5, 10));
            Console.WriteLine(LaSoChan(4));
            Console.WriteLine(TimSoLonNhat(3, 7, 5));
            Console.WriteLine(TinhGiaiThua(5));
            Console.WriteLine(DaoNguocChuoi("hello"));
            Console.WriteLine(LaSoNguyenTo(7));
            InFibonacci(6);
            Console.WriteLine(DemNguyenAm("Hello World"));
            Console.WriteLine(TinhLuyThua(2, 3));
            Console.WriteLine(TinhTrungBinh(new int[] { 4, 5, 6, 7 }));
            Console.WriteLine(KiemTraDoiXung("radar"));
            Console.WriteLine(CelsiusToFahrenheit(25));
            Console.WriteLine(TimMin(new int[] { 10, 5, 8, 2, 9 }));
            Console.WriteLine(TinhTongChuSo(1234));

            SapXepTangDan(new int[] { 3, 1, 4, 2 });
            Console.WriteLine(XoaKyTuTrungLap("programming"));
            Console.WriteLine(TimUCLN(12, 18));
            Console.WriteLine(ChuyenDoiNhiPhan(10));
            Console.WriteLine(LaNamNhuan(2024));
            Console.WriteLine(DemSoTu("Học lập trình C# rất thú vị"));
        }
        //Bài 1: Tính tổng hai số nguyên
        static int Tong(int a, int b)
        {
            return a + b;
        }
        //Bài 2: Kiểm tra số chẵn lẻ
        static bool LaSoChan(int n)
        {
            return n % 2 == 0;
        }
        //Bài 3: Tìm số lớn nhất trong ba số
        static int TimSoLonNhat(int a, int b, int c)
        {
            int max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            return max;
        }
        //Bài 4: Tính giai thừa của một số
        static long TinhGiaiThua(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * TinhGiaiThua(n - 1);
        }
        //Bài 5: Đảo ngược chuỗi ký tự
        static string DaoNguocChuoi(string input)
        {
            string ketQua = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                ketQua += input[i];
            }
            return ketQua;
        }
        //Bài 6: Kiểm tra số nguyên tố
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        //Bài 7: In dãy Fibonacci
        static void InFibonacci(int n)
        {
            int a = 0, b = 1, c;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
        //Bài 8: Đếm số lượng nguyên âm trong chuỗi
        static int DemNguyenAm(string input)
        {
            int count = 0;
            string nguyenAm = "aeiouAEIOU";
            foreach (char c in input)
            {
                if (nguyenAm.Contains(c))
                    count++;
            }
            return count;
        }
        //Bài 9: Tính lũy thừa
        static double TinhLuyThua(double x, int y)
        {
            double ketQua = 1;
            for (int i = 0; i < y; i++)
            {
                ketQua *= x;
            }
            return ketQua;

        }
        //Bài 10: Tính điểm trung bình của mảng
        static double TinhTrungBinh(int[] arr)
        {
            double sum = 0;
            foreach (int n in arr)
            {
                sum += n;
            }
            return sum / arr.Length;
        }
        //Bài 11: Kiểm tra chuỗi đối xứng(Palindrome)
        static bool KiemTraDoiXung(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i]) return false;
            }
            return true;
        }
        //Bài 12: Chuyển đổi nhiệt độ
        static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }
        //Bài 13: Tìm giá trị nhỏ nhất trong mảng
        static int TimMin(int[] arr)
        {
            int min = arr[0];
            foreach (int n in arr)
            {
                if (n < min)
                    min = n;
            }
            return min;
        }
        //Bài 14: Tính tổng các chữ số của một số nguyên
        static int TinhTongChuSo(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        //Bài 15: Sắp xếp mảng tăng dần
        static void SapXepTangDan(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
        //Bài 16: Xóa ký tự trùng lặp
        static string XoaKyTuTrungLap(string input)
        {
            string ketQua = "";
            foreach (char c in input)
            {
                int j = 0;
                for (j = 0; j < ketQua.Length; j++)
                {
                    if (c == ketQua[j])
                        break;
                }
                if (j == ketQua.Length)
                    ketQua += c;
            }
            return ketQua;
        }

        //Bài 17: Tìm ước chung lớn nhất(UCLN)
        static int TimUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        //Bài 18: Chuyển đổi hệ thập phân sang nhị phân
        static string ChuyenDoiNhiPhan(int n)
        {
            if (n == 0) return "0";
            string ketQua = "";
            while (n > 0)
            {
                ketQua = (n % 2) + ketQua;
                n /= 2;
            }
            return ketQua;
        }
        //Bài 19: Kiểm tra năm nhuận
        static bool LaNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
        //Bài 20: Đếm số từ trong câu
        static int DemSoTu(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ' && (i == 0 || s[i - 1] == ' '))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
