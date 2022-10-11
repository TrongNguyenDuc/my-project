//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP
//{
//    internal class HocVien
//    {
//        public int MaHocVien { get; set; }

//        private double hocphi;


//        private string hoten;
//        public string HoTen
//        {
//            get
//            {
//                { return hoten; }
//            }
//            set
//            {
//                hoten = value;
//                while (hoten.Contains("  "))
//                {
//                    hoten = hoten.Replace("  ", " ");
//                }
//                string[] arrHoten = hoten.Split(' ');
//                Ho = arrHoten.First();
//                Ten = arrHoten.Last();
//                Email = Ten+"@edusolution.com";
//            }
//        }
//        public DateTime NgaySinh { get; set; }
//        public string Ho { get; set; }
//        public string Ten { get; set; }
//        public double HocPhi
//        {
//            get { return hocphi; }
//            set
//            {
//                if (value > 3000000)
//                {
//                    hocphi = value * 5 / 100;
//                }
//            }
//        }
//        public string Email { get; set; }

//        public HocVien()
//        {
//            Console.Write("Nhap Ma Hoc Vien: ");
//            MaHocVien = int.Parse(Console.ReadLine());
//            Console.Write("Nhap Ho Ten: ");
//            HoTen = Console.ReadLine();
//            Console.Write("Nhap Ngay Sinh: ");
//            NgaySinh = DateTime.Parse(Console.ReadLine());
//            Console.Write("Nhap Hoc Phi: ");
//            HocPhi = double.Parse(Console.ReadLine());

//        }
//        public HocVien(int maHocVien, string hoTen, DateTime ngaySinh, double hocPhi)
//        {
//            MaHocVien = maHocVien;
//            HoTen = hoTen;
//            NgaySinh = ngaySinh;
//            HocPhi = hocPhi;
//        }

//        public void In()
//        {
//            Console.WriteLine($"{MaHocVien} co ten {HoTen} co email la {Email}");
//        }

//        public static List<HocVien> TimKiemHocVien(List<HocVien>lst,string tenhocvien)
//        {
//            List<HocVien> danhsach =new List<HocVien>();
//            for (int i = 0; i < lst.Count; i++)
//            {
//                if (lst[i].HoTen.ToLower().Contains(tenhocvien.ToLower()))
//                {
//                    danhsach.Add(lst[i]);
//                }
//            }
//            return danhsach;
//        }
//    }
//}

//HocVien hv = new HocVien();
//HocVien hv1 = new HocVien(1, "Tran Thi Nghe", new DateTime(2022, 10, 22), 5000000);
//hv.In();
//hv1.In();

//Console.Write("Ten Muon Tim: ");
//string ten = Console.ReadLine();
//List<HocVien> lst = new List<HocVien>
//            {
//                new HocVien(1,"Nguyen Thi Nghe",new DateTime(2022,10,22),5000000),
//                new HocVien(3,"Tran Thi Nhin",new DateTime(2022,10,22),5000000),
//                new HocVien(4,"Tran Thi noi",new DateTime(2022,10,22),5000000),
//                new HocVien(5,"Tran Thi tay",new DateTime(2022,10,22),5000000),
//                new HocVien(6,"nam Thi chan",new DateTime(2022,10,22),5000000),
//                new HocVien(7,"Tran Thi mat",new DateTime(2022,10,22),5000000),
//            };
//List<HocVien> DanhSach = HocVien.TimKiemHocVien(lst, ten);
//for (int i = 0; i < DanhSach.Count; i++)
//{
//    DanhSach[i].In();
//}
