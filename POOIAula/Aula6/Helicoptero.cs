using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6
{
    public class Helicoptero : Aeronave
    {
        public Helicoptero(string condutor, string combustivel, int capacidade, double velocidade, double altitude, string propulsao) : base(condutor, combustivel, capacidade, velocidade, altitude, propulsao)
        {
        }
        
        /*
         * Mover não pode ser override por que o pai é metodo sealed
        public override void Mover()
        {
            Console.WriteLine("Movendo helicoptero");
        }
        */
    }
}
