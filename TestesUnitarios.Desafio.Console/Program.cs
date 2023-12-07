using System;
using TestesUnitarios.Desafio.Console.Services;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando uma lista para aprende oque cada função faz;
            List<int> numeros = new List<int>();
            numeros = [-2,-3,4,6,10,-20];
            int num = 2;
            
            ValidacoesLista vald = new ValidacoesLista();
            List<int> resultado = vald.RemoverNumerosNegativos(numeros);
            bool resultado1 = vald.ListaContemDeterminadoNumero(numeros,num);
            List<int>  resultado2 = vald.MultiplicarNumerosLista(numeros,2);
            int resultado3 = vald.RetornarMenorNumeroLista(numeros);
            int resultado4 = vald.RetornarMaiorNumeroLista(numeros);



            // Usando e aprendendo oque cada metodo recebe e retorna
            Console.WriteLine("Lista sem números negativos: " + string.Join(", ", resultado));
            // Retorna False ou True dependendo se o numero procurado esta na lista;
            Console.WriteLine($"O numero {num} é {resultado1}");
            // Multiplica numeros da lista
            Console.WriteLine("Os numeros multiplicado ficam: " + string.Join(", ", resultado2));
            // Retorna Maior
            Console.WriteLine($"O meno numero é {resultado3}");
            // Retorna o Menor
            Console.WriteLine($"O Maior numero é {resultado4}");


            // ------------------------------Class Validação Strings --------------------------

            ValidacoesString valdL = new ValidacoesString();
            string texto = "Hello World!";
            int resultado5 = valdL.RetornarQuantidadeCaracteres(texto);
            bool resultado6 = valdL.ContemCaractere(texto,"H");
            bool resultado7 = valdL.TextoTerminaCom(texto,"!");

            Console.WriteLine($"A quantidade de caracteres na palavra {texto} é {resultado5}");
            Console.WriteLine($"A letra H esta em: {resultado6}");
            Console.WriteLine($"O texto termina com ! é:{resultado7}");



        }
    }
}