using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinema
{
    public class SinemaKoltuk
    {
       public  LinkedList l = new LinkedList();
        public SinemaKoltuk()
        {
            for (int i = 1; i <= 60; i++)
            {
                Musteri m = new Musteri();
                m.KoltukNo = i;
                l.InsertLast(m);
            }
        }
}
}
