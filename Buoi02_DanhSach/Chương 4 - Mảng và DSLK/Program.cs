using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
namespace BTTH_Buoi_2
{
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    class Program
    {

        static void Bai4_1()
        {
            Console.Write("Nhập số phần tử trong mảng: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0) 
            { 
                Console.WriteLine("Không hợp lệ! Nhập lại!"); 
                return; 
            }
            int[] DSSN = new int[n];
            for(int i = 0;  i < DSSN.Length; i++)
            {
                Console.Write($"Nhập số nguyên thứ {i + 1}: ");
                DSSN[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Danh sách các phần tử trong mảng: ");
            for (int i = 0;i < DSSN.Length; i++) Console.Write(DSSN[i] + " ");
            Console.Write("\nNhập giá trị x cần chèn: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập vị trí k cần chèn vào: ");
            int k = int.Parse(Console.ReadLine());
            if(k < 0 || k > DSSN.Length + 1) 
            {
                Console.Write("Vị trí không hợp lệ!"); 
                return; 
            }
            int[] tmp = new int[DSSN.Length + 1];
            for (int i = 0; i < k; i++) 
            { 
                tmp[i] = DSSN[i]; 
            }
            tmp[k] = x;
            for (int i = k; i < DSSN.Length; i++) tmp[i + 1] = DSSN[i];
            DSSN = tmp;
            Console.Write($"Mảng sau khi chèn {x} vào vị trí {k}: ");
            for (int i = 0; i < DSSN.Length; i++)
            {
                Console.Write(DSSN[i] + " ");
            }
            
        }
        struct NhanVien
        {
            public string MaNV;
            public string HoTen;
            public int NamSinh;
            public string PhongBan;
            public int LuongCB;
            public int Thuong;
            public int ThucLinh => LuongCB + Thuong;
        }
        static NhanVien[] DSNV;
        static int a;
        static void NhapNV()
        {
            Console.Write("Nhập số nhân viên cần cho vào DS: ");
            int v = int.Parse(Console.ReadLine());
            if (v <= 0) { Console.WriteLine("Số lượng không hợp lệ!"); return; }
            a = v;
            DSNV = new NhanVien[a];
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"\n---Nhập thông tin cho nhân viên thứ {i + 1}---");
                Console.Write("Nhập mã nhân viên: ");
                DSNV[i].MaNV = Console.ReadLine();
                Console.Write("Nhập họ tên nhân viên: ");
                DSNV[i].HoTen = Console.ReadLine();
                Console.Write("Nhập năm sinh: ");
                DSNV[i].NamSinh = int.Parse(Console.ReadLine());
                Console.Write("Nhập phòng ban: ");
                DSNV[i].PhongBan = Console.ReadLine();
                Console.Write("Nhập lương cơ bản: ");
                DSNV[i].LuongCB = int.Parse(Console.ReadLine());
                Console.Write("Nhập lương thưởng: ");
                DSNV[i].Thuong = int.Parse(Console.ReadLine());

            }
        }
        static int ThucLinh (int x)
        {
            int TongTL = 0;
            for (int i = 0; i < x;i++)
            {
                TongTL += DSNV[i].LuongCB + DSNV[i].Thuong;
            }
            return TongTL;
        }
        static void LuongNVmin(NhanVien[] DSNV, int n)
        {
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (min > DSNV[i].LuongCB)
                {
                    min = DSNV[i].LuongCB;
                }
            }
             Console.WriteLine("\nDanh sách nhân viên có lương cơ bản thấp nhất");
             for (int i = 0;i < n; i++)
             {
                 if (DSNV[i].LuongCB == min)
                 {
                    Console.WriteLine($"- Mã nhân viên: {DSNV[i].MaNV} | Họ tên: {DSNV[i].HoTen} | Lương cơ bản: {DSNV[i].LuongCB}");
                 }
             }
        }
        static void LocNV()
        {
            int dem = 0;
            for(int i = 0; i < DSNV.Length; i++)
            {
                if (DSNV[i].Thuong >= 1200000)
                dem++;
            }
            Console.Write("\nSố lượng nhân viên có lương thưởng >= 1200000: " + dem);
        }
        static void SapXep()
        {
            for (int i = 0; i  < DSNV.Length; i++)
            {
                for (int j = i + 1; j < DSNV.Length; j++)
                {
                    if (string.Compare(DSNV[i].PhongBan, DSNV[j].PhongBan) > 0 || (DSNV[i].PhongBan == DSNV[i].PhongBan && string.Compare(DSNV[i].MaNV, DSNV[j].MaNV) < 0))
                    {
                        NhanVien tam = DSNV[i];
                        DSNV[i] = DSNV[j];
                        DSNV[j] = tam;
                    }
                }
            }
            Console.WriteLine("\nDanh sách nhân viên sau khi sắp xếp: ");
            for (int i = 0;i < DSNV.Length; i++)
            {
                Console.WriteLine($"- Mã nhân viên: {DSNV[i].MaNV} | Họ tên: {DSNV[i].HoTen}");
            }
        }

        static void TangLuong()
        {
            for (int i = 0; i < DSNV.Length; i++)
            {
                DSNV[i].LuongCB = DSNV[i].LuongCB + (DSNV[i].LuongCB * 5 / 100);
            }
            Console.WriteLine("\nDanh sách nhân viên khi tăng lương lên 5%: ");
            for (int i = 0;i < DSNV.Length; i++)
            {
                Console.WriteLine($"- Mã nhân viên: {DSNV[i].MaNV} | Lương cơ bản: {DSNV[i].LuongCB}");
            }
        }

        static void HienThiNV()
        {
            Console.WriteLine("==========DANH SÁCH NHÂN VIÊN==========");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"\nNhân viên thứ {i + 1}:");
                Console.WriteLine($"     - Mã nhân viên: {DSNV[i].MaNV}");
                Console.WriteLine($"     - Tên nhân viên: {DSNV[i].HoTen}");
                Console.WriteLine($"     - Năm sinh: {DSNV[i].NamSinh}");
                Console.WriteLine($"     - Phòng ban NV: {DSNV[i].PhongBan}");
                Console.WriteLine($"     - Lương cơ bản: {DSNV[i].LuongCB}");
                Console.WriteLine($"     - Lương thưởng: {DSNV[i].Thuong}");
                Console.WriteLine($"     - Tổng thực lĩnh tháng: {ThucLinh(i)}");
            }
            LuongNVmin(DSNV, a);
            LocNV();
        }
    static void Bai4_3()
        {
            static int[,] NhapMaTran(out int n)
            {
                Console.Write("Nhập ma trận n (0 <= n < 100): ");
                n = int.Parse(Console.ReadLine());
                int[,] s = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"a[{i},{j}] = ");
                        s[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                return s;
            }
            static int TimDuongNN(int[,] s, int n)
            {
                int minDuong = int.MaxValue;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (s[i, j] > 0 && s[i, j] < minDuong)
                        {
                            minDuong = s[i, j];
                        }
                    }
                }
                return (minDuong == int.MaxValue) ? -1 : minDuong;
            }

            static int TinhTongMaTran(int[,] s, int n)
            {
                int tongMT = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        tongMT += s[i, j];
                    }
                }
                return tongMT;
            }
            static int TinhTongCheoPhu(int[,] s, int n)
            {
                int TongCheo = 0;
                for (int i = 0; i < n; i++)
                {
                    TongCheo += s[i, n - 1 - i];
                }
                return TongCheo;
            }
            static bool KiemTraDCC(int[,] s, int n)
            {
                if (n <= 1) return true;
                for (int i = 0; i < n - 1; i++)
                {
                    if (s[i, i] >= s[i + 1, i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }
            static void HienThiMT()
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                int n;
                int[,] a = NhapMaTran(out n);

                Console.WriteLine($"\na. Tổng tất cả phần tử của ma trận: {TinhTongMaTran(a, n)}");

                int minDuong = TimDuongNN(a, n);
                if (minDuong != -1)
                    Console.WriteLine($"b. Giá trị dương nhỏ nhất: {minDuong}");
                else
                    Console.WriteLine("b. Ma trận không có giá trị dương nào.");

                Console.WriteLine($"c. Tổng các phần tử trên đường chéo phụ: {TinhTongCheoPhu(a, n)}");

                if (KiemTraDCC(a, n))
                    Console.WriteLine("d. Đường chéo chính TĂNG DẦN.");
                else
                    Console.WriteLine("d. Đường chéo chính KHÔNG tăng dần.");
            }
            HienThiMT();
        }

        static void Bai4_4()
        {

            Node pHead = null;

            Console.Write("Nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int val;
                do
                {
                    Console.Write($"Nhập phần tử thứ {i + 1} (số nguyên dương): ");
                    val = int.Parse(Console.ReadLine());
                } while (val <= 0);

                Node nutMoi = new Node(val);
                if (pHead == null)
                {
                    pHead = nutMoi;
                }
                else
                {
                    Node tam = pHead;
                    while (tam.Next != null)
                    {
                        tam = tam.Next;
                    }
                    tam.Next = nutMoi;
                }
            }
            Console.Write("\nDanh sách ban đầu: ");
            Node p = pHead;
            if (p == null)
            {
                Console.WriteLine("Rỗng");
            }
            else
            {
                while (p != null)
                {
                    Console.Write(p.Data + (p.Next != null ? " -> " : ""));
                    p = p.Next;
                }
                Console.WriteLine();
            }
            Console.Write("\nNhập giá trị x cần đếm: ");
            int xDem = int.Parse(Console.ReadLine());
            int d = 0;
            p = pHead;
            while (p != null)
            {
                if (p.Data == xDem)
                {
                    d++;
                }
                p = p.Next;
            }
            Console.WriteLine($"a. Số lượng phần tử bằng {xDem}: {d}");
            int minDuong = int.MaxValue;
            p = pHead;
            while (p != null)
            {
                if (p.Data > 0 && p.Data < minDuong)
                {
                    minDuong = p.Data;
                }
                p = p.Next;
            }
            if (minDuong != int.MaxValue)
                Console.WriteLine($"b. Phần tử dương nhỏ nhất: {minDuong}");
            else
                Console.WriteLine("b. Không có phần tử dương nào trong danh sách.");
            Console.Write("\nNhập giá trị x cần xóa (lần xuất hiện đầu tiên): ");
            int xXoa = int.Parse(Console.ReadLine());

            bool daXoa = false;
            p = pHead;
            Node t = null; 

            while (p != null)
            {
                if (p.Data == xXoa)
                {
                    if (p == pHead)
                    {
                        pHead = pHead.Next;
                    }
                    else
                    {
                        t.Next = p.Next;
                    }
                    daXoa = true;
                    break;
                }
                t = p;
                p = p.Next;
            }

            if (daXoa)
            {
                Console.Write($"c. Đã xóa {xXoa}. Danh sách sau khi xóa: ");
                p = pHead;
                if (p == null)
                {
                    Console.WriteLine("Rỗng");
                }
                else
                {
                    while (p != null)
                    {
                        Console.Write(p.Data + (p.Next != null ? " -> " : ""));
                        p = p.Next;
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"c. Không tìm thấy {xXoa} để xóa.");
            }
        }


        static void Bai4_5()
        {
            Console.Write("Nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());
            int[] p = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                p[i] = int.Parse(Console.ReadLine());
            }
            int max = int.MinValue;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] > max)
                    max = p[i];
            }
            Console.WriteLine($"a. Phần tử lớn nhất là: {max}");
            int t = 0;
            for (int i = 0; i < p.Length; i++)
            {
                t += p[i];
            }   
            Console.WriteLine($"b. Tổng các phần tử là: {t}");
            int demLN = 0;
            for (int i = 0; i < p.Length; i++)
            {
                bool laNT = p[i] >= 2;
                for (int j = 2; j <= Math.Sqrt(p[i]); j++)
                {
                    if (p[i] % j == 0)
                    {
                        laNT = false;
                        break;
                    }
                }
                if (laNT) demLN++;
            }
            Console.WriteLine($"c. Số lượng số nguyên tố là: {demLN}");
            int demAm = 0, demso0 = 0, demDuong = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] < 0) demAm++;
                else if (p[i] > 0) demDuong++;
                else demso0++;
            }
            Console.WriteLine($"d. Số âm: {demAm}, Số bằng 0: {demso0}, Số dương: {demDuong}");
            Console.Write("Nhập giá trị x cần đếm: ");
            int x = int.Parse(Console.ReadLine());
            int demX = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == x)
                    demX++;
            }
            Console.WriteLine($"e. Số lượng phần tử bằng {x} là: {demX}");
            int minDuong = int.MaxValue;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] > 0 && p[i] < minDuong)
                    minDuong = p[i];
            }
            if (minDuong == int.MaxValue)
                Console.WriteLine("f. Danh sách không có số dương");
            else
                Console.WriteLine($"f. Phần tử dương nhỏ nhất là: {minDuong}");
        }
        
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("=============== Chương 4: Mảng và danh sách liên kết ===============");
            Console.WriteLine("----------Bài 1----------");
            Bai4_1();
            Console.WriteLine("\n----------Bài 2----------");
            NhapNV();
            HienThiNV();
            SapXep();
            TangLuong();
            Console.WriteLine("\n----------Bài 3----------");
            Bai4_3();
            Console.WriteLine("\n----------Bài 4----------");
            Bai4_4();
            Console.WriteLine("\n----------Bài 5----------");
            Bai4_5();

        }
    }
}