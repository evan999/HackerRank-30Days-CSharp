using System;
class Node
{
	public int data;
	public Node next;
    public Node(int d){
        data=d;
        next=null;
    }
		
}
class Solution {

	public static  Node insert(Node head,int data)
	{
      //Complete this method
      
      if (head == null)
      {
          //head = new Node(data);
          return new Node(data);
      }
      else
      {
          head.next = insert(head.next, data);
      }

      return head;

      //Node trav = head;
      /*
      if(head.next == null)
      {
          //head.next = new Node(data);
          head.next = new Node(data);

          //Console.WriteLine("New node: " + trav);
      }
      else
      {
          head = head.next;         
      }
      */
      
      
      /*
      while (head.next != null)
      {
          head = head.next;
          //Console.WriteLine("Head: " + head.data);
      }
      */
      
      
      //head = trav;

      

      /*
      while (trav.next != null)
      {
          trav = trav.next;
          //Console.WriteLine("Trav: " + trav.data);          
      }
      
      /*
      if (trav.next == null)
      {
          trav.next = new Node(data);
          //Console.WriteLine("Head.next.data: " + head.next.data);
          trav = trav.next;
      }
      */
    }
	public static void display(Node head)
	{
		Node start=head;
		while(start!=null)
		{
			Console.Write(start.data+" ");
			start=start.next;
		}
	}
    static void Main(String[] args) {
	
		Node head=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            head=insert(head,data);
        }
		display(head);
	}
}