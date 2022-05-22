// Programa para calcular o valor de x em uma equacao
// de segundo grau

// Declaracao das variaveis
double a, b, c, x1, x2;

Console.WriteLine("Vamos resolver uma equação do tipo ax^2 + bx + c = 0");

// Input das variaveis
Console.WriteLine("Qual o valor de a? ");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual o valor de b? ");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual o valor de c? ");
c = Convert.ToDouble(Console.ReadLine());


x1 = (-b + Math.Sqrt(Math.Pow(b,2) - 4 * a * c)) / 2 * a;
x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;

// Output dos resultados
Console.WriteLine("Dados: a = {0}, b = {1} e c = {2}", a, b, c);
Console.WriteLine($"Equação: (-({b}) +- Raiz(({b})^2 - 4*{a}*{c}))/2*{a} = 0");
Console.WriteLine("Resultado: x1 = {0} e x2 = {1}", x1, x2);