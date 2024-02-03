﻿using System;
using System.Xml.Serialization;
namespace Calculadora;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("---------------");
        Console.WriteLine("Selecione uma Opção: ");

        short res = short.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }

    }
    static void Soma()
    {
        Console.Clear();

        Console.WriteLine("Informe o primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo valor:  ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 + v2;

        Console.WriteLine("O resultado é: " + resultado);
        Console.ReadKey();
        Menu();
        //Possibilidades
        //Console.WriteLine($"O resultado é: {resultado}"); ou Console.WriteLine($"O resultado é: {v1 + v2}");
    }
    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("Informe o primeiro valor:  ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 - v2;

        Console.WriteLine("O resultado é: " + resultado);
        Console.ReadKey();
        Menu();
    }
    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Informe o primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 / v2;
        Console.WriteLine($"O resultado da divisão é: {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Multiplicacao()
    {

        Console.Clear();
        Console.WriteLine("Informe o primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 * v2;

        Console.WriteLine($"O resultado da multiplicação é {resultado}");
        Console.ReadKey();
        Menu();
    }

}
