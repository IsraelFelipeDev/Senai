using System;

namespace At8
{
	class Senai
	{
		public static void Main()
		{
			Console.Write("Digite o valor do produto: ");
			double preco= Convert.ToDouble(Console.ReadLine ());
			
			Console.Write("Digite o valor do desconto em porcentagem: ");
			double vlDescont = Convert.ToDouble(Console.ReadLine());
			
			double PrFinal = preco-(preco*(vlDescont/100));
			
			Console.WriteLine("O valor do desconto é: {0}%",vlDescont);
			Console.WriteLine("O valor do produto com desconto é: {0}",PrFinal);
			
			Console.ReadKey(true);
			
			                        
			
			
		}
	}
}