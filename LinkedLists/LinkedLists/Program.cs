namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
			SinglyLinkedList list = new SinglyLinkedList();
            list.AddNode(1);
			list.AddNode(2);
            list.AddNode(3);
			list.AddNode(4);
            list.Display();

            list.RemoveNode(3);
			Console.WriteLine("-----------------------------------------------------");
			list.Display();

			Console.WriteLine("-----------------------------------------------------");
			list.Swap(0, 2);
			list.Display();

			Console.WriteLine("-----------------------------------------------------");
			Console.WriteLine("Doubly linked lists:");


			DoublyLinkedList doublyList = new DoublyLinkedList();

			doublyList.AddNode(1);
			doublyList.AddNode(2);
			doublyList.AddNode(3);
			doublyList.AddNode(4);
			doublyList.AddNode(5);
			doublyList.Display();

			doublyList.RemoveNode(3);
			Console.WriteLine("-----------------------------------------------------");
			doublyList.Display();

			Console.WriteLine("-----------------------------------------------------");
			doublyList.SwapByData(1, 5);
			doublyList.Display();



		}
	}
}
