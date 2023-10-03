using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }

        private string cpf;
        public string Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                if (value.Count() == 11)
                {
                    cpf = value;
                }
                else
                {
                    Console.WriteLine("CPF não atribuido, valor diferente de 11");
                }
            }
        }

        public Cliente(string nome, string cpf, int idade)
        {
            this.Nome = nome;
            Cpf = cpf;
            Idade = idade;
        }

        public void FazerAniversario()
        {
            Idade++;
        }
    }
}
