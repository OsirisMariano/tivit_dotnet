using System;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na lista: {listaString.Count} - Capacidade da lista: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na lista: {listaString.Count} - Capacidade da lista: {listaString.Capacity}");

listaString.Add("MG");

Console.WriteLine($"Itens na lista: {listaString.Count} - Capacidade da lista: {listaString.Capacity}");


// for (int contador = 0; contador < listaString.Count; contador++)
// {
//   Console.WriteLine($"Valor do array usando for {contador}: {listaString[contador]}");
// }

// int contadorForeach = 0;
// foreach (string item in listaString)
// {
//   Console.WriteLine($"Valor do array usando foreach: {contadorForeach}: {item}");
//   contadorForeach++;
// }







// Ajustamos o nome aqui para 'arrayInteiros' para coincidir com o resto do código
// int[] arrayInteiros = new int[4];

// Agora o C# reconhece este nome!
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 100;

// int[] arryInteiros2 = new int[arrayInteiros.Length * 2];

// Array.Copy(arrayInteiros, arryInteiros2, arrayInteiros.Length);



// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // Redimensiona o array para 6 elementos

// Percorrendo o Array usando um loop for
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//   Console.WriteLine("Valor do array usando for " + contador + ": " + arrayInteiros[contador]);
// }

// int contadorForeach = 0;

// Percorrendo o Array usando um loop for
// foreach (int valor in arrayInteiros)
// {
//   Console.WriteLine("Valor do array usando foreach: " + valor);
//   contadorForeach++;
// }