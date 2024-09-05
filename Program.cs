// See https://aka.ms/new-console-template for more information

Random r = new Random();
int num = r.Next(1, 6 + 1);
Console.WriteLine("Número sacado: " + num);

if (num == 1)
    Console.WriteLine("Perdió");
else if (num == 2)
    Console.WriteLine("Pco");
else if (num == 3)
    Console.WriteLine("Algo");
else
    Console.WriteLine("No se");

switch (num)
{
    case 4:
    case 5:
        Console.Writine("es 4 o 5");
        break;
    default:
        Console.WriteLine("Otro");
        break;
}

string resp = num > 3;
Console.WriteLine(resp);