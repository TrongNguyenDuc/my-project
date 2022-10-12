using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace SoHoc 
{
    internal class Program
    {
        static void Main()
        {
            SohocController shctr = new SohocController();
            shctr.TaoDuLieuMau(10);
            shctr.HienThi(Loaiso.Tatca);
            Console.WriteLine("\n");
            shctr.HienThi(Loaiso.Sochan);
            Console.WriteLine("\n"); 
            shctr.HienThi(Loaiso.Songuyento);
            Console.ReadKey();
        }
    }
}