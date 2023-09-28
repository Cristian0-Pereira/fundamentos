﻿using System.Data.Common;
using System.Net.Mail;
using fundamentos.Models;

Calculadora calc = new Calculadora();
calc.Somar(10, 30);
calc.Subtrair(10, 30);
calc.Multiplicar(10, 30);
calc.Dividir(10,30);
calc.Potencia(3, 3);

/*
string a = "15-";
int b = 0;
int.TryParse(a, out b);
Console.WriteLine(a);*/

// Cast = Conversão Automática
// int a = 5;
// double b = a;

// Console.WriteLine(b);

// Cast = Conversão Manual
// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);

// Cast - Casting
//int a = Convert.ToInt32("5");
// int a = int.Parse("5");
// Console.WriteLine(a);

// int a = 10;
// int b = 5;
// int c = a + b;

// c += 5;

// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual.ToString("dd/mm/yyyy hh:mm"));
// Console.WriteLine(dataAtual.AddHours(4).ToString("dd/mm/yyyy hh:mm"));
// Console.WriteLine(dataAtual.AddDays(5).ToString("dd/mm/yyyy"));

// Pessoa p = new()
// {
//     Nome = "Cristiano",
//     Idade = 40
// };
// p.Apresentar();

// string apresentacao = "Olá, seja bem vindo!";
// int quantidade = 10;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preço: " + preco);
// Console.WriteLine("Valor da variável condiçao: " + condicao);