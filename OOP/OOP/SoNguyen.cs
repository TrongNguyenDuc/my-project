//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP
//{
//    internal class SoNguyen
//    {
//        private int giatri;
//        public int GiaTri 
//        {
//            get { return giatri; }
//            set
//            {
//                giatri = value;
//                LaSoChan = KiemTraChan();
//                LaSoDoiXung = KiemTraDoiXung();
//                LaSoNguyenTo = KiemTraNguyenTo();
//            }
//        }
//        public bool LaSoChan { get; set; }
//        public bool LaSoNguyenTo { get; set; }
//        public bool LaSoDoiXung { get; set; }

//        private bool KiemTraChan()
//        {
//            if (GiaTri%2==0)
//            {
//                return true;
//            }
//            return false;
//        }
//        private bool KiemTraNguyenTo()
//        {
//            int dem = 0;
//            for (int i = 2; i < Math.Sqrt(GiaTri);i++)
//            {
//                if (GiaTri % i==0)
//                {
//                    dem++;
//                }
//            }
//            if (dem == 0) return true;
//            return false;
//        }
//        private bool KiemTraDoiXung()
//        {
//            int doixung = 0, so=GiaTri;
//            do
//            {
//                doixung = so % 10 + doixung * 10;
//                so /= 10;
//            } while (so != 0);
//            if(doixung== so) return true;
//            return false;
//        }
//        public void In()
//        {
//            Console.Write($"So {GiaTri} ");
//            if (LaSoChan) 
//            {
//                Console.Write("la so chan ");
//            }
//            if (LaSoNguyenTo)
//            { 
//                Console.Write("la so nguyen to "); 
//            }
//            if (LaSoDoiXung) 
//            { 
//                Console.Write("la so doi xung "); 
//            } 
//        }
//        public int Cong(SoNguyen so) => GiaTri + so.giatri;
//        public int NhapSo()
//        {
//            bool check;
//            int so;
//            do
//            {
//                Console.Write("Nhap So: ");
//                check = int.TryParse(Console.ReadLine(), out so);
//                if (!check)
//                {
//                    Console.WriteLine("Day Khong Phai La So: ");
//                }

//            } while (!check);
//            return so;
//        }       
//        public SoNguyen()
//        {
//            GiaTri = NhapSo();
//        }
//        public SoNguyen(int so)
//        {
//            GiaTri = so;
//        }
//    }
//}


//SoNguyen sn = new SoNguyen();
//SoNguyen sn1 = new SoNguyen(223);
//sn.In();
//sn1.In();
//int kq = sn.Cong(sn1);
//Console.Write($"Tong 2 so nguyen: {kq}");