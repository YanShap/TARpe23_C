namespace Homework_w2_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			AskUser();
		}
		public static void AskUser() 
		{
			List<string> words = new List<string>();
			Console.WriteLine("input 3 words");
			words.Add(Console.ReadLine());
			words.Add(Console.ReadLine());
			words.Add(Console.ReadLine());
			words.Sort();
			foreach (string i in words)
			{
				Console.WriteLine(i);
			}








		}
	}
}