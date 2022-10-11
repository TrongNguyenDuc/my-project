//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP.cuahangsach
//{
//    internal class Tailieu
//    {
//        public int MaTaiLieu { get; set; }
//        public string TenNhaXuatBan { get; set; }
//        public int SoBanPhatHanh { get; set; }
//        public string TenTaiLieu { get; set; }

//        public virtual void nhapthongtin()
//        {
//            Console.Write("Nhap Ma tai lieu: ");
//            MaTaiLieu = int.Parse(Console.ReadLine());
//            Console.Write("Nhap Ten Nha Xuat Ban: ");
//            TenNhaXuatBan = Console.ReadLine();
//            Console.Write("Nhap So Ban Phat Hanh: ");
//            SoBanPhatHanh = int.Parse(Console.ReadLine());
//            Console.Write("Nhap Ten Tai Lieu: ");
//            TenTaiLieu = Console.ReadLine();
//        }
//        public virtual void hienthi()
//        {
//            Console.WriteLine($"Ma tai lieu: {MaTaiLieu}\n Ten nha xuat ban {TenNhaXuatBan}\n So ban phat hanh {SoBanPhatHanh} \nTen tai lieu {TenTaiLieu}\n");
//        }

//        public static List<Tailieu> timkiemtailieu(string ten, List<Tailieu> danhsach)
//        {
//            List<Tailieu> lst = new List<Tailieu>();
//            for (int i = 0; i < danhsach.Count; i++)
//            {
//                if (danhsach[i].TenTaiLieu.ToLower().Contains(ten.ToLower()))
//                {
//                    lst.Add(danhsach[i]);
//                }
//            }
//            return lst;
//        }
//    }
//}


//Tailieu sach = new TapChi();
//sach.nhapthongtin();

//Console.Write("\n");
//Tailieu sach1 = new Sach();
//sach1.nhapthongtin();

//Console.Write("\n");
//Tailieu sach2 = new TruyenTranh();
//sach2.nhapthongtin();

//Console.Write("\n");
//Console.Write("Nhap Ten Muon Tim: ");
//string ten = Console.ReadLine();
//Console.Write("\n");

//List<Tailieu> lst = new List<Tailieu> { sach, sach1, sach2 };

//List<Tailieu> lst2 = Tailieu.timkiemtailieu(ten, lst);
//for (int i = 0; i < lst2.Count; i++)
//{
//    lst2[i].hienthi();
//}
