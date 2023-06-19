using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjDioDotNet.Models
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        private decimal Saldo;

        public ContaCorrente(int newNumero, decimal saldoInicial)
        {
            this.NumeroConta = newNumero;
            this.Saldo = saldoInicial;
        }

        public void Sacar(decimal valor)
        {
            if(Saldo >= valor)
            {
                Saldo-= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("valor desejado é maior do que vc tem na conta");
                Console.WriteLine($"Valor em conta {Saldo} Valor que voce tentou retirar {valor}");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é de : {Saldo}");
        }

    }
}