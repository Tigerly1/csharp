using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			//leapYear();
			//allNumbersSum();
			//permutation();
			weightFelek();
		}
		static void leapYear()
		{

			Console.WriteLine("Enter Year:");
			string yearString = Console.ReadLine();
			int YearNumber = Int32.Parse(yearString);
			if ((YearNumber % 4 == 0 && YearNumber % 100 != 0) || YearNumber % 400 == 0)
			{
				Console.WriteLine("rok jest przestępny");
			}
			else
			{
				Console.WriteLine("rok nie jest przestępny");
			}
			leapYear();
		}
		static void allNumbersSum()
		{
			Console.WriteLine("Enter Number:");
			string numberString = Console.ReadLine();
			int Number = Int32.Parse(numberString);
			int sum = 0;
			while (Number != 0)
			{
				sum += Number % 10;
				Number /= 10;
			}
			Console.WriteLine(sum);
			allNumbersSum();
		}
		static void permutation()
		{
			Console.WriteLine("Enter Number:");
			List<int> permutationNumbers = new List<int>();
			int numberOfElements = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Enter Numbers:");
			int[] arr = new int[numberOfElements];
			string[] s = Console.ReadLine().Split(' ');
			for (int a = 0; a < numberOfElements; a++)
			{
				permutationNumbers.Add(Int32.Parse(s[a]));
			}
			permutationNumbers.Sort();
			int i = 0;
			while (i + 1 != numberOfElements)
			{
				if(++i != permutationNumbers[i - 1])
				{
					Console.WriteLine("NIE");
					break;
				}
				if(i+1 == numberOfElements) Console.WriteLine("TAK");
			}
			permutation();
		}

		static void weightFelek()
		{
			Console.WriteLine("Enter Number:");
			List<int> WeightNumbers = new List<int>();
			int numberOfElements = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Enter Numbers:");
			int[] arr = new int[numberOfElements];
			string[] s = Console.ReadLine().Split(' ');
			for (int a = 0; a < numberOfElements; a++)
			{
				WeightNumbers.Add(Int32.Parse(s[a]));
			}
			
			int maxWeightLoss = 0;
			int actualMaxWeightLoss = 0;
			for (int a = 0; a < numberOfElements-1; a++)
			{

				if (WeightNumbers[a + 1] < WeightNumbers[a]) actualMaxWeightLoss += WeightNumbers[a] - WeightNumbers[a + 1];
				else if(WeightNumbers[a + 1] > WeightNumbers[a])
				{
					actualMaxWeightLoss = 0;
				}
				if (actualMaxWeightLoss > maxWeightLoss) maxWeightLoss = actualMaxWeightLoss;
			}
			Console.WriteLine(maxWeightLoss);
			weightFelek();
		}
	}
}
