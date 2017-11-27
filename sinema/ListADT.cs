using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinema
{
    public abstract class ListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void InsertFirst(Musteri value);
        public abstract void InsertLast(Musteri value);
        public abstract string InsertPos(int position,Musteri value);
        public abstract void DeleteFirst();
        public abstract string DeletePos(int position,Musteri value);
        public abstract string GetElement(Musteri value);
        public abstract string DisplayElements();
    }
}
