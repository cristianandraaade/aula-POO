using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHeranca
{
    internal class Retangulo:Figura
    {
        private double comprimento;
        private double altura;

        public Retangulo(int codigo, string descricao, double comprimento, double altura) : base(codigo, descricao)
        {
            this.comprimento = comprimento;
            this.altura = altura;   
        }


        public override double calcularArea()
        {
            return (comprimento*altura);
        }
        public override void imprimirDados()
        {
            base.imprimirDados();
            Console.Write("\nComprimento: " + comprimento+" \nAltura: "+altura);
        }
    }
}
