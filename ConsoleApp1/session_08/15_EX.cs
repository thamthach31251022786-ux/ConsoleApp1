using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1.session_08
{
    internal class _15_EX
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            string file1 = "BaoCao.txt";
            string file2 = "BaoCao_Copy.txt";
            string file3 = "BaoCao_DoiTen.txt";
            // Bài 1: Tạo file trống
            File.Create("Rong.txt").Close();
            Console.WriteLine("1: Đã tạo tệp Rong.txt (file trống)");
            // Bài 2: Xóa file
            if (File.Exists("Rong.txt"))
            {
                File.Delete("Rong.txt");
                Console.WriteLine("2: Đã xóa tệp Rong.txt");
            }
            else
            {
                Console.WriteLine("2: Tệp Rong.txt không tồn tại để xóa");
            }
            // Bài 3: Tạo file và ghi nội dung
            File.WriteAllText(file1,
            "BÁO CÁO DOANH THU 2025\n" +
            "-------------------------\n" +
            "Quý 1: 120 tỷ VND\n" +
            "Quý 2: 150 tỷ VND\n");
            Console.WriteLine("3: Đã tạo và ghi nội dung vào " + file1);
            // Bài 4: Tạo 1 tệp văn bản và đọc tệp đó
            File.WriteAllText("ReadMe.txt", "Xin chào!\nĐây là file ReadMe.");
            Console.WriteLine("4: Nội dung ReadMe.txt:");
            Console.WriteLine(File.ReadAllText("ReadMe.txt"));
            // Bài 5: tạo một tệp và ghi một mảng chuỗi vào tệp
            string[] lines = { "Dòng 1", "Dòng 2", "Dòng 3" };
            File.WriteAllLines("ArrayLines.txt", lines);
            Console.WriteLine("\n5: Đã ghi mảng chuỗi vào ArrayLines.txt");
            // Bài 6: thêm văn bản vào tệp hiện có
            File.AppendAllText(file1, "Quý 3: 200 tỷ VND\n");
            Console.WriteLine("6: Đã thêm văn bản vào " + file1);
            // Bài 7: tạo và sao chép tệp sang tên khác và hiển thị nội dung
            File.Copy(file1, file2, true);
            Console.WriteLine("7: Đã sao chép " + file1 + " sang " + file2);
            Console.WriteLine("Nội dung " + file2 + ":");
            Console.WriteLine(File.ReadAllText(file2));
            // Bài 8: tạo một tệp và di chuyển tệp đó vào cùng thư mục tên khác
            File.WriteAllText("MoveMe.txt", "Tệp sẽ được đổi tên.");
            if (File.Exists(file3)) File.Delete(file3);
            File.Move("MoveMe.txt", file3);
            Console.WriteLine("8: Đã di chuyển MoveMe.txt -> " + file3);
            // Bài 9: đọc dòng đầu tiên của tệp
            Console.WriteLine("9: Dòng đầu tiên của " + file1 + ": " +
            File.ReadLines(file1).First());
            // Bài 10: tạo và đọc dòng cuối cùng của tệp
            File.WriteAllLines("LastLine.txt", new string[] { "dong 1", "dong 2","dong 3" });
            Console.WriteLine("10: Dòng cuối cùng của LastLine.txt: " +
            File.ReadLines("LastLine.txt").Last());
            // Bài 11: tạo và đọc n dòng cuối cùng của tệp
            File.WriteAllLines("LastN.txt", new string[] { "dong 1", "dong 2","dong 3", "dong 4" });
            int n = 2;
            Console.WriteLine("11: " + n + " dòng cuối cùng của LastN.txt:");
            foreach (var line in File.ReadLines("LastN.txt")
            .Reverse()//đảo ngược thứ tự dòng (dòng 4,dòng 3, dòng 2, dòng 1)
            .Take(n) // lấy n dòng đầu tiên từ kết quảđảo ngược(dòng 4, dòng 3)
            .Reverse())//đảo ngược lại để có thứ tự đúng(dòng 3, dòng 4)
            Console.WriteLine(line);
            // Bài 12: đọc một dòng cụ thể từ tệp
            int k = 2;
            Console.WriteLine("\n12: Dòng thứ " + k + " của " + file1 + ": " +
            File.ReadLines(file1).Skip(k - 1).First());
            // Bài 13: đếm số dòng trong tệp
            int count = File.ReadAllLines(file1).Length;
            Console.WriteLine("13: Số dòng trong " + file1 + " = " + count);
            // Bài 14: in cấu trúc của một thư mục cụ thể (gồm các tệp)
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("14: Cấu trúc thư mục " + path + ":");
            foreach (string f in Directory.GetFiles(path))
                Console.WriteLine(" - " + Path.GetFileName(f));
            // Bài 15: đọc một tệp văn bản, sau đó thống kê sự xuất hiện của các ký tự và số
            string text = File.ReadAllText(file1);
            var thongke = text
            .Where(c => char.IsLetterOrDigit(c)) // chỉ lấy chữ và số
            .GroupBy(c => c)//nhóm các ký tự giống nhau lại với nhau
            .ToDictionary(g => g.Key, g => g.Count());//chuyển thành từ điển,
            //KEY là ký tự, VALUE là số lần xuất hiện
            Console.WriteLine("\n15: Thống kê ký tự và số trong " + file1 + ":");
            foreach (var kv in thongke.OrderBy(k => k.Key))//sắp xếp theo ký tự
                Console.WriteLine("'" + kv.Key + "': " + kv.Value);
        }
    }
}
