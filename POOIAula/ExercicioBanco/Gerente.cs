using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    public class Gerente
    {
        public string Nome { get; private set; }
        public string Matricula { get; private set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; private set; }
        public int Agencia { get; set; }

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

        public Gerente(string nome, string matricula, DateTime dataNascimento, int agencia)
        {
            Nome = nome;
            Matricula = matricula;
            DataNascimento = dataNascimento;
            Idade = DateTime.Now.Year - dataNascimento.Year;
            Agencia = agencia;
        }

        public void FazerAniversario()
        {
            Idade++;
        }
    }
}
