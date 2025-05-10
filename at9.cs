using System;

namespace At9
{
	class Senai
	{
		public static void Main()
		{
			Console.Write("Digite uma palavra: ");
			string palavra= Console.ReadLine();
			
			Console.WriteLine(" Esta palavra possui {0} caracteres.", palavra.Length);
			// Palavra (variavel que recebeu o a palavra do usuario),Length(tradução em portugues comprimento, comando usado para contar os caracteres.
			Console.ReadKey(true);
			
		}
	}
}