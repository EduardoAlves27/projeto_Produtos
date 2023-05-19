using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_products
{
    public class Usuario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public DateTime DataCadastro { get; set; }

        public Usuario()
        {
            Cadastrar();
        }


        public void Cadastrar()
        {
            this.Nome = "Dudu";
            this.Email = "teste";
            this.Senha = "1";
            this.DataCadastro = DateTime.Now;
        }


        public void Deletar()
        {
            this.Nome = "Dudu";
            this.Email = "teste";
            this.Senha = "1";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }









    }
}