using System;
using System.Collections.Generic;

namespace Problem1
{
	class Algorithm
	{
		static void Main(string[] args)
		{
			int[] num = Algorithm.GenerateRandom();
			Console.WriteLine(" Original Array " + Environment.NewLine);
			Algorithm.Display(num);
			Console.WriteLine("How many maximum values you wanted to find in this array : ");
			var input = Console.ReadLine();
			int inputValue = 0;
			if (false == Int32.TryParse(input, out inputValue) ||
				inputValue > num.Length) {
				Console.WriteLine("Invalid Input...");
				Console.WriteLine("Press Any key ...");
				Console.ReadLine();
				return;
			}

			int temp = 0;
			// Logic to sort the array
			for (int i = 0; i < num.Length; i++)
			{
				for (int s = 0; s <  num.Length - 1; s++)
				{
					if (num[s] > num[s+ 1])
					{
						temp = num[s+ 1];
						num[s+  1] = num[s];
						num[s] = temp;
					}
				}
			}

			List<int> result = new List<int>();
			// after sorting push max values to list
			for (int i = (num.Length - 1); i >= (num.Length - inputValue); i--)
			{
				 result.Add(num[i]);
			}

			Console.WriteLine(inputValue + " maximum values are : ");
			Algorithm.Display(result.ToArray());
			Console.WriteLine("Press Any key ...");
			Console.ReadLine();
		}

		/// <summary>
		/// Generate 100 random numbers from 1 to 1000
		/// </summary>
		/// <returns></returns>
		public static int[] GenerateRandom()
		{
			Random random = new Random();
			int[] result = new int[100];

			for (int i = 0; i < result.Length; i++)
			{
				int num = random.Next(1, 1000);
				result[i] = num;
			}
			return result;
		}

		/// <summary>
		/// Display numbers
		/// </summary>
		/// <param name="num"></param>
		public static void Display(int[] num)
		{
			for (int i = 0; i < num.Length; i++)
			{
				Console.Write(num[i]  + "  ");
			}
			Console.WriteLine();
		}
	}
}
