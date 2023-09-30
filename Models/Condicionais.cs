using System.Linq.Expressions;
using fundamentos.Models;


/*  -- OPERADOR DE NEGAÇÃO --
bool choveu = true;
bool estaTarde = false;

if (choveu && !estaTarde){
    Console.WriteLine("Vou pedalar");
}else{
    Console.WriteLine("Vou pedalar outro dia");
}
*/

/*
bool presencaMinima = true;
double media = 6.5;

if (presencaMinima && media >= 7){
    Console.WriteLine("Aprovado!");
}else{
    Console.WriteLine("Reprovado!");
}
*/

/*
bool maiorIdade = false;
bool autorizacao = true;

if (maiorIdade || autorizacao){
    Console.WriteLine("Entrada Liberada!");
}else{
    Console.WriteLine("Entrada não Liberada!");
}
*/

/*
 Console.WriteLine("Digite uma letra");
 string? letra = Console.ReadLine();

 switch(letra){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma Vogal");
        break;
 }
 */

/*
int quantidadeEstoque = 5;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0){
    Console.WriteLine("Venda Inválida!");
}else if (possivelVenda){
    Console.WriteLine("Venda Realizada!");
}else{
    Console.WriteLine("Desculpe. Estoque esgotado.");
}
Console.WriteLine($"Estoque Disponível: {quantidadeEstoque - quantidadeCompra}");
*/