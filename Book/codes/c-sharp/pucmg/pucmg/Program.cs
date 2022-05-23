// Programa de nomes refatorado com while

string nome, mid, last;
int contador;

// nome default
nome = "";
mid = "";
last = "";

Console.WriteLine(" Seja bem vindo(a)!");

Console.WriteLine(" Por favor, insira o seu nome completo.");
Console.WriteLine(" Obs. No máximo 3 palavras");
contador = 1;

do
{   
    Console.WriteLine($" Qual a palavra nº {contador} do seu nome?");
    if (contador == 1)
        nome = Console.ReadLine();
    else if (contador == 2)
        mid = Console.ReadLine();
    else if (contador == 3)
        last = Console.ReadLine();

    contador += 1;
} while (contador <= 3);

Console.WriteLine(" Bem Vindo(a)!");
Console.WriteLine(nome);
Console.WriteLine(mid);
Console.WriteLine(last);
Console.WriteLine(" E Volte sempre!");
