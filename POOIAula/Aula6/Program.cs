namespace Aula6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new("Motorista", "Alcool", 5, 260, true, 4, "Eletrica");

            carro1.Imprimir();
            carro1.Acelerar();
            carro1.Freiar();
            Console.WriteLine();

            
            Aeronave aeronave1 = new("Piloto", "Querosene", 100000, 300, 3500, "Jato");

            aeronave1.ImprimirAero();
            aeronave1.Decolar();
            aeronave1.Voar();
            aeronave1.Pousar();

        }
    }
}