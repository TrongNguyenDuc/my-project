//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP
//{
//    internal class HocSinh
//    {
//        private double Diem;
//        public string HoTen { get; set; }
//        public string Lop { get; set; }
//        public DateTime NgaySinh { get; set; }
//        public double DiemToan { get; set; }
//        public double DiemVan { get; set; }
//        public double DiemAnh { get; set; }
//        public double DiemTrungBinh 
//        { get
//            {
//                return ((DiemAnh + DiemVan + DiemToan) / 3);
//            }
//        }

//        public HocSinh(string hoTen, string lop, DateTime ngaySinh, double diemToan, double diemVan, double diemAnh)
//        {

//            HoTen = hoTen;
//            Lop = lop;
//            NgaySinh = ngaySinh;
//            DiemToan = diemToan;
//            DiemVan = diemVan;
//            DiemAnh = diemAnh;


//        }



//        public HocSinh()
//        {
//            Console.Write("nhap ho ten: ");
//            HoTen = Console.ReadLine();
//            Console.Write("nhap lop: ");
//            Lop = Console.ReadLine();
//            Console.Write("nhap ngay thang nam sinh: ");
//            NgaySinh = DateTime.Parse(Console.ReadLine());
//            Console.Write("nhap diem toan: ");
//            DiemToan = int.Parse(Console.ReadLine());
//            Console.Write("nhap diem van: ");
//            DiemVan = int.Parse(Console.ReadLine());
//            Console.Write("nhap diem anh: ");
//            DiemAnh = int.Parse(Console.ReadLine());
//        }

//        public void InThongTin()
//        {
//            Console.WriteLine($"{HoTen} hoc lop {Lop}, co diem trung binh 3 mon toan anh van  la {DiemTrungBinh}");
//        }
//    }
//}
//HocSinh hs =new HocSinh();
//HocSinh hs2 =new HocSinh("Nguyen Van T","12A2",new DateTime(1997,10,29),10,10,10);
//hs.InThongTin();
//hs2.InThongTin();

