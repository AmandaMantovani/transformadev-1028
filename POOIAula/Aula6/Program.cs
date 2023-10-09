namespace Aula6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new()
            {
                Condutor = "Motorista",
                Combustivel = "Alcool",
                CapacidadePassageiros = 5,
                VelocidadeMaxima = 260,
                CambioAutomatico = true,
                Direcao = "Eletrica",
                QuantidadePortas = 4
            };

            carro1.Imprimir();
            carro1.Acelerar();
            carro1.Freiar();
            Console.WriteLine();

            Aeronave aeronave1 = new()
            {
                Condutor = "Piloto",
                Combustivel = "Querosene",
                Altitude = 100000,
                CapacidadePassageiros = 300,
                Propulsao = "Jato",
                VelocidadeMaxima = 3500,                
            };

            aeronave1.Imprimir();
            aeronave1.Decolar();
            aeronave1.Voar();
            aeronave1.Pousar();
        }
    }
}