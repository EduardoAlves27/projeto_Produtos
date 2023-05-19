using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_products
{
    public class Login
    {
        public bool Logado { get; set; }


        public Login()
        {
            //Logica      
            Usuario user = new Usuario();


            //Validar
            Logar(user);

            if (Logado)
            {
                GerarMenu();
            }
        }

        public void Logar(Usuario usuario)
        {

            usuario.Cadastrar();
            //Logica 
            Console.Clear();
            Console.WriteLine($"Insira seu email: ");
            string email = Console.ReadLine();

            Console.WriteLine($"Insira sua senha: ");
            string senha = Console.ReadLine();

            if (email == usuario.Email && senha == usuario.Senha)
            {
                this.Logado = true;

                Console.WriteLine($"Login efetuado com sucesso !");
            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Falha ao logar !");
            }


        }

        public void Deslogar()
        {
            Logado = false;
        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string loop;

            do
            {
                Console.WriteLine(@$"
            [1] - Cadastrar Produto
            [2] - Listar Produtos
            [3] - Remover Produto
            ----------------------
            [4] - Cadastrar Marca
            [5] - Listar Marcas
            [6] - Remover Marca

            [0] - Sair
            ");

                loop = Console.ReadLine();

                switch (loop)
                {
                    case "1":
                        //cadastrar
                        produto.Cadastrar();
                        break;
                    case "2":
                        //listar
                        produto.Listar();
                        break;
                    case "3":
                        //remover
                        Console.WriteLine($"Informe o código a ser removido: ");
                        int codigoProduto = int.Parse(Console.ReadLine());

                        produto.Deletar(codigoProduto);
                        break;
                    case "4":
                        //cadastrar
                        marca.CadastroMarca();
                        break;
                    case "5":
                        //listar
                        marca.Listar();
                        break;
                    case "6":
                        //remover
                        Console.WriteLine($"Informe o código a ser removido: ");
                        int codigoMarca = int.Parse(Console.ReadLine());

                        marca.Deletar(codigoMarca);
                        break;
                    case "0":
                        //sair
                        Console.WriteLine($"App encerrado !");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine($"Opção inválida!");
                        break;
                }
            } while (loop != "0");

        }


    }
}