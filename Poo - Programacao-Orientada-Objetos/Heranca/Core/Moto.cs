using Poo___Programacao_Orientada_Objetos.Heranca.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo___Programacao_Orientada_Objetos.Heranca.Core
{
    public class Moto : AutomoveisAbstract
    {
        public override void Abastecer()
        {
            Console.WriteLine("Moto abastace GASOLINA/AlCOOL");
        }

        public override void Desligar()
        {
            Console.WriteLine("Desligando Moto ");
        }        
    }
}
