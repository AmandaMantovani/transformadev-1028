namespace Aula6
{
    public class Veiculo
    {
        private string condutor;
        public string Condutor
        {
            get
            {
                return condutor; 
            }
            set
            {
                condutor = value;
            }
        }

        protected string combustivel;
        public string Combustivel
        {
            get
            {
                return combustivel;
            }
            set
            {
                combustivel = value;
            }
        }

        public int CapacidadePassageiros { get; set; }
        public double VelocidadeMaxima { get; set; }
        
        public Veiculo(string condutor, string combustivel, int capacidade, double velocidade)
        {
            this.Condutor = condutor;
            this.Combustivel = combustivel;
            this.CapacidadePassageiros = capacidade;
            this.VelocidadeMaxima = velocidade;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Condutor: {this.Condutor}");
            Console.WriteLine($"Combustível: {this.Combustivel}");
            Console.WriteLine($"Capacidade Passageiros: {this.CapacidadePassageiros}");
            Console.WriteLine($"Velocidade máxima: {this.VelocidadeMaxima}km/h");
        }

        public virtual void Mover()
        {
            Console.WriteLine("Estou movimentando o veiculo - classe pai");
        }

        public virtual void Parar()
        {
            Console.WriteLine("Estou parando o veiculo - classe pai");
        }

        public void RemoverMotor()
        {
            Console.WriteLine("Removendo motor");
        }
    }
}
