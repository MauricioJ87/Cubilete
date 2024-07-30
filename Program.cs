//Desarrollo de logica de decision con instrucciones if

Random dado = new Random();

int tirada1 = dado.Next(1, 7);
int tirada2 = dado.Next(1, 7);
int tirada3 = dado.Next(1, 7);

//tirada1 = 6;
//tirada2 = 6;
//tirada3 = 6;

int total = tirada1 + tirada2 + tirada3;

Console.WriteLine($"Dado tirado: {tirada1} + {tirada2} + {tirada3} + {total} ");

if ((tirada1 == tirada2) || (tirada2 == tirada3) || (tirada1 == tirada3))
{
    if ((tirada1 == tirada2) && (tirada2 == tirada3))
    {
        Console.WriteLine("Obtuviste triples! Bono +6 al total");
        total += 6;
    }
    else
    {
        Console.WriteLine("¡Obtuviste dobles! ¡Bono +2 al total!");
        total += 2;    
    }
    Console.WriteLine($"Su total incluyendo el bono: {total}");
}
    
if (total >= 16)
{
    Console.WriteLine("Eres el ganador de un auto!");
}
else if (total >= 10)
{
    Console.WriteLine("Eres el ganador de una laptop!");
}
else if (total == 7)
{
    Console.WriteLine("Eres el ganador de una trip for two");
}
else
{
    Console.WriteLine("Eres el ganador de un pollo para cenar");
}
//else
//{
//    Console.WriteLine("Game over!");
//}


