using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Início do main...");
        ConjuntoVO c1 = new ConjuntoVO(1, "c1");
        PontoVO p1 = new PontoVO();
        p1.incrementarCoordenadas(5, 2);
        p1.zerarCoordenadas();
        p1.incrementarCoordenadas(5, 2);
        c1.adicionar(p1);
        c1.listarPontos();
        p1.zerarCoordenadas();
        PontoVO p2 = new PontoVO();
        p2.incrementarCoordenadas(6, 9);
        p2.incrementarCoordenadas(5, 2);
        c1.adicionar(p2);
        c1.listarPontos();
        p2.zerarCoordenadas();
        Console.WriteLine("Fim do main...");
        PontoVO p3 = new PontoVO(2, 6);
        p3.imprimirCoordenadas();
        p3.incrementarCoordenadas(6, 9);
        p3.imprimirCoordenadas();
        p3.incrementarCoordenadas(5, 2);
        p3.imprimirCoordenadas();
        p3.zerarCoordenadas();
        PontoVO p4 = new PontoVO();
        p4.imprimirCoordenadas();
        p4.incrementarCoordenadas(6, 9);
        p4.imprimirCoordenadas();
        p4.incrementarCoordenadas(5, 2);
        p4.imprimirCoordenadas();
        p4.zerarCoordenadas();


        Console.WriteLine("c1" + c1.ToString());
    }
}