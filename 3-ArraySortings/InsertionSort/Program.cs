using SharedFunctions;
namespace InsertionSort
{
	internal class Program
	{
		static void InsertionSort(int[] arr)
		{
			for (int i = 1; i < arr.Length; i++)
			{
				int current = arr[i];
				int j = i - 1;
				while (j >= 0 && arr[j] > current)
				{
					arr[j + 1] = arr[j];
					j--;
				}

				arr[j + 1] = current;
			}
		}

		static void Main(string[] args)
		{
			int[] array = Operations.CreateArray();

			Operations.InputArray(array);
			Operations.PrintArray(array);

			InsertionSort(array);
			Operations.PrintArray(array);
		}
	}  
}
