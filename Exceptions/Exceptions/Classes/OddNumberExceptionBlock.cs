using Exceptions.Exceptions;
using Exceptions.Interfaces;

namespace Exceptions.Classes
{
	public class OddNumberExceptionBlock : ICodeBlock
	{
		private readonly Random _randomValue = new Random();
		private const int _minValueRange = 1;
		private const int _maxValueRange = 100;

		public void	Execute()
		{
			Random randomValue = new Random();

			Console.WriteLine($"Executing {nameof(OddNumberExceptionBlock)}");
			try
			{
				// Generating a random odd number
				int number = _randomValue.Next(_minValueRange, _maxValueRange);

				// Ensuring that the number is odd before checking
				// (lil bit of flare to the exception)
				number = (number % 2 == 0) ? number + 1 : number;

				if (number % 2 != 0)
				{
					throw new OddNumberException($"{nameof(OddNumberException)}: Odd number ({number}) is not allowed.");
				}
			}
			catch (OddNumberException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}