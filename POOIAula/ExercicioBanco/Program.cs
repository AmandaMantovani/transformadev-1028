namespace ExercicioBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente clienteEspecial = new("Amanda", "12345678911", 29);

            Gerente gerenteEspecial = new("Eduardo", "12345", new DateTime(1990, 10, 02), 1);
            Console.WriteLine(gerenteEspecial.Idade);

            gerenteEspecial.FazerAniversario();
            Console.WriteLine(gerenteEspecial.Idade);

            ContaBancaria contaClienteEspecial = new(1, clienteEspecial, gerenteEspecial);

            contaClienteEspecial.Sacar(10);
            contaClienteEspecial.Depositar(1000);

            contaClienteEspecial.Sacar(50);

            Gerente gerenteComum = new("Robson", "543241", new DateTime(1988, 01, 10), 1);
            contaClienteEspecial.AtribuirGerente(gerenteComum);



            contaClienteEspecial.AlterarAgenciaGerente(2, gerenteComum);
            Console.WriteLine(contaClienteEspecial.Gerente.Nome);
            Console.WriteLine(contaClienteEspecial.Agencia);
        }
    }
}