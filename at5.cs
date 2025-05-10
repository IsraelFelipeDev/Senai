using System;

namespace at5
{
	class Senai
	{
		static void Main()
		{
			char letra;
			
			Console.WriteLine("Digite uma letra: ");
			letra=char.Parse(Console.ReadLine());
			
			Console.WriteLine(" A letra digita é: "+ letra);
			
			Console.ReadKey(true);
		}
	}
}