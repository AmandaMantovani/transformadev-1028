using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    public class Aluno
    {
        public string Matricula { get; set; }
        public string Sobrenome { get; set; }
        public string AnoEscolar { get; set; } = "Primeiro Ano";
        public double Nota1 { get; } = 10;
        public double Nota2 { get; private set; }

        public Aluno(double nota1)
        {
            Nota1 = nota1;
        }

        //encapsulamento com propriedade
        private string nome;
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value.Length > 0)
                {
                    nome = value;
                }
            }
        }

        //encapsulamento com método
        public void RegistrarNota(double nota)
        {
            //Nota1 = nota; não existe set, propriedade readonly
            Nota2 = nota;
        }



    }
}
