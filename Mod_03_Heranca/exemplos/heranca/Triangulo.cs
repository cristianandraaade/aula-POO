using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHeranca
{
    internal class Triangulo: Figura
    {
        private double comprimento;
        private double altura;

        public Triangulo() { }

        public override double calcularArea()
        {
            return (comprimento*altura/2);
        }
        public override void imprimirDados()
        {
            base.imprimirDados();
            Console.Write("\nComprimento: " + comprimento + " \nAltura: " + altura);
        }
    }
}
