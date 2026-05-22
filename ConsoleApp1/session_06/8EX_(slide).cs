using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.session_06
{
    internal class Ex_01
    {
        private static void Main(string[] args)
        {
            int[] arr = [19, 29, 40, 45, 28, 56, 10, 40, 10, 19];
            //double tb = avg(arr);
            //Console.WriteLine($"Trung binh gia tri mang:{tb}");

            //int target = 10;
            //bool kq = kiemtra(arr, target);
            //Console.WriteLine($"Mang co chua {target} ko?{kq}");

            //int target = 40;
            //int result = vitri(arr, target);
            //Console.WriteLine($"Mang co chua {target} o vi tri {result}"); 

            //int kq = timMax(arr);
            //Console.WriteLine($"Gia tri lon nhat trong mang la:{kq}");

            //Console.Write("Mang truoc khi dao nguoc la:");
            //foreach (int i in arr)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine();
            //int[] kq = Dao_nguoc(arr);
            //Console.Write("Mang sau khi dao nguoc la:");
            //foreach (int i in kq)
            //    Console.Write($"{i} ");

            //// In ra câu thông báo trước
            //Console.Write("Cac gia tri trung lap trong mang la: ");

            //// Gọi hàm chạy. Hàm sẽ tự động in các con số nối tiếp vào câu thông báo trên.
            //TimTrungLap(arr);

            //// In thêm một lệnh rỗng để xuống dòng cho đẹp mắt
            //Console.WriteLine();



            //int n = arr.Length; // Ban đầu n bằng đúng chiều dài của mảng (6 phần tử)
            //int target = 40;    // Số muốn xóa

            //Console.Write("Mang ban dau:");

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();

            //// 2. Gọi hàm xóa. 
            //// Lưu ý phải có chữ 'ref' trước chữ 'n' để hàm xoa_phantu có quyền thay đổi giá trị của 'n' ở đây
            //bool thanhCong = xoa_phantu(arr, ref n, target);

            //// 3. Kiểm tra kết quả và in ra
            //if (thanhCong)
            //{
            //    Console.WriteLine($"\nDa xoa thanh cong so {target}.");
            //    Console.Write("Mang sau khi xoa la:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write(arr[i] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine($"\nKhong tim thay so {target} trong mang de xoa.");
            //}

            //Console.ReadLine();


            int n = arr.Length;

            Console.WriteLine("Mang ban dau:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            // Gọi hàm xóa tất cả trùng lặp
            xoa_tatcatrunglap(arr, ref n);

            Console.WriteLine("\nMang sau khi xoa het cac phan tu trung lap la:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }


        static double avg(int[] arr)
        {
            double a = 0, sum = 0;
            foreach (int i in arr)
                sum += i;
            a = sum / arr.Length;
            return a;
        }
        static bool kiemtra(int[] arr, int x)
        {

            foreach (int i in arr)
            {
                if (i == x)
                    return true;
            }
            return false;
        }
        static int vitri(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == x)
                    return i;
            return -1;
        }
        static int timMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }
        static int[] Dao_nguoc(int[] arr)
        {
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                arr2[i] = arr[arr.Length - 1 - i];
            return arr2;
        }
        /// <summary>
        /// to find duplicate values in an array of values.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static void TimTrungLap(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] == arr[j])
                    {
                        Console.Write(arr[i] + " ");
                        break;
                    }

        }
        /// <summary>
        /// to remove a specific element from an array.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        static bool xoa_phantu(int[] arr, ref int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                // Nếu tìm thấy số cần xóa
                if (arr[i] == x)
                {
                    // Cho vòng lặp 'j' chạy từ vị trí tìm thấy đến KẾ CUỐI mảng (n - 1)
                    for (int j = i; j < n - 1; j++)
                    {
                        // Lấy phần tử đứng sau (j + 1) ĐÈ lên phần tử đứng trước (j)
                        arr[j] = arr[j + 1];
                    }

                    n--; // Giảm số lượng phần tử hợp lệ đi 1
                    return true; // Báo cáo xóa thành công và thoát hàm
                }
            }
            // Nếu chạy hết mảng mà không thấy 'x', trả về false
            return false;

        }
        /// <summary>
        /// to remove duplicate elements from an array.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static void  xoa_tatcatrunglap(int[] arr, ref int n)
        {
            for (int i = 0; i < n; i++)
            {
                // Vòng lặp 'j' đi so sánh với các con số đứng phía SAU nó
                for (int j = i + 1; j < n; j++)
                {
                    // Nếu phát hiện 2 số giống nhau (bị trùng)
                    if (arr[i] == arr[j])
                    {
                        // Dịch chuyển các phần tử phía sau lên để ĐÈ mất số bị trùng
                        for (int k = j; k < n - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }

                        n--; // Giảm số lượng phần tử của mảng đi 1

                        // Cực kỳ quan trọng: Lùi j lại 1 bước để không bị bỏ sót phần tử vừa trượt lên
                        j--;
                    }
                }
            }
        }
    }
}
