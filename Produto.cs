using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_products
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string NomeProduto { get; set; }

        public float Preco { get; set; }

        public DateTime DataCadastro { get; set; }

        public Marca Marca = new Marca();

        public Usuario CadastroPor { get; set; }

        List<Produto> ListaDeProduto = new List<Produto>();

        public void Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Digite o Codigo do Produto");
            novoProduto.Codigo = int.Parse(Console.ReadLine()); // ENTRADA E ARMAZENAMENTO NA LISTA

            Console.WriteLine($"Digite o Nome do Produto");
            novoProduto.NomeProduto = Console.ReadLine(); // ENTRADA E ARMAZENAMENTO NA LISTA

            Console.WriteLine($"Preco do Produto");
            novoProduto.Preco = float.Parse(Console.ReadLine()); // ENTRADA E ARMAZENAMENTO NA LISTA

            novoProduto.DataCadastro = DateTime.Now;

            novoProduto.Marca = Marca.CadastroMarca(); // CHAMAR METODO DO CADASTRO DA MARCA

            novoProduto.CadastroPor = new Usuario(); //METODO CONSTRUTOR

           ListaDeProduto.Add(novoProduto);



        }

        public void Listar()
        {
            foreach (var item in ListaDeProduto)
            {
                Console.WriteLine($"CODIGO:{item.Codigo}");
                Console.WriteLine($"NOME DO PRODUTO:{item.NomeProduto}");
                Console.WriteLine($"PRECO:{item.Preco}");
                Console.WriteLine($"DATA DO CADASTRO:{item.DataCadastro}");
                
            }
                
        }

        public void Deletar(int _codigo)
        {


        }




    }
}