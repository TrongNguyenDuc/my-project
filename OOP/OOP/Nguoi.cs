//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP
//{
//    internal class Nguoi
//    {
//        public int MaSo { get; set; }
//        private string hoten;
//        public string HoTen
//        {
//            get 
//            {
//                {return hoten; }
//            }
//            set
//            {
//                hoten = value;
//                while (hoten.Contains("  "))
//                {
//                    hoten = hoten.Replace("  ", " ");
//                }
//                string[] arrHoten = hoten.Split(' ');
//                Ten = arrHoten.Last();
//                Ho = arrHoten.First();
//                for (int i = 0; i < arrHoten.Length; i++)
//                {
//                    Dem += arrHoten[i];
//                }
//            }           
//        }
//        public DateTime NgaySinh { get; set; }
//        public string Ho { get;private set; }
//        public string Dem { get;private set; }
//        public string Ten { get; private set; }
//        public Nguoi(int maSo, string Hoten, DateTime ngaySinh)
//        {
//            MaSo = maSo;
//            hoten = Hoten;
//            NgaySinh = ngaySinh;

//        }
//        public Nguoi()
//        {
//            Console.Write("Nhap ma so: ");
//            MaSo = int.Parse(Console.ReadLine());
//            Console.Write("Nhap Ho Ten: ");
//            HoTen = Console.ReadLine();
//            Console.Write("Nhap ngay sinh: ");
//            NgaySinh = DateTime.Parse(Console.ReadLine());           
//        }
//        public void InThongTin()
//        {
//            Console.WriteLine($"{MaSo} co ten la {HoTen} sinh ngay {NgaySinh}");
//        }
//        public void InHoTen()
//        {
//            Console.WriteLine($"{MaSo} co ten la {Ho} {Dem} {Ten} sinh ngay {NgaySinh}");
//        }
//    }
//}

//Nguoi ng= new Nguoi();
//Nguoi ng1 = new Nguoi(1,"Nguyen Thi A",new DateTime(2003,11,18));
//ng1.InThongTin();
//ng.InHoTen();