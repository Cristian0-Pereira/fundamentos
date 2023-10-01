using System.Data.Common;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using fundamentos.Models;

/*
string opcao;
bool exbirMenu = true;

while(exibirMenu){
    Console.Clear();
    Console.WriteLine("Digite uma opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao){
        case "1":
            Console.WriteLine("Cadastrar Cliente");
            break;
        case "2":
            Console.WriteLine("Buscar Cliente");
            break;
        case "3":
            Console.WriteLine("Apagar Cliente");
        break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;
        default:
        Console.WriteLine("Opção Inválida");
        break;
    }
}

Console.WriteLine("Seu programa encerrou");
*/

/*
int soma = 0, num = 0;

do{
    Console.WriteLine("Digite um número (0 para parar)");
    num = Convert.ToInt32(Console.ReadLine());
    soma += num;

}while(num != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}");
*/

/*
int num = 5;
int contador = 1;
while (contador <= 10){
    Console.WriteLine($"{contador}° Execusão: {num} x {contador} = {num*contador}");
    contador++;
    if (contador == 6+1){
        break;
    }
}
*/

/*
int num = 5;
for(int contador = 0; contador <= 10000; contador++){
    Console.WriteLine($"{num} x {contador} = {num*contador}");
}
*/

/*
int num = 20;
Console.WriteLine($"Incrementando o {num}");
num++;
Console.WriteLine(num);
Console.WriteLine($"Decrementando o {num}");
num--;
Console.WriteLine(num);
*/

/*
Operadores calc = new();
calc.Somar(10, 30);
calc.Subtrair(10, 30);
calc.Multiplicar(10, 30);
calc.Dividir(10,30);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(25);
*/

/*
string a = "15-";
int b = 0;
int.TryParse(a, out b);
Console.WriteLine(a);
*/

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