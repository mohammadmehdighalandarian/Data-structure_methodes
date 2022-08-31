using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure.LinkList._2D
{
    public class _2DNode
    {
        public int  Data { get; set; }
        public _2DNode NextNode { get; set; }
        public _2DNode PrewNode { get; set; }

        public _2DNode(int data)
        {
            Data = data;
            NextNode = null;
            PrewNode = null;
        }
    }
}
