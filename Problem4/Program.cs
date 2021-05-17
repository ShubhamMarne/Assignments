using System;

namespace Problem4
{
	class Algorithm
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" Enter size of array :  " + Environment.NewLine);
			string number = Console.ReadLine();
			int[] num = Algorithm.GenerateRandom(Convert.ToInt32(number));
			Console.WriteLine(" Original Array " + Environment.NewLine);
			Algorithm.Display(num);
			var num1 = num.Clone();


			// Normal bubble sort
			Algorithm.buubleSort(num);
			Console.WriteLine(Environment.NewLine + Environment.NewLine);

			// Improved version of bubble sort
			Algorithm.improvedBubbleSort((Int32[])num1);
			Console.ReadLine();
		}

		public static  void buubleSort(int[] num) {
			Console.WriteLine("****************************** Normal Bubble sort ****************************");
			int temp = 0;
			int pass = 0, counter = 0;

			for (int i = 0; i < num.Length; i++)
			{
				for (int s = 0; s < num.Length - 1; s++)
				{
					if (num[s + 1] > num[s])
					{
						temp = num[s];
						num[s] = num[s + 1];
						num[s + 1] = temp;
					}
					counter++;
				}
				pass++;
			}
			Console.WriteLine("Total Pass " + pass + "  Total Comparisons " + counter);
			Console.WriteLine("****************************************************************************");
			Algorithm.Display(num);
			Console.WriteLine("****************************************************************************");
		}


		public static void improvedBubbleSort(int[] num)
		{
			Console.WriteLine("****************************** Improved Bubble sort ****************************");
			bool flag = true;
			int temp = 0;
			int counter = 0, pass = 0;


			/**
			 *  Improvements : 
				1. Added flag to reduce number of comparison if further array is already sorted
				2. (num.Length - i) condition added in second for loop so that each phase iterations will be reduced.
				eg. : for 100 elements from second phase 99 comparisons, from third phase 98 comparisons, etc.
				To understand more please conside below example.
				Assume following array new int[8] { 85, 50, 45, 3, 63, 99, 88, 77};
				In this case total pass :6 and total comparison : 27 ......How ?
				first pass for 85, second pass for 50, third pass for 45, fourth pass for 3, fifth pass for 63, sixth pass for 99 
				after this we relialise everything in place(99,88,77) so no passes further.
				comparisons for 85 are 7, comparison for 50 are 6, comparisons for 45 are 5, comaprisons for 3 are 4, comparisons for 63 are 3 , comaprisons for 99 are 2 and end.
			 * */

			for (int i = 1; (i <= (num.Length - 1)) && flag; i++)
			{
				flag = false;
				for (int j = 0; j < (num.Length - i); j++)
				{
					if (num[j + 1] > num[j])
					{
						temp = num[j];
						num[j] = num[j + 1];
						num[j + 1] = temp;
						flag = true;
					}
					counter++;
				}
				pass++;
			}

			Console.WriteLine("Total Pass " + pass + "  Total Comparisons " + counter);
			Console.WriteLine("****************************************************************************");
			Algorithm.Display(num);
			Console.WriteLine("****************************************************************************");
		}

		/// <summary>
		/// This method will generate array of random numbers will size as number provided to method.
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public static int[] GenerateRandom(int number)
		{
			Random random = new Random();
			int[] result = new int[number];

			for (int i = 0; i < result.Length; i++)
			{
				int num = random.Next(1, number);
				result[i] = num;
			}
			return result;
		}

		/// <summary>
		/// Display numbers in array on console.
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
