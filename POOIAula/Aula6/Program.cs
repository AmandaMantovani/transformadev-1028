namespace Aula6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //virtual + override sempre respeita o override. se for filho, passa no filho, se pai, passa no filho.
            //override sobrepõe o pai, portanto sempre vai ser ele o método invocado.

            //new respeita a classe. se for filho, passa no filho, se pai, passa no pai.
            //new cria um novo método e não sobrepõe o pai.

            Carro carro1 = new("Motorista", "Alcool", 5, 260, true, 4, "Eletrica");

            carro1.Imprimir();
            carro1.Mover();
            carro1.Parar();
            Console.WriteLine();

            Aeronave aeronave1 = new("Piloto", "Querosene", 100000, 300, 3500, "Jato");

            aeronave1.Imprimir(); // imprime filho

            aeronave1.Decolar();
            aeronave1.Voar();
            aeronave1.Pousar();
            aeronave1.Mover();
            aeronave1.Parar();

            List<Veiculo> veiculos = new();
            veiculos.Add(carro1);
            veiculos.Add(aeronave1);

            Helicoptero heli = new("Piloto", "Querosene", 100000, 300, 3500, "Jato");
            heli.Mover();

            Console.WriteLine("\n\ninicio foreach");
            foreach (var veic in veiculos)
            {
                veic.Mover();
                veic.Imprimir(); // imprime pai
            }
        }
    }
}