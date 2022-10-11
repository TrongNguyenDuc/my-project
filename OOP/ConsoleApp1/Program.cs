using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Program
    {
        static int kytu(string lst ,string kytu )
        {

            int dem=0;
            lst = lst.Trim();
            while (lst.Contains("  "))
            {
                lst.Replace("  ", " ");
            }


            for (; lst.IndexOf(kytu) != -1;)
            {


                int tim_khoang_cat = lst.IndexOf(kytu);
                if (tim_khoang_cat != -1)
                {
                    dem++;
                    lst = lst.Substring(tim_khoang_cat+kytu.Length);
                    Console.WriteLine(lst);
                   
                }
            }
            return dem;
        }
        static void Main(string[] args)
        {
            Console.Write("nhap van ban: ");
            string lst = Console.ReadLine();
            Console.Write("nhap chu can dem: ");
            string kytu1 = Console.ReadLine();
            int dem = kytu(lst,kytu1);
            Console.WriteLine($"ky tu {kytu1} xuat hien {dem} lan");
            Console.ReadKey();
        }
    }
}