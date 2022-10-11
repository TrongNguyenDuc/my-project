//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP
//{
//    internal class DonDatHang
//    {
//        public int MaDonDat { get; set; }
//        public DateTime NgayDat { get; set; }
//        public string TenSanPham { get; set; }
//        public double DonGia { get; set; }
//        public int SoLuong { get; set; }
//        public double ThanhTien { get => DonGia*SoLuong ;} 

//        public string GhiChu { get; set; }


//        public DonDatHang( int maDonDat, DateTime ngayDat, string tenSanPham, double donGia, int soLuong)
//        {
//            MaDonDat = maDonDat;
//            NgayDat = ngayDat;
//            TenSanPham = tenSanPham;
//            DonGia = donGia;
//            SoLuong = soLuong;
//        }   

//        public DonDatHang()
//        {
//            Console.Write("Nhap Ma Don Hang: ");
//            MaDonDat = int.Parse(Console.ReadLine());
//            Console.Write("Nhap Ten San Pham: ");
//            TenSanPham = Console.ReadLine();
//            Console.Write("Nhap Gia San Pham: ");          
//            DonGia = double.Parse(Console.ReadLine());
//            Console.Write("Nhap So Luong San Pham: ");
//            SoLuong= int.Parse(Console.ReadLine());
//            Console.Write("Nhap Ngay Thang Dat: ");
//            NgayDat = DateTime.Parse(Console.ReadLine());
//        }

//        public void InHoaDOn()
//        {
//            Console.WriteLine($"Don Hang Co So {MaDonDat} dat ngay {NgayDat} cos tong tien la: {ThanhTien}");
//        }
//    }
//}


//DonDatHang ddh = new DonDatHang();
//DonDatHang ddh1 = new DonDatHang(1,new DateTime(2022,10,1),"string",10000,3);
//ddh.InHoaDOn();
//ddh1.InHoaDOn();
