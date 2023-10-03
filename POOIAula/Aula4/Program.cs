namespace Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno teste = new(8);
            teste.Nome = "Amanda";
            teste.Matricula = "1234";
            teste.RegistrarNota(10);

        }
    }
}