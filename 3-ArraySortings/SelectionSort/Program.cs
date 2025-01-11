using SharedFunctions;
namespace ShellSort
{
	internal class Program
	{
		static void ShellSort(int[] arr)
		{
			int gap = arr.Length / 2;
			while (gap > 0)
			{

			for (int i = gap; i < arr.Length; i++)
			{
				int current = arr[i];
				int j = i;
				while (j >= gap && arr[j - gap] > current)
				{
					arr[j] = arr[j - gap];
					j-= gap;
				}

				arr[j] = current;
			}

			gap /= 2;
			}

		}
		static void Main(string[] args)
		{
			int[] array = Operations.CreateArray();

			Operations.InputArray(array);
			Operations.PrintArray(array);

			ShellSort(array);
			Operations.PrintArray(array);
		}
	}
}
