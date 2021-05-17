using System;
using System.Linq;

namespace Problem3
{
	class Algorithm
	{
		static void Main(string[] args)
		{
			int[] num = Algorithm.GenerateRandom();
			Console.WriteLine(" Original Array " + Environment.NewLine);
			Algorithm.Display(num);

			Console.WriteLine("What value you wanted to find : ");
			var value = Console.ReadLine();

			int intValue = 0;
			// Code for validation
			if (false == Int32.TryParse(value, out intValue) ||
				false == num.Contains(intValue))
			{
				Console.WriteLine("Invalid Input...");
				Console.WriteLine("Press Any key ...");
				Console.ReadLine();
				return;
			}

			// Get last occurance of number
			int result = NumOccuranceSearch(num, intValue);

			Console.WriteLine("Item " + intValue + " has last occurance at index : " + result);
			Console.WriteLine("Press Any key ...");
			Console.ReadLine();
		}

		/// <summary>
		/// Check number of occurance of search
		/// </summary>
		/// <param name="arr">Array</param>
		/// <param name="intValue">value need to search</param>
		/// <returns></returns>
		public static int NumOccuranceSearch(int[] arr, int intValue)
		{
			int result = -1;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == intValue)
				{
					result = i;
				}
			}
			return result;
		}

		// Generate random 100 number 
		public static int[] GenerateRandom()
		{
			Random random = new Random();
			int[] result = new int[100];

			for (int i = 0; i < result.Length; i++)
			{
				int num = random.Next(1, 75);
				result[i] = num;
			}
			return result;
		}

		/// <summary>
		/// Display numbers from array
		/// </summary>
		/// <param name="num"></param>
		public static void Display(int[] num)
		{
			for (int i = 0; i < num.Length; i++)
			{
				Console.Write(num[i] + "  ");
			}
			Console.WriteLine();
		}
	}
}
