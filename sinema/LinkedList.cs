using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinema
{
    public class LinkedList : ListADT
    {
        public override string InsertPos(int position,Musteri value)
        {
            string temp = "";
           
            Node posNode = Head;
            Node tempNext=null;
            while(posNode!=null)
            {
                if(position==posNode.Data.KoltukNo)
                {
                    tempNext = posNode;
                    if (tempNext.Data.AdSoyad == null)
                    {
                        tempNext.Data.AdSoyad = value.AdSoyad;
                        temp +=tempNext.Data.KoltukNo+"."+"Koltuk alındı";
                    }
                    else
                        temp = "Koltuk dolu";
                    break;
                }
                posNode = posNode.Next;
                
            }
            return temp;
            
        }
        public override string DeletePos(int position,Musteri value)
        {
            string temp = "";
            Node tempNode = Head;
            Node lastNode = null;
            while(tempNode!=null)
            {
                if(tempNode.Data.KoltukNo==position)
                {
                    lastNode = tempNode;
                    if (tempNode.Data.AdSoyad != null)
                    {
                        tempNode.Data.AdSoyad = null;
                        temp += tempNode.Data.KoltukNo + "." + "Koltuk iptal edildi";
                    }
                    else
                    {
                        temp = "Koltuk zaten boş";
                        InsertPos(position, value);
                    }
                    break;
                }
              
                tempNode = tempNode.Next;
            }
            return temp;
        }

        public override string GetElement(Musteri value)
        {
         
            string temp = "";
            Node retNode = null;
            Node tempNode = Head;
            while(tempNode!=null)
            {
                if (tempNode.Data.AdSoyad == value.AdSoyad)
                {
                    retNode = tempNode;
                    temp += tempNode.Data.AdSoyad + " " +
                          tempNode.Data.KoltukNo + ".Koltuktadır";
                    break;
                }
               
                tempNode = tempNode.Next;
            }
            if (tempNode.Data.AdSoyad != value.AdSoyad)
            {
                temp = "böyle bir müşteri yoktur";
               
            }
            return temp;   
        }

        public override void InsertFirst(Musteri value)
        {
            Node tmpHead = new Node
            {
                Data = value
            };
            if (Head == null)
                Head = tmpHead;
            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }
            Size++;
        }

        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp +=item.Data.KoltukNo+"-"+item.Data.AdSoyad+"    ";
                item = item.Next;
            }

            return temp;
        }

        public override void InsertLast(Musteri value)
        {
            Node oldLast = Head;

            if (Head == null)
                InsertFirst(value);
            else
            {
                Node newLast = new Node
                {
                    Data = value
                };
                while (oldLast != null)
                {
                    if (oldLast.Next != null)
                        oldLast = oldLast.Next;
                    else
                        break;
                }
                oldLast.Next = newLast;
                Size++;
            }
        }

        public override void DeleteFirst()
        {
            if (Head != null)
            {
                Node tempHeadNext = this.Head.Next;
                if (tempHeadNext == null)
                    Head = null;
                else
                    Head = tempHeadNext;
                Size--;
            }
        }
        public string DoluKoltuklar()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                if(item.Data.AdSoyad!=null)
                {
                    temp += item.Data.KoltukNo + "-Dolu ";
                }
                else
                {
                    temp += item.Data.KoltukNo + "- ";
                }
                item = item.Next;
            }

            return temp;
        }
        public string BosKoltuklar()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                if (item.Data.AdSoyad == null)
                {
                    temp += item.Data.KoltukNo + "- ";
                }
                item = item.Next;
            }

            return temp;
        }
      
    }
}
