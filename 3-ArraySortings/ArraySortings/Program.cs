using SharedFunctions;
using System.Collections.Immutable;
using System;
namespace ArraySortings
{
    internal class Program
    {

        static void BubbleSort(int[] arr)
		{
			for (int i = 0; i < arr.Length - 1; i++)
			{
				for (int j = 0; j < arr.Length - 1 - i ; j++)
				{
					if (arr[j] > arr[j+1])
					{
						Operations.Swap(ref arr[j], ref arr[j+1]);
					}
				}
			}
		}
		static void Main(string[] args)
        {
			int[] array = Operations.CreateArray();

			Operations.InputArray(array);
            Operations.PrintArray(array);

			BubbleSort(array);
			Operations.PrintArray(array);
		}
    }
}
