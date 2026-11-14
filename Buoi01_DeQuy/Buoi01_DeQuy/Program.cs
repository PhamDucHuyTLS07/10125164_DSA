using System;
using System.Diagnostics;
namespace BaiTapCua3Chuong
{
    class Program
    {
        //===============CHƯƠNG 1: Tổng quan về cấu trúc dữ liệu và giải thuật===============
        // Bài 1: Nhập mảng, tìm max và min
        static void Bai1_1()
        {
            Console.Write("Nhập số phần tử trong mảng: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0) { Console.WriteLine("Số phần tử phải lớn hơn 0."); return; }

            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phần tử thứ {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Các phần tử trong mảng: ");
            foreach (int x in mang) Console.Write(x + " ");

            int max = mang[0], min = mang[0];
            for (int i = 1; i < n; i++)
            {
                if (mang[i] > max) max = mang[i];
                if (mang[i] < min) min = mang[i];
            }
            Console.WriteLine("\nPhần tử lớn nhất: " + max);
            Console.WriteLine("Phần tử nhỏ nhất: " + min);
        }

        // Bài 2: FizzBuzz
        static void Bai1_2()
        {
            int n;
            do
            {
                Console.Write("Nhập một số từ 1 đến 100: ");
                n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 100) Console.WriteLine("Số không hợp lệ, nhập lại!");
            } while (n < 1 || n > 100);

            if (n % 3 == 0 && n % 5 == 0)
                Console.WriteLine("Kết quả: FizzBuzz");
            else if (n % 5 == 0)
                Console.WriteLine("Kết quả: Buzz");
            else if (n % 3 == 0)
                Console.WriteLine("Kết quả: Fizz");
            else
                Console.WriteLine("Kết quả: " + n);
        }

        // Bài 3: Đảo ngược chuỗi
        static void Bai1_3()
        {
            Console.Write("Nhập một chuỗi để đảo ngược: ");
            string s = Console.ReadLine();
            char[] dayChuoi = s.ToCharArray();
            Array.Reverse(dayChuoi);
            Console.WriteLine("Chuỗi sau khi đảo: " + new string(dayChuoi));
        }

        // Bài 4: Sắp xếp mảng tăng dần
        static void Bai1_4()
        {
            Console.Write("Nhập số phần tử trong mảng: ");
            int n = int.Parse(Console.ReadLine()); 
            if (n <= 0) { Console.WriteLine("Số phần tử phải lớn hơn 0."); return; }

            int i, j;
            int[] mang = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Mảng ban đầu: ");
            foreach (int x in mang) Console.Write(x + " ");
            for ( i = 0; i < n - 1; i++)
                for (j = 0; j < n - i - 1; j++)
                    if (mang[j] > mang[j + 1])
                    {
                        int temp = mang[j];
                        mang[j] = mang[j + 1];
                        mang[j + 1] = temp;
                    }

            Console.Write("\nMảng sau khi sắp xếp tăng dần: ");
            foreach (int x in mang) Console.Write(x + " ");
            Console.WriteLine();
        }

        // Bài 5: Dãy Fibonacci và số Fibonacci thứ n
        static void Bai1_5()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0) { Console.WriteLine("Vui lòng nhập n > 0."); return; }

            Console.Write("Dãy Fibonacci đầu tiên: ");
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }

