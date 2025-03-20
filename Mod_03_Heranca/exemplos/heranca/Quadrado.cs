/*Nome Completo: Cristian Breno Andrade Marques
Data (dd/MM/yyy): 19/03/2025
Conteúdo trabalhado: herança de objetos*/
namespace ProjetoHeranca;
internal class Quadrado : Figura
{
    private int lado;

    public Quadrado(int codigo, string descricao, int lado) : base(codigo, descricao)
    {
        this.lado = lado;
    }
    public override double calcularArea()
    {
        return lado * lado;
    }
    public override void imprimirDados(){
        base.imprimirDados();
        Console.WriteLine("Área: " + this.calcularArea());
    }
}