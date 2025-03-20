namespace ProjetoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo obj1 = new Circulo(1, "c1", 2);


            Circulo obj2 = new Circulo(2, "c2", 4);


            Quadrado obj3 = new Quadrado(3, "c3", 4);
            Console.WriteLine(obj3.calcularArea());
            obj3.imprimirDados();
        }
    }
}
