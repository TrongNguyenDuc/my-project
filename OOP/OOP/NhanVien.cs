//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP
//{
//    internal class NhanVien
//    {
//        public int MaNhanVien { get; set; }
//        public string HoVaTen { get; set; }
//        public string PhongBan { get; set; }
//        public string DiaChi { get; set; }
//        public string SoDienThoai { get; set; }


//        public NhanVien()
//        {
//            Console.Write("nhap ma nhan vien: ");
//            MaNhanVien = int.Parse(Console.ReadLine());
//            Console.Write("nhap Ho Va Ten: ");
//            HoVaTen = Console.ReadLine();
//            Console.Write("nhap Phong Ban: ");
//            PhongBan = Console.ReadLine();
//            Console.Write("nhap Dia Chi: ");
//            DiaChi = Console.ReadLine();
//            Console.Write("nhap So Dien Thoai: ");
//            SoDienThoai = Console.ReadLine();

//        }

//        public void InThongTin()
//        {
//            Console.WriteLine($"Nhan vien {HoVaTen} thuoc phong ban {PhongBan} co so dien thoai la {SoDienThoai}");
//        }
//    }


//}

//NhanVien nv = new NhanVien();
//nv.InThongTin();
