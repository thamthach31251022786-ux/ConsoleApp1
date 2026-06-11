using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.session_06
{
    internal class BT_lam_them
    {
        using System;

class Program
    {
        // Bài 2: Tính tổng các phần tử trong mảng
        static double TinhTong(int[] a, int n)
        {
            double tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            return tong;
        }

        // Bài 2: Tính trung bình cộng
        static double TinhTrungBinhCong(int[] a, int n)
        {
            if (n == 0) return 0;
            double tong = TinhTong(a, n);
            return tong / n;
        }

        // Bài 3: Tìm số lớn nhất và nhỏ nhất (Dùng từ khóa 'out' để trả về nhiều giá trị)
        static void TimMaxMin(int[] a, int n, out int maxVal, out int minVal)
        {
            maxVal = a[0];
            minVal = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > maxVal) maxVal = a[i];
                if (a[i] < minVal) minVal = a[i];
            }
        }

        // Bài 4: Đếm số chẵn và số lẻ
        static void DemChanLe(int[] a, int n, out int chan, out int le)
        {
            chan = 0;
            le = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0) chan++;
                else le++;
            }
        }

        // Bài 5: Tìm kiếm một số x (Trả về vị trí đầu tiên hoặc -1)
        static int TimKiemPhanTu(int[] a, int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x) return i;
            }
            return -1;
        }

        // Bài 6: Đảo ngược mảng
        static void DaoNguocMang(int[] a, int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                int temp = a[i];
                a[i] = a[n - 1 - i];
                a[n - 1 - i] = temp;
            }
        }

        // Bài 7: Kiểm tra mảng đối xứng
        static bool KiemTraDoiXuong(int[] a, int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                if (a[i] != a[n - 1 - i]) return false;
            }
            return true;
        }

        // Hàm bổ trợ kiểm tra số nguyên tố cho Bài 8
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Bài 8: Lọc các số nguyên tố từ mảng a sang mảng snt
        static void LocSoNguyenTo(int[] a, int n, int[] snt, out int nSnt)
        {
            nSnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (LaSoNguyenTo(a[i]))
                {
                    snt[nSnt] = a[i];
                    nSnt++;
                }
            }
        }

        // Bài 9: Tách mảng Chẵn - Lẻ sang hai mảng riêng biệt
        static void TachChanLe(int[] a, int n, int[] chan, out int nc, int[] le, out int nl)
        {
            nc = 0;
            nl = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    chan[nc] = a[i];
                    nc++;
                }
                else
                {
                    le[nl] = a[i];
                    nl++;
                }
            }
        }

        // Bài 10: Tự viết hàm sắp xếp tăng dần (Interchange Sort - Không dùng thư viện)
        static void SapXepTangDan(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        // Bài 10: Tự viết hàm sắp xếp giảm dần (Interchange Sort - Không dùng thư viện)
        static void SapXepGiamDan(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        // Bài 11: Chèn phần tử x vào mảng đã sắp xếp tăng dần (Dùng 'ref' để thay đổi số lượng n)
        static void ChenPhanTu(int[] a, ref int n, int x)
        {
            int i = n - 1;
            while (i >= 0 && a[i] > x)
            {
                a[i + 1] = a[i];
                i--;
            }
            a[i + 1] = x;
            n++;
        }

        // Bài 12: Xóa phần tử tại vị trí k (Dùng 'ref' để thay đổi số lượng n)
        static void XoaPhanTu(int[] a, ref int n, int k)
        {
            if (k < 0 || k >= n) return;
            for (int i = k; i < n - 1; i++)
            {
                a[i] = a[i + 1];
            }
            n--;
        }

        // Bài 14: Tìm phần tử xuất hiện nhiều nhất
        static int TimPhanTuXuatHienNhieuNhat(int[] a, int n)
        {
            int ans = a[0];
            int maxFreq = 0;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (a[i] == a[j]) count++;
                }
                if (count > maxFreq || (count == maxFreq && a[i] < ans))
                {
                    maxFreq = count;
                    ans = a[i];
                }
            }
            return ans;
        }

        // HÀM MAIN CỦA CHƯƠNG TRÌNH MẢNG 1 CHIỀU
        public static void Main(string[] args)
        {
            // Giả lập dữ liệu có sẵn trong bộ nhớ
            int n = 5;
            int[] a = new int[100];
            a[0] = 1; a[1] = 4; a[2] = 3; a[3] = 4; a[4] = 2;

            int x = 4;
            int viTriXoa = 2;
            int giaTriChen = 5;

            // Khai báo nhận kết quả tính toán thông qua biến
            double tong = TinhTong(a, n);
            double tbc = TinhTrungBinhCong(a, n);

            int lonNhat, nhoNhat;
            TimMaxMin(a, n, out lonNhat, out nhoNhat);

            int soChan, soLe;
            DemChanLe(a, n, out soChan, out soLe);

            int viTriTimThay = TimKiemPhanTu(a, n, x);
            bool doiXuong = KiemTraDoiXuong(a, n);

            int[] snt = new int[100];
            int nSnt;
            LocSoNguyenTo(a, n, snt, out nSnt);

            int[] mChan = new int[100];
            int[] mLe = new int[100];
            int nc, nl;
            TachChanLe(a, n, mChan, out nc, mLe, out nl);

            int xuatHienNhieuNhat = TimPhanTuXuatHienNhieuNhat(a, n);

            // Gọi các hàm biến đổi trực tiếp cấu trúc mảng
            SapXepTangDan(a, n);
            ChenPhanTu(a, ref n, giaTriChen);
            XoaPhanTu(a, ref n, viTriXoa);
            SapXepGiamDan(a, n);
            DaoNguocMang(a, n);
        }
    }
}

