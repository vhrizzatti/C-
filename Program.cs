int idade = 18;
Console.Write("Quantos anos você acha que eu tenho? ");
string chute = Console.ReadLine()!;
int nChute = int.Parse(chute);

while (nChute != idade)
{
    if (nChute < idade)
    {
        Console.WriteLine("Sou mais velho que isso.");
    }
    else if (nChute > idade)
    {
        Console.WriteLine("Sou mais novo que isso.");
    }

    Console.Write("Tente novamente: ");
    chute = Console.ReadLine()!;
    nChute = int.Parse(chute);
}

Console.WriteLine("Parabéns, você acertou!");

  

 
