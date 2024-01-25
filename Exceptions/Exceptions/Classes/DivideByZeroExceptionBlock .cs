using Exceptions.Interfaces;

namespace Exceptions.Classes
{
	public class DivideByZeroExceptionBlock : ICodeBlock
	{
		public void Execute()
		{
			Console.WriteLine($"Executing {nameof(DivideByZeroExceptionBlock)}");

			int numerator = 10;
			int denominator = 0;
			try
			{
				// Attempting to divide by zero
				int result = numerator / denominator;
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine($"{nameof(DivideByZeroException)}: {ex.Message}");
			}
		}
	}
}