            Console.WriteLine();
            Console.WriteLine($"Giá trị Fibonacci ở vị trí {n} là: {FibonacciThuN(n)}");
        }

        static int FibonacciThuN(int n)
        {
            if (n == 1) return 0;
            if (n == 2) return 1;
            int a = 0, b = 1, temp = 0;
            for (int i = 3; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }
            return temp;
        }



        // ==================== CHƯƠNG 2: Phân tích giải thuật ====================

        // Bài 1: Tháp Hà Nội
        static int demThapHaNoi;
        static void Bai2_1()
        {
            Console.Write("Nhập số đĩa: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0) { Console.WriteLine("Số đĩa phải lớn hơn 0."); return; }
            demThapHaNoi = 0;
            HaNoi(n, 'A', 'B', 'C');
            Console.WriteLine("Tổng số lần chuyển: " + demThapHaNoi);
        }

        static void HaNoi(int n, char A, char B, char C)
        {
            if (n == 1)
            {
                demThapHaNoi++;
                Console.WriteLine($"Chuyển đĩa 1 từ {A} sang {C}");
                return;
            }
            HaNoi(n - 1, A, C, B);
            demThapHaNoi++;
            Console.WriteLine($"Chuyển đĩa {n} từ {A} sang {C}");
            HaNoi(n - 1, B, A, C);
        }


        // Bài 2: So sánh tìm kiếm tuần tự và nhị phân
        static void Bai2_2()
        {
            int[] kichThuoc = { 1000, 100000, 1000000, 10000000 };
            foreach (int n in kichThuoc)
            {
                int[] a = new int[n];
                for (int i = 0; i < n; i++) a[i] = i * 2;
                int canTim = -1;

                Stopwatch sw = new Stopwatch();
                sw.Start();
                for (int lan = 0; lan < 10; lan++) TimTuanTu(a, canTim);
                sw.Stop();
                long tick1 = sw.ElapsedTicks;

                sw.Restart();
                for (int lan = 0; lan < 10; lan++) TimNhiPhan(a, canTim);
                sw.Stop();
                long tick2 = sw.ElapsedTicks;

                Console.WriteLine($"n = {n}: Tuần tự = {tick1} ticks, Nhị phân = {tick2} ticks");
            }
        }

        static int TimTuanTu(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x) return i;
            return -1;
        }

        static int TimNhiPhan(int[] a, int x)
        {
            int dau = 0, cuoi = a.Length - 1;
            while (dau <= cuoi)
            {
                int giua = dau + (cuoi - dau) / 2;
                if (a[giua] == x) return giua;
                else if (a[giua] < x) dau = giua + 1;
                else cuoi = giua - 1;
            }
            return -1;
        }

        // Bài 3: Kiểm tra số nguyên tố
        static void Bai2_3()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập một số n để kiểm tra: ");
            int n = int.Parse(Console.ReadLine());
            bool KT = true;
            if (n < 2)
                KT = false;
            else
            {
                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        KT = false;
                        break;
                    }
                }
            }
            if (KT)
                Console.WriteLine($"{n} là số nguyên tố");
            else
                Console.WriteLine($"{n} không là số nguyên tố");
        }

        // Bài 4: Số hoàn hảo nhỏ hơn N
        static void Bai2_4()
        {
            Console.Write("Nhập số nguyên dương N: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 1) { Console.WriteLine("Vui lòng nhập N > 1."); return; }

            Console.Write("Các số hoàn hảo nhỏ hơn N là: ");
            for (int i = 2; i < n; i++)
            {
                int tong = 0;
                for (int j = 1; j < i; j++)
                    if (i % j == 0) tong += j;
                if (tong == i) Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // Bài 5: Tìm số Fibonacci thứ n
        static void Bai2_5()
        {
            Console.Write("Nhập vị trí n: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0) { Console.WriteLine("Vui lòng nhập n > 0."); return; }
            Console.WriteLine($"Giá trị Fibonacci ở vị trí {n} là: {FibonacciThuN(n)}");
        }


        // Bài 6: Sắp xếp mảng tăng dần
        static void Bai2_6()
        {
            Console.Write("Nhập số phầ tử trong mảng: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0) { Console.WriteLine("Số phần tử phải lớn hơn 0."); return; }
            int i, j;
            int[] mang = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Phần tử trong mảng: ");
            foreach (int x in mang) Console.Write(x + " ");

            for (i = 0; i < n - 1; i++)
                for (j = 0; j < n - i - 1; j++)
                    if (mang[j] > mang[j + 1])
                    {
                        int temp = mang[j];
                        mang[j] = mang[j + 1];
                        mang[j + 1] = temp;
                    }

            Console.Write("\nMảng sau khi được sắp xếp: ");
            foreach (int x in mang) Console.Write(x + " ");
            Console.WriteLine();
        }


        // ==================== CHƯƠNG 3 - ĐỆ QUY ====================

        // Bài 1: Tính tổng từ 1 đến n
        static void Bai3_1()
        {
            Console.Write("Nhập số tự nhiên n: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0) { Console.WriteLine("Vui lòng nhập n >= 0."); return; }
            Console.WriteLine($"Tổng từ 1 đến {n} là: {TongN(n)}");
        }

        static long TongN(int n)
        {
            if (n == 0) return 0;
            return n + TongN(n - 1);
        }


        // Bài 2: Tổng các lũy thừa liên tiếp: 1^1 + 2^2 + ... + n^n
        static void Bai3_2()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0) { Console.WriteLine("Vui lòng nhập n >= 0."); return; }
            Console.WriteLine("Tổng lũy thừa liên tiếp = " + TongLuyThua(n));
        }

        static long LuyThuaNguyen(int a, int b)
        {
            if (b == 0) return 1;
            return (long)a * LuyThuaNguyen(a, b - 1);
        }

        static long TongLuyThua(int n)
        {
            if (n == 0) return 0;
            return TongLuyThua(n - 1) + LuyThuaNguyen(n, n);
        }



        // Bài 3: Tổng 1 + 1/2 + ... + 1/n
        static void Bai3_3()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0) { Console.WriteLine("Vui lòng nhập n >= 0."); return; }
            Console.WriteLine("Tổng phân số = " + TongPhanSo(n));
        }

        static double TongPhanSo(int n)
        {
            if (n == 0) return 0;
            return TongPhanSo(n - 1) + 1.0 / n;
        }



        // Bài 4: Tính x^n
        static void Bai3_4()
        {
            Console.Write("Nhập x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhập số mũ của x: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Vui lòng nhập n >= 0!");
                return;
            }
            Console.WriteLine($"Kết quả = {LuyThuaThuc(x, n)}");
        }

        static double LuyThuaThuc(double x, int n)
        {
            if (n == 0) return 1;
            return x * LuyThuaThuc(x, n - 1);
        }


        // Bài 5: Tìm ước số lẻ lớn nhất
        static void Bai3_5()
        {
            Console.Write("Nhập số tự nhiên n để kiểm tra: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương!");
                return;
            }
            Console.WriteLine("Ước số lẻ lớn nhất là: " + TimUocLeLN(n));
        }

        static int TimUocLeLN(int n)
        {
            if (n % 2 != 0) return n;
            return TimUocLeLN(n / 2);
        }


        // Bài 6: Tìm UCLN bằng thuật toán Euclid đệ quy
        static void Bai3_6()
        {
            Console.Write("Nhập số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());
            a = Math.Abs(a);
            b = Math.Abs(b);
            Console.WriteLine($"UCLN của hai số {a}, {b} là = {UCLN(a, b)}");
        }

        static int UCLN(int a, int b)
        {
            if (b == 0) return a;
            return UCLN(b, a % b);
        }


        // Bài 7: Đếm số chữ số của số nguyên dương n
        static void Bai3_7()
        {
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Vui lòng nhập số nguyên dương!");
                return;
            }
            Console.WriteLine($"Số chữ số của {n} là: {DemChuSo(n)}");
        }

        static int DemChuSo(int n)
        {
            if (n < 10) return 1;
            return 1 + DemChuSo(n / 10);
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=============== CHƯƠNG 1: Tổng quan về cấu trúc dữ liệu và giải thuật ===============");
            Console.WriteLine("---------- Bài 1 ----------");
            Bai1_1();
            Console.WriteLine("\n---------- Bài 2 ----------");
            Bai1_2();
            Console.WriteLine("\n---------- Bài 3 ----------");
            Bai1_3();
            Console.WriteLine("\n---------- Bài 4 ----------");
            Bai1_4();
            Console.WriteLine("\n---------- Bài 5 ----------");
            Bai1_5();
            Console.WriteLine("\n==================== CHƯƠNG 2: Phân tích giải thuật ====================");
            Console.WriteLine("---------- Bài 1 ----------");
            Bai2_1();
            Console.WriteLine("\n---------- Bài 2 ----------");
            Bai2_2();
            Console.WriteLine("\n---------- Bài 3 ----------");
            Bai2_3();
            Console.WriteLine("\n---------- Bài 4 ----------");
            Bai2_4();
            Console.WriteLine("\n---------- Bài 5 ----------");
            Bai2_5();
            Console.WriteLine("\n---------- Bài 6 ----------");
            Bai2_6();
            Console.WriteLine("\n==================== CHƯƠNG 3: Đệ Quy ====================");
            Console.WriteLine("---------- Bài 1 ----------");
            Bai3_1();
            Console.WriteLine("\n---------- Bài 2 ----------");
            Bai3_2();
            Console.WriteLine("\n---------- Bài 3 ----------");
            Bai3_3();
            Console.WriteLine("\n---------- Bài 4 ----------");
            Bai3_4();
            Console.WriteLine("\n---------- Bài 5 ----------");
            Bai3_5();
            Console.WriteLine("\n---------- Bài 6 ----------");
            Bai3_6();
            Console.WriteLine("\n---------- Bài 7 ----------");
            Bai3_7();
        }
    }
}