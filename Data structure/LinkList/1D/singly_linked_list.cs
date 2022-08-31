using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Data_structure
{
    public class singly_linked_list
    {

        private Node1 First=null;  //Point To First Node
        public void AddToFirst(Node1 node)
        {
            if (First == null)
            {
                First=node;
            }
            else
            {
                node.Next=First;
                First=node;
            }
        }

        public void AddToLast(Node1 node)
        {
            if (First == null)
            {
                First = node;
            }
            else
            { 
                Node1 Pointer=First;
                while (Pointer.Next!=null)
                {
                    Pointer = Pointer.Next;
                }
                Pointer.Next = node;
            }
        }

        public void Remove()     //Always We Remove From First Of list
        {
            if (First == null) 
            {
                Console.WriteLine("The Link list Is Empty");
                return;
            }
            First = First.Next;
        }

        public void PrintLinkList()
        {
            Node1 Pointer = First;
            while (Pointer!=null)
            {
                Console.WriteLine($"{Pointer.Data} -> ");
                Pointer = Pointer.Next;
            }
        }
    }
}
