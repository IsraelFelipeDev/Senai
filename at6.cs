
using System;

namespace at8
{
	

	class Program
	{
    	static void Main()
   		{
        // Solicita o preço do produto
        Console.Write("Digite o preço do produto: R$ ");
        double precoProduto = double.Parse(Console.ReadLine());

        // Solicita o percentual de desconto
        Console.Write("Digite o percentual de desconto: ");
        double percentualDesconto = double.Parse(Console.ReadLine());

        // Calcula o valor do desconto
        double valorDesconto = precoProduto * (percentualDesconto / 100);

        // Calcula o preço final com o desconto
        double precoFinal = precoProduto - valorDesconto;

        // Exibe o valor do desconto e o preço final
        Console.WriteLine("Valor do desconto: R$ {0}",valorDesconto);
        Console.WriteLine("Preço final com desconto: R$ {1}",precoFinal);
        
        Console.ReadKey(true);
       
    	}
   }
}