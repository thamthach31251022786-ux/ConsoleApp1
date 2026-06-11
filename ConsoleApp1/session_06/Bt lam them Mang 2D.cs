using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.session_06
{
    internal class _
    {
        using System;

class Program
    {
        // Bài 22: Tính tổng từng dòng và từng cột (Lưu vào 2 mảng dòng và cột)
        static void TinhTongDongCot(int[,] a, int m, int n, int[] dong, int[] cot)
        {
            for (int i = 0; i < m; i++) dong[i] = 0;
            for (int j = 0; j < n; j++) cot[j] = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dong[i] += a[i, j];
                    cot[j] += a[i, j];
                }
            }
        }

        // Bài 23: Tìm phần tử lớn nhất và tọa độ của nó
        static int TimMaxMaTran(int[,] a, int m, int n, out int r, out int c)
        {
            int maxVal = a[0, 0];
            r = 0;
            c = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > maxVal)
                    {
                        maxVal = a[i, j];
                        r = i;
                        c = j;
                    }
                }
            }
            return maxVal;
        }

        // Bài 24: Trích xuất đường chéo chính của ma trận vuông
        static void LayDuongCheoChinh(int[,] a, int n, int[] cheoChinh)
        {
            for (int i = 0; i < n; i++)
            {
                cheoChinh[i] = a[i, i];
            }
        }

        // Bài 25: Tính tổng đường chéo phụ của ma trận vuông
        static int TongDuongCheoPhu(int[,] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i, n - 1 - i];
            }
            return tong;
        }

        // Bài 26: Tìm kiếm số x trong ma trận (Lưu tọa độ tìm thấy đầu tiên vào r và c)
        static bool TimKiemXMaTran(int[,] a, int m, int n, int x, out int r, out int c)
        {
            r = -1;
            c = -1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == x)
                    {
                        r = i;
                        c = j;
                        return true;
                    }
                }
            }
            return false;
        }

        // Bài 27: Đếm số lượng số âm nằm trên biên ma trận
        static int DemSoAmTrenBien(int[,] a, int m, int n)
        {
            int dem = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == m - 1 || j == 0 || j == n - 1)
                    {
                        if (a[i, j] < 0) dem++;
                    }
                }
            }
            return dem;
        }

        // Bài 28: Cộng hai ma trận cùng kích thước (Kết quả lưu vào ma trận c)
        static void CongHaiMaTran(int[,] a, int[,] b, int m, int n, int[,] c)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
        }

        // Bài 29: Tạo ma trận chuyển vị b từ ma trận gốc a
        static void TaoMaTranChuyenVi(int[,] a, int m, int n, int[,] b)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[j, i] = a[i, j];
                }
            }
        }

        // Bài 30: Kiểm tra ma trận vuông đối xứng
        static bool KiemTraMaTranDoiXuong(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] != a[j, i]) return false;
                }
            }
            return true;
        }

        // Bài 31: Sắp xếp các phần tử trên từng dòng tăng dần (Không dùng thư viện)
        static void SapXepTungDongTangDan(int[,] a, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (a[i, j] > a[i, k])
                        {
                            int temp = a[i, j];
                            a[i, j] = a[i, k];
                            a[i, k] = temp;
                        }
                    }
                }
            }
        }

        // Bài 32: Đổi chỗ hai dòng r1 và r2 của ma trận
        static void DoiChoHaiDong(int[,] a, int n, int r1, int r2)
        {
            for (int j = 0; j < n; j++)
            {
                int temp = a[r1, j];
                a[r1, j] = a[r2, j];
                a[r2, j] = temp;
            }
        }

        // Bài 33: Kiểm tra ma trận tam giác trên
        static bool LaMaTranTamGiacTren(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j && a[i, j] != 0) return false;
                }
            }
            return true;
        }

        // Bài 34: Tìm dòng có tổng lớn nhất
        static void TimDongTongLonNhat(int[,] a, int m, int n, out int idx, out int maxSum)
        {
            maxSum = -2000000000;
            idx = 0;
            for (int i = 0; i < m; i++)
            {
                int tongDongNay = 0;
                for (int j = 0; j < n; j++)
                {
                    tongDongNay += a[i, j];
                }
                if (tongDongNay > maxSum)
                {
                    maxSum = tongDongNay;
                    idx = i;
                }
            }
        }

        // HÀM MAIN CỦA CHƯƠNG TRÌNH MA TRẬN
        public static void Main(string[] args)
        {
            // Giả lập dữ liệu ma trận vuông 3x3 có sẵn
            int m = 3, n = 3;
            int[,] a = new int[50, 50];
            a[0, 0] = 5; a[0, 1] = 2; a[0, 2] = 3;
            a[1, 0] = 0; a[1, 1] = 7; a[1, 2] = -1;
            a[2, 0] = 0; a[2, 1] = 0; a[2, 2] = 4;

            int[,] b = new int[50, 50];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++) b[i, j] = 1;

            int soCanTim = 7;

            // Khai báo nhận kết quả đầu ra
            int[] tDong = new int[50];
            int[] tCot = new int[50];
            TinhTongDongCot(a, m, n, tDong, tCot);

            int hangMax, cotMax;
            int gtriMax = TimMaxMaTran(a, m, n, out hangMax, out cotMax);

            int hangTimThay, cotTimThay;
            bool timThayX = TimKiemXMaTran(a, m, n, soCanTim, out hangTimThay, out cotTimThay);

            int soAmBien = DemSoAmTrenBien(a, m, n);
            bool doiXuongMt = KiemTraMaTranDoiXuong(a, n);
            bool tamGiacTren = LaMaTranTamGiacTren(a, n);

            int dongLonNhat, tongLonNhat;
            TimDongTongLonNhat(a, m, n, out dongLonNhat, out tongLonNhat);

            int[] cChinh = new int[50];
            LayDuongCheoChinh(a, n, cChinh);
            int tCheoPhu = TongDuongCheoPhu(a, n);

            // Biến đổi cấu trúc ma trận
            int[,] mtTong = new int[50, 50];
            CongHaiMaTran(a, b, m, n, mtTong);

            int[,] mtChuyenVi = new int[50, 50];
            TaoMaTranChuyenVi(a, m, n, mtChuyenVi);

            SapXepTungDongTangDan(a, m, n);
            DoiChoHaiDong(a, n, 0, 1);
        }
    }
}
}
