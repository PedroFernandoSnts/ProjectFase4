using System;// importando fucionamento basico
using System.Numerics;
public class SomaEMediaCompacta
{
    public static void Main(string[] args)// dando nome ao projeto
    {
        // 1. pergunta e leitura da quantidade
        Console.WriteLine("Quantos números vocé deseja somar o calcular a média");
            int quantidade = Convert.ToInt32(Console.ReadLine());
        Double soma = 0, numerolido;
        Console.WriteLine($"/n--- Digite os {quantidade} números---");
        for (int i = 1; i <= quantidade; i++)
        {
            Console.WriteLine($" Digite o {i}º numero:");
            numerolido = Convert.ToDouble(Console.ReadLine());
            soma += numerolido;
        }
        double media = soma / quantidade;

        // Estrutura Condicional IF-ELSE Normal
        if (media > 1000)
        {
            Console.WriteLine("Média maior que 1000.");
        }
        else
        {
            Console.WriteLine("Média maior ou igual a 1000.");
        }

        Console.WriteLine("/n--- Resultados Finais ---");
        Console.WriteLine($"Total de números lidos: **{quantidade}");
        Console.WriteLine($"A **soma** total dos números é: **{ soma: F2} **");
        Console.WriteLine($"A **MÉDIA** dos números lidos é: **{media:F2}**");
    }
}




