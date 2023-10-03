using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    public class ContaBancaria
    {
        public long Numero { get; }
        public int Agencia { get; private set; }
        public Cliente Cliente { get; }
        /*
        private Gerente gerente;
        public Gerente Gerente
        {
            get
            {
                return gerente;
            }
            set
            {
                if (Agencia != value.Agencia)
                {
                    Console.WriteLine("Gerente não atribuido devido divergencia entre agencias");
                    return;
                }

                gerente = value;
            }
        }*/

        public Gerente Gerente { get; private set; }

        private double Saldo { get; set; }

        public ContaBancaria(int agencia, Cliente cliente, Gerente gerente)
        {
            Numero = new Random().Next(9999);
            Cliente = cliente;
            Agencia = agencia;
            Gerente = gerente;
        }

        public void AlterarAgenciaGerente(int agencia, Gerente gerente)
        {
            if (VerificarAgenciaGerente(agencia, gerente))
            {
                Agencia = agencia;
                Gerente = gerente;
            }
        }

        public void AtribuirGerente(Gerente gerente)
        {
            if (VerificarAgenciaGerente(this.Agencia, gerente))
            {
                Gerente = gerente;
            }
        }

        public bool VerificarAgenciaGerente(int agencia, Gerente gerente)
        {
            if (agencia != gerente.Agencia)
            {
                Console.WriteLine("Gerente não atribuido devido divergencia entre agencias");
                return false;
            }

            return true;
        }

        public void Depositar(double valorDeposito)
        {
            if (valorDeposito <= 0)
            {
                Console.WriteLine("Valor do depósito não permitido");
                return;
            }

            Saldo += valorDeposito;
            ImprimirSaldo();
        }

        public void Sacar(double valorSaque)
        {
            if (Saldo < valorSaque)
            {
                Console.WriteLine("Saldo insuficiente para saque");
                ImprimirSaldo();
                return;
            }

            Saldo -= valorSaque;
            ImprimirSaldo();
        }
        
        public void ImprimirSaldo()
        {
            Console.WriteLine($"Saldo atual em conta de R${Saldo}");
        }

    }
}
