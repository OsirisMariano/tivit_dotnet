using ExemploFundamentos.Models;
string opção;
bool exibirMenu = true;

while (exibirMenu)
{
  Console.Clear();
  Console.WriteLine("Digite a sua opção: ");
  Console.WriteLine("1 - Cadastrar cliente");
  Console.WriteLine("2 - Listar clientes");
  Console.WriteLine("3 - Apagar cliente");
  Console.WriteLine("4 - Sair");

  opção = Console.ReadLine();

  switch (opção)
  {
    case "1":
      Console.WriteLine("Cadastro de cliente");
      break;
    case "2":
      Console.WriteLine("Listar clientes");
      break;
    case "3":
      Console.WriteLine("Apagar cliente");
      break;
    case "4":
      Console.WriteLine("Saindo...");
      exibirMenu = false;
      break;
    default:
      Console.WriteLine("Opção inválida, tente novamente.");
      break;
  }
}

// int soma = 0, numero = 0;
// do
// {
//   Console.WriteLine("Digite um número (0 para parar): ");
//   numero = Convert.ToInt32(Console.ReadLine());

//   soma += numero;

// } while (numero != 0);

// Console.WriteLine("A soma dos números digitados é: " + soma);






// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//   Console.WriteLine($"{contador}º Execução: {numero} x {contador} = {numero * contador}");
//   contador++;

//   if (contador == 6)
//     break;
// }


// int numero = 5;

// for (int contador = 0; contador <= 10; contador++)
// {
//   Console.WriteLine($"{numero} x {contador} = {numero * contador}");

// }










// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && estaTarde)
// {
//   Console.WriteLine("Vou pedalar.");
// }
// else
// {
//   Console.WriteLine("Vou pedalar um outro dia.");
// }








// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
//   Console.WriteLine("Aprovado!");
// }
// else
// {
//   Console.WriteLine("Reprovado!");
// }






// bool ehMaiorDeIdade = false;
// bool possuiAtorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAtorizacaoDoResponsavel)
// {
//   Console.WriteLine("Entrada autorizada.");
// }
// else
// {
//   Console.WriteLine("Entrada negada.");
// }







// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine("Quantidade em estoque: " + quantidadeEmEstoque);
// Console.WriteLine("Quantidade desejada para compra: " + quantidadeCompra);
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (possivelVenda)
// {
//   Console.WriteLine("Compra realizada com sucesso!");
// }
// else
// {
//   Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
// }



// string a = "10-";
// int b = 0;
// int.TryParse(a, out b);

// Console.WriteLine("Valor de b: " + b);




// double a = 4 / (2 + 2);
// Console.WriteLine(a);




// int a = 10;
// double b = a;
// long a = long.MaxValue;
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine("Valor de a: " + b);




// int inteiro = 10;
// string a = inteiro.ToString();

// Console.WriteLine("Valor de a: " + a);







// int a = Convert.ToInt32("10");
// a = 10;
// Console.WriteLine("Valor de a: " + a);



// int a = 10;
// int b = 20;
// int c = a + b;
//c = c + 5;
// c += 5;
// c -= 5;
// Console.WriteLine(c);


// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine("Data atual: " + dataAtual.ToString("dd/MM/yyyy"));

// string apresentacao = "Olá, seja bem vindo ao curso de C# Fundamentos!";

// int quantidade = 1;
// Console.WriteLine("quantidade: " + quantidade);
// quantidade = 10;
// Console.WriteLine("quantidade: " + quantidade);

// double altura = 1.80;
// decimal preco = 100.50m;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("apresentacao: " + apresentacao);
// Console.WriteLine("Quantidade: " + quantidade);
// Console.WriteLine("Altura: " + altura.ToString("0.00"));
// Console.WriteLine("Preço: " + preco);
// Console.WriteLine("Condição: " + condicao);

// Pessoa p = new Pessoa();

// p.Nome = "Osiris";
// p.Idade = 30;
// p.Apresentar();
