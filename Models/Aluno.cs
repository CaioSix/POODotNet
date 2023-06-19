using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjDioDotNet.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public Aluno()
        {
            
        }

        public Aluno(string nome) : base(nome)
        {
            
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Ola meu nome é {Nome} e tenho {Idade} e sou um aluno nota {Nota}");
        }
    }
}