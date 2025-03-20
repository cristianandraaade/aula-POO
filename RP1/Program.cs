using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

//Nome : Cristian Breno Andrade Marques
// RP1 enunciado do canvas
class Program
{
    //Versão do codigo sem o uso de modalização


    public static void Main()
    {
        int entrada, numeros, contador = 0, soma = 0, media, menor = 9999999, maior = 0;
        entrada = int.Parse(Console.ReadLine());
        do
        {
            numeros = int.Parse(Console.ReadLine());
            if (numeros > 0)
            {
                contador++;
                soma += numeros;
                if (numeros > maior)
                {
                    maior = numeros;
                }
                if (numeros < menor)
                {
                    menor = numeros;
                }
            }
        } while (numeros > 0);
        media = soma / contador;
        Console.WriteLine("Contador dos valores validos = " + contador);
        Console.WriteLine("Soma dos valores validos = " + soma);
        Console.WriteLine("Media dos valores = " + media);
        Console.WriteLine("Menor valor = " + menor);
        Console.WriteLine("Maior valor = " + maior);
    }

    // Versão do codigo com uso de modularização
    public static void Main(){
        int numeros, valor;
        char nao;
        NivelamentoHelper Rp1 = new NivelamentoHelper(int.MinValue, int.MaxValue);
        numeros = int.Parse(Console.ReadLine());
        do{
            do{
            valor = int.Parse(Console.ReadLine());
            if(valor > 0){
                Rp1.maiorValor(valor);
                Rp1.menorValor(valor);
                Rp1.conta();
                Rp1.somaValor(valor);
            }
            }while(valor > 0);
        Rp1.mediaValor();
        Rp1.imprimeValores();
        Console.WriteLine("Rodar outra vez || Digite N para parar e S pra continuar");
        nao = char.Parse(Console.ReadLine());
        }while((nao != 'N') && (nao != 'n'));
        Console.WriteLine("Deseja ver os dados?");
        Console.WriteLine("1 - Para ver o contador de valores validos");
        Console.WriteLine("2 - Para ver a soma dos valores");
        Console.WriteLine("3 - Para ver a media dos valores");
        Console.WriteLine("4 - Para ver o menor valor");
        Console.WriteLine("5 - Para ver o maior valor");
        int opcao = int.Parse(Console.ReadLine());
        switch (opcao){
            case 1:
                Console.WriteLine(Rp1.contador);
            break;
            case 2:
                Console.WriteLine(Rp1.soma);
            break;
            case 3:
                Console.WriteLine(Rp1.media);
            break;
            case 4:
                Console.WriteLine(Rp1.menorNumero);
            break;
            case 5:
                Console.WriteLine(Rp1.maiorNumero);
            break;
        }
    }
}
class NivelamentoHelper
{
    public int maiorNumero;
    public int menorNumero;
    public int soma;
    public float media;
    public int contador;

    public NivelamentoHelper(int menor, int maior){
        this.menorNumero = menor;
        this.maiorNumero = maior;
    }
    public void maiorValor(int valor){
        if (this.maiorNumero > valor)
            this.maiorNumero = valor;
    }
    public void menorValor(int valor){
        if (this.menorNumero < valor)
            this.menorNumero = valor;
    }
    public void conta(){
        this.contador+= 1;
    }
    public int somaValor(int valor){
        return this.soma += valor;
    }
    public void mediaValor(){
        this.media = this.soma / this.contador;
    }
    public void imprimeValores(){
        Console.WriteLine("Contador dos valores validos = " + this.contador);
        Console.WriteLine("Soma dos valores validos = " + this.soma);
        Console.WriteLine("Media dos valores = " + this.media);
        Console.WriteLine("Menor valor = " + this.menorNumero);
        Console.WriteLine("Maior valor = " + maiorNumero);
    }
}