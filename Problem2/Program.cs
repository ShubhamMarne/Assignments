using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
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

			Console.WriteLine("Which occurance you wanted to find : ");
			var occurance = Console.ReadLine();

			int intValue = 0;
			int intOccurance = 0;
			//Code for validation
			if (false == Int32.TryParse(value, out intValue) ||
				false == Int32.TryParse(occurance, out intOccurance) ||
				intOccurance > num.Length ||
				false == num.Contains(intValue))
			{
				Console.WriteLine("Invalid Input...");
				Console.WriteLine("Press Any key ...");
				Console.ReadLine();
				return;
			}


			int result = NumOccuranceSearch(num, intValue, intOccurance);

			string finalResult = (result == -1) ? "Not found " : result.ToString();
			Console.WriteLine("Item " + intValue + " has occurance " + intOccurance + " at index : "+ finalResult);
			Console.WriteLine("Press Any key ...");
			Console.ReadLine();
		}


		/// <summary>
		/// Check the index of occurance of number
		/// </summary>
		/// <param name="arr">Array</param>
		/// <param name="intValue">Value need to find</param>
		/// <param name="intOccurance">Occurance need to find</param>
		/// <returns></returns>
		public static int NumOccuranceSearch(int[] arr, int intValue, int intOccurance)
		{
			int occ = 0;
			int result = -1;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == intValue)
				{
					occ++;
					if (occ == intOccurance)
					{
						result = i;
						break;
					}
				}
			}
			return result;
		}

		/// <summary>
		/// Generate 100 Random number
		/// </summary>
		/// <returns></returns>
		public static int[] GenerateRandom()
		{
			Random random = new Random();
			int[] result = new int[100];

			for (int i = 0; i < result.Length; i++)
			{
				int num = random.Next(1, 80);
				result[i] = num;
			}
			return result;
		}

		/// <summary>
		/// Display numbers in array on console
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
