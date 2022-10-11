//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP
//{
//    internal class LopHoc
//    {
//        public int MaLop { get; set; }
//        public string TenLop { get; set; }
//        public int SiSo { get; set; }
//        public string DiaChi { get; set; }
//        public string GVCN { get; set; }


//        public LopHoc()
//        {
//            Console.Write("nhap ma lop: ");
//            MaLop = int.Parse(Console.ReadLine());
//            Console.Write("nhap Ten Lop: ");
//            TenLop = Console.ReadLine();
//            Console.Write("nhap Si So Lop: ");
//            SiSo = int.Parse(Console.ReadLine());
//            Console.Write("nhap Dia Chi Lop: ");
//            DiaChi = Console.ReadLine();
//            Console.Write("nhap Ten GVCN: ");
//            GVCN = Console.ReadLine();
//        }

//        public LopHoc(int maLop, string tenLop, int siSo, string diaChi, string gVCN)
//        {
//            MaLop = maLop;
//            TenLop = tenLop;
//            SiSo = siSo;
//            DiaChi = diaChi;
//            GVCN = gVCN;
//        }

//        public void InThongTin()
//        {
//            Console.Write("\n");
//            Console.WriteLine($"Lop {TenLop} co ma la {MaLop} o {DiaChi}");
//            Console.Write("\n");
//            Console.WriteLine($"Lop co {SiSo} hoc sinh va co {GVCN} la Giao Vien Chu Nhiem");
//        }
//    }
//}


