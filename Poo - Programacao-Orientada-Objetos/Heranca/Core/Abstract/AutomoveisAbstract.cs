using Poo___Programacao_Orientada_Objetos.Heranca.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo___Programacao_Orientada_Objetos.Heranca.Core.Abstract
{
    public abstract class AutomoveisAbstract : IAutomoveis
    {
        public abstract void Abastecer();
        public abstract void Desligar();
        public virtual void Ligar()
        {
            Console.WriteLine("Ligando na chave");
        }

    }
}
