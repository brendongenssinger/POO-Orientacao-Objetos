using Poo___Programacao_Orientada_Objetos.Heranca;
using Poo___Programacao_Orientada_Objetos.Heranca.Core;
using Poo___Programacao_Orientada_Objetos.Heranca.Core.Interfaces;

namespace Poo___Programacao_Orientada_Objetos
{
    public class Class1
    {
        public static void ExecuteMethods()
        {
            // Class Abstract
            ShapesClass square = new Square();
            square.Area();


            //Interfaces
            IAutomoveis carro = new Carro();
            carro.Abastecer();
            carro.Desligar();
            carro.Ligar();

            //Interfaces
            IAutomoveis moto = new Moto();
            moto.Abastecer();
            moto.Desligar();
            moto.Ligar();

        }

       
    }
}
