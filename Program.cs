using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("========================");
      Console.WriteLine("Bem vindo a calculadora!");
      Console.WriteLine("========================");

      Console.WriteLine("Qual operação deseja realizar?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("5 - Sair");

      Console.WriteLine("========================");
      Console.WriteLine("Selecione uma opçao: ");
      string selecao = Console.ReadLine();
      short opcao;

      if (!short.TryParse(selecao, out opcao))
      {
        Console.WriteLine("Opção inválida, tente novamente!");
        Console.ReadKey();
        Menu();
      }


      switch (opcao)
      {
        case 1:
          Soma();
          break;
        case 2:
          Subtracao();
          break;
        case 3:
          Divisao();
          break;
        case 4:
          Multiplicacao();
          break;
        case 5:
          Sair();
          break;
        default:
          Menu();
          break;
      }

    }
    static void Sair()
    {
      Console.WriteLine("Saindo da aplicação! Até mais!");
      Environment.Exit(0);
    }
    static void Soma()
    {
      //Usado para limpar a tela do terminal
      Console.Clear();

      Console.WriteLine("-------- SOMA --------");
      Console.WriteLine("Primeiro valor: ");
      string input1 = Console.ReadLine();
      float valor1;

      if (!float.TryParse(input1, out valor1))
      {
        Console.WriteLine("Entrada inválida para o primeiro valor, tente novamante!");
        Console.ReadKey();
        Soma();
      }

      Console.WriteLine("Segundo valor: ");
      string input2 = Console.ReadLine();
      float valor2;

      if (!float.TryParse(input2, out valor2))
      {
        Console.WriteLine("Entrada inválida para o segundo valor, tente novamante!");
        Console.ReadKey();
        Soma();
      }

      float resultado = valor1 + valor2;

      Console.WriteLine("");
      Console.WriteLine($"O resultado da soma é: {resultado}");
      Console.WriteLine("Aperte qualquer tecla!");

      Console.ReadKey();
      Menu();

    }
    static void Subtracao()
    {
      Console.Clear();

      Console.WriteLine("-------- SUBTRAÇÃO --------");
      Console.WriteLine("Primeiro valor: ");
      string input1 = Console.ReadLine();
      float valor1;

      if (!float.TryParse(input1, out valor1))
      {
        Console.WriteLine("Entrada inválida para o primeiro valor, tente novamente!");
        Console.ReadKey();
        Subtracao();
      }

      Console.WriteLine("Segundo valor: ");
      string input2 = Console.ReadLine();
      float valor2;

      if (!float.TryParse(input2, out valor2))
      {
        Console.WriteLine("Entrada inválida para o segundo valor, tente novamente!");
        Console.ReadKey();
        Subtracao();
      }
      float resultado = valor1 - valor2;

      Console.WriteLine("");
      Console.WriteLine($"O resutlado da subtração é {resultado}");
      Console.WriteLine("Aperte qualquer tecla!");

      Console.ReadKey();
      Menu();

    }
    static void Divisao()
    {
      Console.Clear();

      Console.WriteLine("-------- DIVISAO --------");

      Console.WriteLine("Primeiro valor: ");
      string input1 = Console.ReadLine();
      float valor1;

      if (!float.TryParse(input1, out valor1))
      {
        Console.WriteLine("Entrada inválida para o primeiro valor, tente novamente!");
        Console.ReadKey();
        Divisao();
      }

      Console.WriteLine("Segundo valor: ");
      string input2 = Console.ReadLine();
      float valor2;

      if (!float.TryParse(input2, out valor2))
      {
        Console.WriteLine("Entrada inválida para o segundo valor, tente novamente!");
        Console.ReadKey();
        Divisao();
      }
      float resultado = valor1 / valor2;

      Console.WriteLine($"O resultado da divisão é: {resultado}");
      Console.WriteLine("Aperte qualquer tecla!");

      Console.ReadKey();
      Menu();
    }
    static void Multiplicacao()
    {
      Console.Clear();

      Console.WriteLine("-------- MULTIPLICAÇÃO --------");

      Console.WriteLine("Primeiro valor: ");
      string input1 = Console.ReadLine();
      float valor1;

      if (!float.TryParse(input1, out valor1))
      {
        Console.WriteLine("Entrada inválida para o primeiro valor, tente novamente!");
        Console.ReadKey();
        Multiplicacao();
      }

      Console.WriteLine("Segundo valor: ");
      string input2 = Console.ReadLine();
      float valor2;

      if (!float.TryParse(input2, out valor2))
      {
        Console.WriteLine("Entrada inválida para o segundo valor, tente novamente!");
        Console.ReadKey();
        Multiplicacao();
      }

      float resultado = valor1 * valor2;

      Console.WriteLine($"O resultado da multiplicação é: {resultado}");
      Console.WriteLine("Aperte qualquer tecla!");

      Console.ReadKey();
      Menu();
    }
  }

}