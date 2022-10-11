//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP
//{
//    internal class SoThuc
//    {
//        private double gt;
//        public double GiaTri 
//        { 
//            get => gt;
//            set
//            {
//                if (GiaTri>0)
//                {
//                    LaSoDuong = true;
//                }
//                else
//                {
//                    LaSoDuong = false;
//                }
//            } 
//        }
//        public bool LaSoDuong { get; private set; }
//        public static SoThuc

//        public SoThuc()
//        {
//            GiaTri = double.Parse(Console.ReadLine());
//        }
//        public double canbacn(int n)
//        {
//            double can= Math.Pow(GiaTri, n);
//            return can;
//        }

//        public static SoThuc Timmax(SoThuc a,SoThuc b,SoThuc c)
//        {
//            if (a.GiaTri>=b.GiaTri&& a.GiaTri>=c.GiaTri)
//            {
//                return a;
//            }
//            else if (b.GiaTri>=a.GiaTri&& b.GiaTri>=c.GiaTri)
//            {
//                return b;
//            }
//            else
//            {
//                return c;
//            }
//        }
        
//    }
//}
