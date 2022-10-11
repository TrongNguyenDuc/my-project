//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP
//{
//    internal class SoPhuc
//    {
//        public double PhanThuc { get; set; }
//        public double PhanAo { get; set; }


//        public SoPhuc(double phanThuc, double phanAo)
//        {
//            PhanThuc = phanThuc;
//            PhanAo = phanAo;
//        }

//        public SoPhuc()
//        {
//            Console.Write("phan thuc: ");
//            PhanThuc= double.Parse(Console.ReadLine());
//            Console.Write("phan ao: ");
//            PhanAo = double.Parse(Console.ReadLine());
//        }
//         public void In()
//        {
//            Console.WriteLine($"{PhanThuc} + {PhanAo}i");
//        }
//    }
//}


//SoPhuc sp = new SoPhuc();
//SoPhuc sp1 = new SoPhuc(3,5);
//sp.In();
//sp1.In();