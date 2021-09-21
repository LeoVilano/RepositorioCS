using System;

namespace Course02
{
    class Program
    {
        static void Main(string[] args)
        {        
                        
            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new(nome,preco,quantidade);            

            Console.WriteLine();
            Console.WriteLine("Ddados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionados:");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizado:" + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removidos:");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine("Dados atualizado:" + p);


        }
    }
}
