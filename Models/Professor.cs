using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjDioDotNet.Models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }

        public Professor(string nome) : base(nome)
        {
            
        }

        public Professor()
        {
            
        }


        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é { Nome} minha idade é {Idade} e meu salario é {Salario}");
        }

    }
}