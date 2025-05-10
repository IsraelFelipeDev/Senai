//número da
//casa, rua, bairro, cidade e estado.

using System;

namespace At10
{
	class Senai 
	{
		public static void Main()
		{
			Console.WriteLine("Digite a cidade onde mora: ");
			string Cidade = Console.ReadLine();
			
			Console.WriteLine(" Digite o estado onde mora: ");
			string Est = Console.ReadLine();
			
			Console.WriteLine("Digite o seu bairro: ");
			string Bairro = Console.ReadLine();
			
			Console.WriteLine("Digite sua rua: ");
			string Rua = Console.ReadLine();
			
			Console.WriteLine("Digite o Nº da sua residencia: ");
			string Num = Console.ReadLine();
			
			Console.WriteLine(" A cidade onde voce mora é {0}, no estado {1}, no bairro {2}, na rua {3}, e o numero da sua residencia é {4}.",Cidade,Est,Bairro,Rua,Num);
			
			Console.ReadKey(true);
			
		}
	}
}
	
