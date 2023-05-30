/*int liczba = int.Parse(Console.ReadLine());
int najmniejszaCyfra = 9;

while (liczba != 0)
{
    int cyfra = liczba % 10;
    if (cyfra < najmniejszaCyfra)
    {
        najmniejszaCyfra = cyfra;
        if (najmniejszaCyfra == 0)
        {
            break;
        }
    }
    liczba /= 10;
}
Console.WriteLine(najmniejszaCyfra);*/

Random random = new Random();
string filename = "boki.txt";
int liczbaPar = 15;
double sumaPol = 0;

using (StreamWriter writer = new StreamWriter(filename))
{
    for (int i = 0; i < liczbaPar; i++)
    {
        double a = random.NextDouble() * 10 + 1;
        double b = random.NextDouble() * 10 + 1;
        writer.WriteLine($"{a},{b}");

        double pole = a * b / 2;
        sumaPol += pole;
    }
}

using (StreamReader reader = new StreamReader(filename))
{
    string line;
    Console.WriteLine("Zawartość pliku boki.txt:");
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}
