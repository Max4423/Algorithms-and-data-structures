using SharedFunctions;
namespace SelectSort
{
	internal class Program
	{
		static void SelectionSort(int[] arr)
		{
			for (int i = 0; i < arr.Length - 1; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[i] > arr[j])
					{
						Operations.Swap(ref arr[i], ref arr[j]);
					}
				}
			}

		}
		static void Main(string[] args)
		{
			int[] array = Operations.CreateArray();

			Operations.InputArray(array);
			Operations.PrintArray(array);

			SelectionSort(array);
			Operations.PrintArray(array);
		}
	}
}
