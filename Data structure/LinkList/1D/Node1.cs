using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure
{
    public class Node1
    {
        public int Data { get; set; }
        public Node1 Next { get; set; }     
        public Node1(int data)
        {
            Data=data;
            Next=null;
        }
    }
}
