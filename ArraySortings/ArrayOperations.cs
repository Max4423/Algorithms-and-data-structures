using System;

namespace Functions
{
	static class Class1
	{
		static void PrintArray(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();
		}
	}
}