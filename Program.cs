using ExemploFundamentos.Models;

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine("Quantidade em estoque: " + quantidadeEmEstoque);
Console.WriteLine("Quantidade desejada para compra: " + quantidadeCompra);
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (possivelVenda)
{
  Console.WriteLine("Compra realizada com sucesso!");
}
else
{
  Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
}



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
