namespace BalancedBrackets
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Please insert the string containing the brackets sequence");
			var input = Console.ReadLine();

			while (!Utils.IsInputValid(input))
			{
				Console.WriteLine("This is not a valid input. Make sure you onl enter ()[]{} characters!");
				input = Console.ReadLine();
			}

			if (Utils.AreBracketsBalanced(input)) 
				Console.WriteLine("Balanced");
			else
				Console.WriteLine("Not Balanced");
			
			Console.ReadKey();
		}
	}
}
