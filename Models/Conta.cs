using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjDioDotNet.Models
{
    public abstract class Conta
    {
        protected decimal saldo; //protected igual private, porém permite que classes filhas alterem valor


        public abstract void Creditar(decimal valor); // abstract obriga a classe filha que herdar a colocar um comportamnto

        public void ExibirSaldo()
        {
            Console.WriteLine("O seu sado é: " + saldo);
        }
    }
}