using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo___Programacao_Orientada_Objetos.Heranca
{
    public class Square : ShapesClass
    {
        private int side = 0;
        public override int Area()
        {
            return side * side;
        }
    }
}
