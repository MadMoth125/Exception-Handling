using Exceptions.Interfaces;

namespace Exceptions.Classes
{
	public class NullReferenceExceptionBlock : ICodeBlock
	{
		public void Execute()
		{
			Console.WriteLine($"Executing {nameof(NullReferenceExceptionBlock)}");

			string nullString = null;
			try
			{
				// Attempting to access the Length property of a null string
				int length = nullString.Length;
			}
			catch (NullReferenceException ex)
			{
				Console.WriteLine($"{nameof(NullReferenceException)}: {ex.Message}");
			}
		}
	}
}