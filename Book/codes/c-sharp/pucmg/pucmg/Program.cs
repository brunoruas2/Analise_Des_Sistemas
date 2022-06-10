// Criaremos um vetor de números inteiros com 5 posições e ler cada um de seus valores.
// Criaremos duas funções que, tomando esse vetor como parâmetro, irão retornar a soma dos
// números pares contidos no vetor e a quantidade de números ímpares que ele possui. 

int[] vetor = new int[5];
int somaPar = 0;
int somaInpar = 0;
int input;

// Soma de dois valores
int soma(int valor1, int valor2)
{
    return valor1 + valor2;
};

// Iteracao para lancamento dos valores e somas
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Valor da Posição nº: {i + 1}");
    input = int.Parse(Console.ReadLine());

    vetor[i] = input;
    if (input % 2 == 0)
    {
        somaPar = soma(somaPar, input);
    } else
    {
        somaInpar = soma(somaInpar, input);
    }
};

Console.WriteLine($"SomaPar = {somaPar}, SomaInpar = {somaInpar}");
Console.WriteLine($"Vetor = ({vetor[0]},{vetor[1]},{vetor[2]},{vetor[3]},{vetor[4]})");
