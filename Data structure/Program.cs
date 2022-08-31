//Link List (single)

using Data_structure;
using Data_structure.LinkList;
using Data_structure.LinkList._2D;

singly_linked_list linkedList=new singly_linked_list();
linkedList.AddToFirst(new Node1(10));
linkedList.AddToLast(new Node1(30));
linkedList.Remove();
linkedList.PrintLinkList();



//*****2D_linklist****

_2D_linklist linkedList2D = new _2D_linklist();
 linkedList2D.AddToFirst(new _2DNode(10));
linkedList2D.AddLast(new _2DNode(30));
linkedList2D.AddToIndex(2,new _2DNode(20));
linkedList2D.Print();


Console.ReadKey();