using Exceptions.Classes;
using Exceptions.Interfaces;

namespace Exceptions
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			// List	of code	blocks
			var	codeBlocks = new List<ICodeBlock>
			{
				new	NullReferenceExceptionBlock(),
				new	DivideByZeroExceptionBlock(),
				new	FileNotFoundExceptionBlock(),
				new OddNumberExceptionBlock(),
				// Add more	blocks if needed
			};

			// Execute code	blocks
			foreach	(var codeBlock in codeBlocks)
			{
				codeBlock.Execute();

				// Wait 1 second before executing the next block
				await Task.Delay(1000);

				// Add blank lines between each block's output
				Console.WriteLine("\n");
			}

			// Wait for user input before exiting
			Console.ReadKey();
		}
	}
}