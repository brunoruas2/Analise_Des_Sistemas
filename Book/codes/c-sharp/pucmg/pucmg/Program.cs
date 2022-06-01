int num = 0, cont1 = 0, cont2 = 0;

do
{
    num = int.Parse(Console.ReadLine());

    if(num > 0)
    {
        cont1++;
    } else
    {
        cont2++;
    }

} while(num != 0);

Console.WriteLine($"Contador 1 = {cont1}, Contador 2 = {cont2}");