using ExemplosFundamentosDotNET.Models;


string opcao;
bool exibirMenu = true;
while (exibirMenu)
{
    Console.WriteLine("digite sua opção: ");
    Console.WriteLine("1 - Cadastro de cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente ");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();


    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Buscar cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;

            // Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;

    }
}

Console.WriteLine("Programa encerrado");

















// int soma = 0, numero = 0;



// do
// {
//     Console.WriteLine("Digite um numero (digite 0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total de numeros digitados é: {soma}");














// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}º Execução: {numero} x {contador} =  {numero * contador}");
//     contador++;
//     if (contador == 6)
//     {

//         break;
//     }
// }








// int numero = 5;

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }



// //Decremento 

// int numeroDecremento = 20;

// Console.WriteLine(numeroDecremento);
// numeroDecremento--;

// Console.WriteLine("Decremento --1");
// Console.WriteLine(numeroDecremento);


// //Incrementando 


// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);
// numeroIncremento++;

// Console.WriteLine("Incremento ++1");
// Console.WriteLine(numeroIncremento);


// Calculadora com operações basicas
// Calculadora calc = new Calculadora();

// calc.Somar(10, 5);
// calc.Mutiplicar(10, 5);
// calc.Subitrair(10, 5);
// calc.Dividir(10, 5);

// calc.Potencia(30, 30);

// calc.Tangente(30);
// calc.Coseno(30);
// calc.Seno(30);
// calc.RaizQuadrada(9);


//not operator


// bool choveu = true;
// bool estaTarde = false;

// if (choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia");
// }


























// bool possuiPresencaMinima = true;
// double nota = 5.5;


// if (possuiPresencaMinima && nota >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else { Console.WriteLine("Reprovado"); }





















// bool eMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (eMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }
// ;




























// Console.WriteLine("Digite uma vogal");

// string letra = Console.ReadLine();


// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("É uma vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }
























// if (
//     letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u"
// )
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }













// int quantidadeEmEstoque = 3;
// int quantidadeComprada = 5;
// bool possivelVenda = quantidadeComprada > 0 && quantidadeEmEstoque >= quantidadeComprada;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade em compra: {quantidadeComprada}");
// Console.WriteLine($"É possivle realizar a venda?: {possivelVenda}");


// if (quantidadeComprada == 0)
// {
//     Console.WriteLine("Venda invalida");

// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpa. Não temos a quantidade desejada em estoque.");
// }











// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);


// Cast - casting
// int a = Convert.ToInt32("5");
// int a = int.Parse("5");

// Console.WriteLine(a);

// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtual.ToString("dd/mm/yyyy  HH:mm"));


// string apresentacao = "Óla, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1120.80m;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("texto " + quantidade);
// Console.WriteLine("texto " + altura.ToString("0.00"));
// Console.WriteLine("texto " + preco + "R$");
// Console.WriteLine("texto " + condicao);


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Thiago";
// pessoa1.Idade = 32;

// pessoa1.Apresentar();
