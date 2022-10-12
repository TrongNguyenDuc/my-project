using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoHoc
{
    internal class SoHoc
    {
        private int gt;
        public int Giatri
        {
            get { return gt; }

            set
            {
                gt = value;
                thuoctinh();
            }
        }
        public bool LaSoChan { get; private set; }
        public bool LaSONT { get; private set; }
        public bool LaSoDoiXung { get; private set; }
        public void hienthi()
        {
            Console.Write($"{gt} ");
        }

        private bool sochan()
        {
            if (gt % 2==0)
            {
                return true;
            }
            return false;
        }
        private bool songuyeto()
        {
            if (gt < 1) return false;
            else if (gt == 2|| gt == 3|| gt == 5) return true;
            else if (gt % 2==0) return false;
            else
            {
                for (int i = 3; i <= gt / 2 ; i+=2)
                {
                    if (gt % i==0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        private bool sodoixung()
        {
            int tam = 0;
            while (gt > 0)
            {
                tam = tam * 10 + gt % 10;
                gt /= 10;
                return true;
            }
            return false;
        }
        private void thuoctinh()
        {
            LaSoChan = sochan();
            LaSONT = songuyeto();
            LaSoDoiXung = sodoixung();
        }
    }
}
