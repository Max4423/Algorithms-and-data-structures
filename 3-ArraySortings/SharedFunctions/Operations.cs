namespace SharedFunctions
{
	public static class Operations
	{
		public static void PrintArray(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();
		}


		public static int[] CreateArray(int n = 0)
		{
			Console.Write("Input Array size: ");
			n = int.Parse(Console.ReadLine());

			int[] arr = new int[n];
			return arr;

		}
		public static void InputArray(int[] arr)
		{

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write($"Input {i + 1}-element: ");
				arr[i] = int.Parse(Console.ReadLine());
			}
		}

		public static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}

		static void Main(string[] args)
		{
		}
	}
}