using System;

namespace Calculator
{
    class Calculator {
		public static double DoOperation(double num1, double num2, string op)
		{
			double result = double.NaN; 
			
			switch (op)
			{
				case "a":
					result = num1 + num2;
					break;
				case "s":
					result = num1 - num2;
					break;
				case "m":
					result = num1 * num2;
					break;
				case "d":
					if (num2 != 0)
					{
						result = num1 / num2;
					}
					break;
				default:
					break;
			}
			return result;
		}
	}
	
	class Program {
		static void Main(string[] args)
		{
			bool endApp = false;
			Console.WriteLine("Konsolowy kalkulator w języku C#\r");
			Console.WriteLine("------------------------\n");

			while (!endApp)
			{
				string numInput1 = "";
				string numInput2 = "";
				double result = 0;
				
				Console.Write("Podaj liczbę, a następnie wciśnij Enter: ");
				numInput1 = Console.ReadLine();

				double cleanNum1 = 0;
				while (!double.TryParse(numInput1, out cleanNum1))
				{
					Console.Write("To nie jest poprawna wartość. Proszę wprowadź liczbę całkowitą: ");
					numInput1 = Console.ReadLine();
				}
				
				Console.Write("Wpisz inną liczbę, a następnie wciśnij Enter: ");
				numInput2 = Console.ReadLine();

				double cleanNum2 = 0;
				while (!double.TryParse(numInput2, out cleanNum2))
				{
					Console.Write("To nie jest poprawna wartość. Proszę wprowadź liczbę całkowitą: ");
					numInput2 = Console.ReadLine();
				}
				
				Console.WriteLine("Wybierz operację z poniższej listy:");
				Console.WriteLine("\ta - Dodawanie");
				Console.WriteLine("\ts - Odejmowanie");
				Console.WriteLine("\tm - Mnożenie");
				Console.WriteLine("\td - Dzielenie");
				Console.Write("Opcja wybrana przez Ciebie? ");

				string op = Console.ReadLine();

				try
				{
					result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
					if (double.IsNaN(result))
					{
						Console.WriteLine("Ta operacja będzie skutkować blędem matematycznym.\n");
					}
					else Console.WriteLine("Twój wynik: {0:0.##}\n", result);
				}
				catch (Exception e)
				{
					Console.WriteLine("O nie! W trakcie obliczeń pojawił się wyjątek.\n - Details: " + e.Message);
				}

				Console.WriteLine("------------------------\n");
				
				Console.Write("Wciśnij 'n' i Enter aby zamknąć aplikację, lub wciśnij każdy inny klawisz i Enter aby kontynuować: ");
				if (Console.ReadLine() == "n") endApp = true;

				Console.WriteLine("\n"); 
			}
			return;
		}
	}
}