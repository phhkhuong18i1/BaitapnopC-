using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class tinhtong
    {
        int i = 1;
        int n = 0;
         
        public void tinh()
        {
            Console.WriteLine(" Nhap N =");
            this.n = Convert.ToInt32(Console.ReadLine());
        }
        public double tongla()
        {
            int s = 0;
            for (int i = 1; i <= n; i++) ;
            if (i % 2 == 0)
                s =s- i;
            else
                s =s+ i;
            return s;
        }
        public void In()
        {
            Console.WriteLine(" Tong la {0}", this.tongla());
        }
    }
}
    

