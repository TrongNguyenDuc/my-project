using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoHoc
{
    class SohocController
    {
        List<SoHoc> danhsach= new List<SoHoc>();
        Random ran = new Random();
        public void TaoDuLieuMau(int n)
        {
            for (int i = 0; i < n; i++)
            {
                bool check = true;
                do
                {
                    int so = ran.Next(1, 1000);
                    int pos = danhsach.FindIndex(x=> x.Giatri==so);
                    if (pos == -1)
                    {
                        danhsach.Add(new SoHoc() { Giatri= so});
                    }
                    else check = false;
                    if (danhsach.Count == n) break;
                } while (!check);
            }
        }
        public void HienThi()
        {
            for (int i = 0; i < danhsach.Count; i++)
            {
                danhsach[i].hienthi();
            }
        }

    }
}
