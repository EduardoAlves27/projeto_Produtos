using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_products
{
    public class Marca
    {
        public int Codigo { get; set; }

        public string NomeMarca { get; set; }

        public DateTime DataCadastro { get; set; }

        public static List<Marca> listaDeMarca = new List<Marca>();


        public Marca CadastroMarca()
        {
            Marca novaMarca = new Marca();

            Console.WriteLine($"CODIGO DA MARCA:");
            int codigo = int.Parse(Console.ReadLine());

            novaMarca = listaDeMarca.Find(x => x.Codigo == codigo);

            if (novaMarca == null)
            {
                novaMarca = new Marca();
                novaMarca.Codigo = codigo;
                Console.WriteLine($"NOME DA MARCA:");
                novaMarca.NomeMarca = Console.ReadLine();
                novaMarca.DataCadastro = DateTime.Now;

                listaDeMarca.Add(novaMarca);

                return novaMarca;
            }

            else
            {
                Console.WriteLine($"Marca ja existente");
                return novaMarca;
                
            }
        }

        public void Listar()
        {
            foreach (var item in listaDeMarca)
            {
                
            }
        }

        public void Deletar(int _codigo)
        {

        }



    }
}