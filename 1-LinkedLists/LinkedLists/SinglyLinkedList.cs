using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LinkedLists
{
	internal class SinglyLinkedList
	{
		private Node Head;

		public SinglyLinkedList()
		{
			Head = null;
		}

		public void AddNode(int data)
		{
			var newNode = new Node(data);

			if (Head == null)
			{
				Head = newNode;
				return;
			}

			var current = Head;

			while (current.Next != null)
			{
				current = current.Next;
			}
			current.Next = newNode;

		}

		public void RemoveNode(int data)
		{
			if (Head == null)
			{
				return;
			}
			if (Head.Data == data)
			{
				Head = Head.Next;
				return;
			}
			var current = Head;
			while (current.Next != null)
			{
				if (current.Next.Data == data)
				{
					current.Next = current.Next.Next;
					return;
				}
				current = current.Next;
			}
		}

		public void Swap(int position1, int position2)
		{
			if (position1 == position2)
				return;

			Node prev1 = null;
			var curr1 = Head;

			for (int i = 0; i < position1 && curr1 != null; i++)
			{
				prev1 = curr1;
				curr1 = curr1.Next;
			}

			Node prev2 = null;
			var curr2 = Head;
			for (int i = 0; i < position2 && curr2 != null; i++)
			{
				prev2 = curr2;
				curr2 = curr2.Next;
			}

			if (curr1 == null || curr2 == null)
				return;

			if (prev1 != null)
				prev1.Next = curr2;
			else
				Head = curr2;

			if (prev2 != null)
				prev2.Next = curr1;
			else
				Head = curr1;

			var temp = curr1.Next;
			curr1.Next = curr2.Next;
			curr2.Next = temp;
		}


		public void Display()
		{
			var current = Head;
			while (current != null)
			{
				Console.WriteLine(current.Data);
				current = current.Next;
			}
		}
	}
}
