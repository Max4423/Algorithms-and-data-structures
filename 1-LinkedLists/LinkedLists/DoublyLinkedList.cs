using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
	internal class DoublyLinkedList
	{
		private DoublyNode Head;

		public DoublyLinkedList()
		{
			Head = null;
		}

		public void AddNode(int data)
		{
			var newNode = new DoublyNode(data);
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
			newNode.Previous = current;
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
				Head.Previous = null;
				return;
			}
			var current = Head;
			while (current != null)
			{
				if (current.Data == data)
				{
					current.Previous.Next = current.Next;

					if (current.Next != null)
					{
						current.Next.Previous = current.Previous;
					}
					return;
				}
				current = current.Next;
			}
		}


		public void SwapByData(int data1, int data2)
		{
			var node1 = FindNode(data1);
			var node2 = FindNode(data2);

			if (node1 == null || node2 == null)
				return;

			// Обмін посилань на попередні вузли
			var tempPrev = node1.Previous;
			node1.Previous = node2.Previous;
			node2.Previous = tempPrev;

			// Обмін посилань на наступні вузли
			var tempNext = node1.Next;
			node1.Next = node2.Next;
			node2.Next = tempNext;

			// Обмін посилань на сусідні вузли
			if (node1.Previous != null)
				node1.Previous.Next = node1;
			else
				Head = node1;

			if (node2.Previous != null)
				node2.Previous.Next = node2;
			else
				Head = node2;

			if (node1.Next != null)
				node1.Next.Previous = node1;
			if (node2.Next != null)
				node2.Next.Previous = node2;
		}

		// Метод для пошуку вузла за значенням
		private DoublyNode FindNode(int data)
		{
			var current = Head;
			while (current != null)
			{
				if (current.Data == data)
					return current;
				current = current.Next;
			}
			return null;
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
