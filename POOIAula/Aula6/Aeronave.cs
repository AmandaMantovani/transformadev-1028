namespace Aula6
{
    public class Aeronave : Veiculo
    {
        public double Altitude { get; set; }
        public string Propulsao { get; set; }

        public Aeronave(string condutor, string combustivel, int capacidade, double velocidade,
            double altitude, string propulsao) : base(condutor, combustivel, capacidade, velocidade)
        {
            this.Altitude = altitude;
            this.Propulsao = propulsao;
        }

        public void Decolar()
        {
            Combustivel = "Gasolina";
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

        public void ImprimirAero()
        {
            base.Imprimir();
            //this. do pai
            Console.WriteLine($"Altitude: {this.Altitude}");
            Console.WriteLine($"Propulsão: {this.Propulsao}");
        }
    }
}
