using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
	internal class DoublyNode
	{
		public int Data { get; set; }
		public DoublyNode Next { get; set; }
		public DoublyNode Previous { get; set; }

		public DoublyNode(int data)
		{
			Data = data;
			Next = null;
			Previous = null;
		}
	}
}
