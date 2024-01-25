using Exceptions.Interfaces;

namespace Exceptions.Classes
{
	public class FileNotFoundExceptionBlock : ICodeBlock
	{
		public void Execute()
		{
			Console.WriteLine($"Executing {nameof(FileNotFoundExceptionBlock)}");

			string fileName = "nonexistent.txt";
			try
			{
				// Attempting to access a nonexistent file
				string fileContents = File.ReadAllText(fileName);
			}
			catch (FileNotFoundException ex)
			{
				Console.WriteLine($"{nameof(FileNotFoundException)}: {ex.Message}");
			}
			finally
			{
				Console.WriteLine("Finally: \"closing\" file reader.");
			}
		}
	}
}