using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal class Tamagotchi
    {
        //atributos
        public string nome { get; set; }
        public int sono { get; set; }
        public float quilos { get; set; }
        public int entediado { get; set; }
        public int idade { get; set; }

        public Tamagotchi(string nome)
        {
            this.nome = nome;
            int sono = 0;
            int quilos = 1;
            int entediado = 0;
            int idade = 0;
        }
        public override string ToString()
        {
            return "\n---------------------------\n" + nome + " esta com:\n" + idade + " dias de idade\nPesando " + quilos + "Kg\n---------------------------\n";
        }
    }
}
