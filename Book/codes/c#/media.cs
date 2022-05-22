int n1, n2, n3, n4, n5, soma;
float media;

Console.WriteLine("Programa para cálculo da média de 5 valores.");

Console.WriteLine("Por favor, forneça o primeiro número");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Por favor, forneça o segundo número");
n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Por favor, forneça o terceiro número");
n3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Por favor, forneça o quarto número");
n4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Por favor, forneça o quinto número");
n5 = Convert.ToInt32(Console.ReadLine());

soma = n1 + n2 + n3 + n4 + n5;
media = soma / 5;

Console.WriteLine("Os números fornecidos foram:");
Console.WriteLine("N1 = {0},N2 = {1},N3 = {2},N4 = {3},N5 = {4}", n1, n2, n3, n4, n5);
Console.WriteLine("Cuja média é igual a {0}", media);