//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP
//{
//    internal class PhanSo
//    {
//        public int TuSo {  get; set; }
//        public int MauSo { get; set; }

//        public void LayPhanSo()
//        {
//            Console.WriteLine($"Phan So: {TuSo}/{MauSo}");
//        }

//        public void ToiGianPhanSo()
//        {
//            int a = Math.Abs(TuSo);
//            int b=Math.Abs(MauSo);
//            while (a!= b)
//            {
//                if (a>b)
//                {
//                    a -= b;
//                }
//                else if (a<b)
//                {
//                    b -= a;
//                }
//            }
//            TuSo /= a;
//            MauSo /= b;
//        }

//        public PhanSo CongPhanSo(PhanSo phanSo)
//        {
//            PhanSo ketqua = new PhanSo(0,0);
//            ketqua.TuSo = phanSo.TuSo * MauSo + phanSo.MauSo * TuSo;
//            ketqua.MauSo = MauSo * phanSo.MauSo;
//            ketqua.ToiGianPhanSo();
//            return ketqua;
//        }

//        public PhanSo TruPhanSo(PhanSo phanso)
//        {
//            PhanSo ketqua = new PhanSo(0,0);
//            if (TuSo * phanso.MauSo == MauSo * phanso.TuSo)
//            {
//                return ketqua;
//            }
//            else
//            {
//                ketqua.TuSo = phanso.TuSo * MauSo- phanso.MauSo * TuSo;
//                ketqua.MauSo = MauSo * phanso.MauSo;
//                ketqua.ToiGianPhanSo();
//                return ketqua;
//            }
//        }

//        public PhanSo(int tuSo, int mauSo)
//        {
//            TuSo = tuSo;
//            MauSo = mauSo;
//        }


//        public PhanSo()
//        {
//            Console.Write("Nhap Tu so: ");
//            TuSo = int.Parse(Console.ReadLine());
//            Console.Write("Nhap Mau so ");
//            MauSo=int.Parse(Console.ReadLine());
//        }
//    }
//}



//PhanSo ps = new PhanSo();
//PhanSo ps1 = new PhanSo(1, 4);
//ps.LayPhanSo();
//ps1.LayPhanSo();
//PhanSo ketqua = ps.CongPhanSo(ps1);
//ketqua.LayPhanSo();
//PhanSo ketqua1 = ps.TruPhanSo(ps1);
//ketqua1.LayPhanSo();
