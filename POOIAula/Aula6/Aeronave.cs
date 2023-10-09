namespace Aula6
{
    public class Aeronave : Veiculo
    {
        public double Altitude { get; set; }
        public string Propulsao { get; set; }

        public void Decolar()
        {
            Console.WriteLine("Decolando a aeronave");
        }

        public void Pousar()
        {
            Console.WriteLine("Pousando a aeronave");
        }

        public void Voar()
        {
            Console.WriteLine("Estamos voando!!!");
        }
    }
}
