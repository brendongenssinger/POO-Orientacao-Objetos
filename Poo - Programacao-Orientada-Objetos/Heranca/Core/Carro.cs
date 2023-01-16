using Poo___Programacao_Orientada_Objetos.Heranca.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo___Programacao_Orientada_Objetos.Heranca.Core
{
    public class Carro : AutomoveisAbstract
    {
        public override void Abastecer()
        {
            Console.WriteLine("Carro abastace GASOLINA/AlCOOL");
        }

        public override void Desligar()
        {
            Console.WriteLine("Desligando Carro ");
        }
        public override void Ligar()
        {
            Console.WriteLine("Ligando pelo botão !");
        }
    }
}
