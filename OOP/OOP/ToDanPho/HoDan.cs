//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OOP.ToDanPho;

//namespace OOP
//{
//    internal class HoDan
//    {
//        public int SoThanhVien { get; set; }
//        public int SoNha { get; set; }
//        List<Nguoi> lst= new List<Nguoi>();
//        public void nhapthongtin()
//        {
//            Console.Write("Nhap so thanh vien: ");
//            SoThanhVien = int.Parse(Console.ReadLine());
//            Console.Write("So Nha: ");
//            SoNha = int.Parse(Console.ReadLine());

//            Console.WriteLine("Nhap thong tin ho da");
//            for (int i = 0; i < SoThanhVien; i++)
//            {
//                Nguoi nguoi = new Nguoi();
//                lst.Add(nguoi);
//            }
//        }
//        public void inthongtin()
//        {
//            Console.WriteLine($"So nha: {SoNha}\nCo {SoThanhVien} nguoi\nThong Tin cac ho dan: \n");

//            for (int i = 0; i < lst.Count; i++)
//            {
//                lst[i].inthongtin();
//            }
//        }
//    }
//}


//HoDan hodan = new HoDan();
//hodan.nhapthongtin();
//Console.Write("\n");
//hodan.inthongtin();
