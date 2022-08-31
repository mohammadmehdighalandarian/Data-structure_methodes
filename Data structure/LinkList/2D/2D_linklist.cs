using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_structure.LinkList._2D;

namespace Data_structure.LinkList
{
    public class _2D_linklist
    {
        private _2DNode firstNode = null;

        public void AddToFirst(_2DNode node)
        {
            if (firstNode==null)
            {
                firstNode=node;
            }
            else
            {
                firstNode.NextNode=node;
                node.PrewNode=firstNode;
                node.NextNode=firstNode;
                firstNode.PrewNode=node;

                firstNode = node;
            }
        }

        public void AddLast(_2DNode node)
        {
            

            if (firstNode==null)
            {
                firstNode = node;
            }
            else
            {
                _2DNode Head = firstNode;

                while (Head.NextNode != null)
                {
                    Head = Head.NextNode;
                }

                Head.NextNode = node;
                node.PrewNode=Head;
                node.NextNode = firstNode;
            }
            
        }

        public void AddToIndex(int index, _2DNode node)
        {
            _2DNode Head = firstNode;

          
            int nodenumber = 1;

            while (nodenumber < index)
            {
                Head = Head.NextNode;
                nodenumber++;
            }

            Head.NextNode = node;
            node.NextNode = Head.NextNode;
            (Head.NextNode).PrewNode=node;
            node.PrewNode= Head;
        }


        public void RemoveIndex(int index)
        {
            _2DNode Head = firstNode;

            
            int nodenumber = 1;

            while (nodenumber < index)
            {
                Head = Head.NextNode;
                nodenumber++;
            }

            (Head.PrewNode).NextNode = Head.NextNode;
            (Head.NextNode).PrewNode=Head.PrewNode;
            
        }

        public void Print()
        {
            _2DNode Head = firstNode;

            while (Head.NextNode!= null)
            {
                Console.WriteLine(Head.Data);
                Head = Head.NextNode;
            }
        }
    }
}
