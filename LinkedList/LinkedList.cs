using System;

// Advantages over arrays
// 1) Dynamic size
// 2) Ease of insertion/deletion
namespace LinkedList
{
   public class LinkedList
    {
       public Node Head;
        public Node lastNode;

        public int Length = 0;

        public class Node{
          public  Node Next;
          public  int data;
          public  Node(int value){
                data = value;
            }
       
        }
        public void insertNode(int nodeData)  
        { 
            Node node = new Node(nodeData); 
            if (Head == null) 
            { 
               Head = node;
                Length++;
            }else{
                if(lastNode != null){
                    System.Console.WriteLine("inside lastNode");
                 lastNode.Next = node;
                Length++;
                }else{
                Node current = Head;
                while(current.Next != null){
                    current = current.Next;
                }
                current.Next = node;
                Length++;
                lastNode = current.Next;
            } }
        } 

       public static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.Head = null;
            // ll.Head = new Node(7);
            // Node node2 = new Node(3);
            // Node node3 = new Node(5);

            // ll.Head.Next = node2;
            // node2.Next = node3;

            ll.insertNode(1);
            ll.insertNode(2);
            ll.insertNode(3);

        //     Console.WriteLine(ll.Head.data);
        //     Console.WriteLine(ll.Head.Next.data);
        //     Console.WriteLine(ll.Head.Next.Next.data);
        //     System.Console.WriteLine("***************");
           ll.PrintIt();
           System.Console.WriteLine("**************");
           System.Console.WriteLine("***size={0}**",ll.Length);
           int val = ll.PrintReverse(ll.Head);
           if (val != -1){
                     System.Console.WriteLine(val);
                 }else{
                     System.Console.WriteLine("list is empty bro");
                 }
        }

        public void PrintIt(){
            Node current =  Head;
            while(current != null){
                System.Console.WriteLine(current.data);
                current = current.Next;
            }
        }

        public int PrintReverse(Node current){
            int val = -1;
            if(current != null){
                 val = PrintReverse(current.Next);
                 if (val != -1){
                     System.Console.WriteLine(val);
                 }
                 return current.data;
            }
            return val;
            
        }
    }
}
