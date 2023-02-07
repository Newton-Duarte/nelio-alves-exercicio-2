using System.Globalization;

namespace Exercicio2
{
  class Program
  {
    static void Main(string[] args)
    {
      // System.Console.WriteLine("----------Exercício 1: É negativo ou não negativo----------");
      // System.Console.WriteLine("Digite um número qualquer");
      // int n1 = int.Parse(Console.ReadLine());

      // if (n1 < 0)
      // {
      //   System.Console.WriteLine("NEGATIVO");
      // }
      // else
      // {
      //   System.Console.WriteLine("NÃO NEGATIVO");
      // }

      // System.Console.WriteLine("----------Exercício 2: É par ou ímpar----------");
      // System.Console.WriteLine("Digite um número qualquer");

      // int n2 = int.Parse(Console.ReadLine());

      // if (n2 % 2 == 0)
      // {
      //   System.Console.WriteLine("PAR");
      // }
      // else
      // {
      //   System.Console.WriteLine("ÍMPAR");
      // }

      // System.Console.WriteLine("----------Exercício 3: É número negativo----------");
      // System.Console.WriteLine("Digite o primeiro número");
      // int a = int.Parse(Console.ReadLine());

      // System.Console.WriteLine("Digite o segundo número");
      // int b = int.Parse(Console.ReadLine());

      // if (a % b == 0 || b % a == 0)
      // {
      //   System.Console.WriteLine("São Múltiplos");
      // }
      // else
      // {
      //   System.Console.WriteLine("Não são múltiplos");
      // }

      // System.Console.WriteLine("----------Exercício 4: Calcule a duração----------");
      // System.Console.WriteLine("Digite a hora inicial");
      // const int HORA_MAXIMA = 24;

      // int horaInicial = int.Parse(Console.ReadLine());

      // System.Console.WriteLine("Digite a hora final");
      // int horaFinal = int.Parse(Console.ReadLine());

      // int duracao = HORA_MAXIMA - horaInicial + horaFinal;
      // int totalHoras = 0;

      // if (duracao > 24)
      // {
      //   totalHoras = (HORA_MAXIMA - horaInicial + horaFinal) - HORA_MAXIMA;
      // }
      // else
      // {
      //   totalHoras = (HORA_MAXIMA - horaInicial + horaFinal);
      // }

      // System.Console.WriteLine($"O JOGO DUROU: {totalHoras} HORA(S)");

      // System.Console.WriteLine("----------Exercício 5: Calcule o valor total----------");
      // System.Console.WriteLine("CODIGO----------ITEM----------PREÇO");
      // System.Console.WriteLine("1----------Cachorro Quente----------R$ 4,00");
      // System.Console.WriteLine("2----------X-Salada----------R$ 4,50");
      // System.Console.WriteLine("3----------X-Bacon----------R$ 5,00");
      // System.Console.WriteLine("4----------Torrada simples----------R$ 2,00");
      // System.Console.WriteLine("5----------Refrigerante----------R$ 1,50");
      // System.Console.WriteLine("Informe o código do item");
      // int codigo = int.Parse(Console.ReadLine());

      // System.Console.WriteLine("Informe a quantidade do item");
      // int quantidade = int.Parse(Console.ReadLine());

      // double total = 0;

      // if (codigo == 1)
      // {
      //   total = quantidade * 4;
      // }
      // else if (codigo == 2)
      // {
      //   total = quantidade * 4.5;
      // }
      // else if (codigo == 3)
      // {
      //   total = quantidade * 5;
      // }
      // else if (codigo == 4)
      // {
      //   total = quantidade * 2;
      // }
      // else {
      //   total = quantidade * 1.5;
      // }

      // System.Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

      System.Console.WriteLine("----------Exercício 6: Informe o intervalo----------");
      System.Console.WriteLine("Digite um número");
      double intervalo = double.Parse(Console.ReadLine());

      if (intervalo >= 0 && intervalo <= 25)
      {
        System.Console.WriteLine("Intervalo [0,25]");
      }
      else if (intervalo <= 50)
      {
        System.Console.WriteLine("Intervalo [25,50]");
      }
      else if (intervalo <= 75)
      {
        System.Console.WriteLine("Intervalo [50,75]");
      }
      else if (intervalo <= 100)
      {
        System.Console.WriteLine("Intervalo [75,100]");
      }
      else {
        System.Console.WriteLine("Fora de intervalo");
      }
    }
  }
}