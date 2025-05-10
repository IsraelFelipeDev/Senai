using System;

namespace at4
{
	class Senai
	{
		static void Main()
		{
			Console.WriteLine(" Digite sim ou não: ");
			string resposta=Console.ReadLine();
			
			bool ValBool;
			
			if(resposta == "sim")
			{
				ValBool = true;
				
			}
			
			else if(resposta == "nao" || "não")
			{
				ValBool = true;
				
			}
			
			else
			{
				Console.WriteLine("O valor digitado não satisfaz, opção invalida tente novamente.");
				ValBool = true;
			}
			
			Console.Write("O valor armazenado na variavel foi: " + ValBool);
			Console.ReadKey(true);
			
			
		}
	}
}