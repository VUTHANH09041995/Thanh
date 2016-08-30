using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_C7_lan_1
{
    class SANPHAM
    {
        private string Ten_SP;
        public float Gia;
        //hàm tạo 
        public SANPHAM(string TSP = "A", float G = 0)
        {
            Ten_SP = TSP;
            Gia = G;
        }
        //hàm nhập
        public void nhap()
        {
            Console.Write("Nhap ten san pham: ");
            Ten_SP = Console.ReadLine();
            Console.Write("Nhap gia: ");
            Gia = float.Parse(Console.ReadLine());
        }
        //hàm xuất
        public void xuat()
        {
            Console.WriteLine("Ten san pham: {0}", Ten_SP);
            Console.WriteLine("Gia: {0}", Gia);
        }
        
    }
    class SANXUAT : SANPHAM
    {
        private int So_Luong;
        private string Ten_CN;
        //hàm tạo 
        public SANXUAT(int SL = 0, string TCN = "B", string TSP = "A", float G = 0)
            : base(TSP, G)
        {
            So_Luong = SL;
            Ten_CN = TCN;
        }
        //phuong thuc tính tổng
        public double tinh_tong()
        {
            return (So_Luong * 0.05 * Gia);
        }
        //hàm nhập 
        public void nhap()
        {
            base.nhap();
            Console.Write("Nhap Ten cong nhan: ");
            Ten_CN = Console.ReadLine();
            Console.Write("Nhap so luong: ");
            So_Luong = int.Parse(Console.ReadLine());
        }
        //hàm xuất
        public void xuat()
        {
            base.xuat();
            Console.WriteLine("Ten cong nhan: {0}", Ten_CN);
            Console.WriteLine("So Luong: {0}", So_Luong);
            Console.WriteLine("Luong cua CN: {0}", tinh_tong());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Nhap so luong san pham: ");
            N = int.Parse(Console.ReadLine());
            SANXUAT[]a =new SANXUAT[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Nhap san pham thu :" + (i + 1).ToString());
                a[i] = new SANXUAT();
                a[i].nhap();
            }
            Console.WriteLine("---Danh sach vua nhap---");
             for(int i = 0 ; i<N;  i++)
              {
                    a[i].xuat();
              }
             double tong = 0;
             for (int i = 0; i < N; i++)
             {
                 tong += a[i].tinh_tong();
             }
             Console.WriteLine("Tong luong: {0}", tong);
            double max = a[0].tinh_tong();
             for (int i = 0; i < N; i++)
             {
                 if (max < a[i].tinh_tong())
                 {
                     max = a[i].tinh_tong();
                 }
             }
             Console.WriteLine("tong luong max = {0}", max);
             Console.ReadKey();
        }
    }
}
