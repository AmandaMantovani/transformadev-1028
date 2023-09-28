namespace Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello, World!");
            double resultado = Somar(5, 8);

            Console.WriteLine(resultado);

            Pessoa pessoa = new()
            {
                nome = "Anderson",
                idade = 25
            };

            pessoa.ImprimirDadosPessoa();

            Console.WriteLine($"Area calculada: {CalcularAreaCirculo(30)}");
            */
            //Calculadora calculadora = new();

            //Console.WriteLine("Digite o valor 1:");
            //calculadora.numero1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor 2:");
            //calculadora.numero2 = double.Parse(Console.ReadLine());

            //Calculadora calculadora = new()
            //{
            //    numero1 = valor1,
            //    numero2 = valor2
            //};

            Console.WriteLine("Digite o valor 1:");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 2:");
            double valor2 = double.Parse(Console.ReadLine());

            Calculadora calculadora1 = new();
            Calculadora calculadora2 = new(valor1);
            Calculadora calculadora3 = new(valor1, valor2);

            Console.WriteLine(Calculadora.Somar(new List<double>()
            {
                1,
                2,
                5,
                8
            }));

            double? resultado = calculadora.Dividir();

            Console.WriteLine((resultado ?? 0) > 0 ? resultado : "Não foi possivel calcular");
        }

        /* Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina.
         * Cada objeto dessa classe deve guardar os seguintes dados do aluno:
         * matrícula, nome, 2 notas de prova e 1 nota de trabalho.
         * Construa os seguintes métodos para esta classe:
         * métodos construtores,
         *  registrar nota de cada prova e trabalho,
         *   calcula a média final do aluno (cada prova tem peso 2,5 e o trabalho tem peso 2).
         * Teste na main, se atente para o que precisar ser public, private, parametros, retornos.. 
        */
        
        /// <summary>
        /// Realiza uma soma
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns>Retorna o valor somado</returns>
        public static double Somar(double numero1, double numero2)
        {
            double resultadoSoma = numero1 + numero2;
            return resultadoSoma;
        }

        public static double CalcularAreaCirculo(double raio)
        {
            double resultado = Math.PI * Math.Pow(raio, 2);
            return resultado;
        }

    }
}