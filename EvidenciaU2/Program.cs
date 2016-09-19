using System;

namespace EvidenciaU2
{
	class MainClass
	{
		public static CFibonacci fibOne, fibTwo, fibThree;
		public static void Main (string[] args)
		{
			fibOne = new CFibonacci (0);
			fibTwo = new CFibonacci (1);
			fibThree = new CFibonacci (13);
		}
			
	}

	class CFibonacci
	{
		private int initNumber;
		public CFibonacci(int number)
		{
			initNumber = number;
			Console.WriteLine ("Numero {0}, {1} se encuentra en la serie Fibonacci", initNumber, isFibonacciNumberWithControlStructures(initNumber) ? "si" : "no");
		}

		static bool isFibonacciNumber(double number) 
		{
			double result = Math.Sqrt(5 * Math.Pow (number, 2) + 4);
			double resultTwo = Math.Sqrt (5 * Math.Pow (number, 2) - 4);
			return result%1 == 0 || resultTwo%1 == 0;
		}

		static bool isFibonacciNumberWithControlStructures(int number)
		{
			int pastFibonacciNumber = 0;
			int currentFibonacciNumber = 1;
			int swapNumber;
			bool isFibonacciNumber = number == pastFibonacciNumber || number == currentFibonacciNumber;

			while (currentFibonacciNumber <= number)
			{
				if (currentFibonacciNumber == number)
					isFibonacciNumber = true;
				swapNumber = currentFibonacciNumber;
				currentFibonacciNumber = pastFibonacciNumber + currentFibonacciNumber;
				pastFibonacciNumber = swapNumber;
			}

			return isFibonacciNumber;
		}
	}
}
