using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListApp
{
    public class DList<E>
    {
        private DNode<E> header, trailer;
        private int size;

        public DList()
        {
            header = new DNode<E>(null, default, null);
            trailer = new DNode<E>(header, default, null);
            header.Next = trailer;
        }

        public int Size()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size <= 0;
        }

        public E First()
        {
            return header.Next.Element;
        }

        public E Last()
        {
            return trailer.Prev.Element;
        }
    }
}
