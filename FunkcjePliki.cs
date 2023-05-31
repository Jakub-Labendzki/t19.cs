int liczba = int.Parse(Console.ReadLine());
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
Console.WriteLine(najmniejszaCyfra);



int e = int.Parse(Console.ReadLine());

int rekue(int n)
{
    if (n == 1) return 1;
    if (n == 2) return 3;
    if (n == 3) return 5;

    return 2 * rekue(n - 1) + rekue(n - 2) + rekue(n - 3);
}

for (int i = 1; i <= e; i++)
{
    Console.WriteLine(rekue(i));
}



string filename = "boki.txt";
int liczbaPar = 15;
double sumaPol = 0;

using (StreamWriter writer = new StreamWriter(filename))
{
    Random random = new Random();

    for (int i = 0; i < liczbaPar; i++)
    {
        double a = random.NextDouble() * 10 + 1;
        double b = random.NextDouble() * 10 + 1;
        double pole = a * b / 2;

        writer.WriteLine($"{a},{b}");
        sumaPol += pole;
    }
}

Console.WriteLine("Zawartość pliku boki.txt:");
Console.WriteLine(File.ReadAllText(filename));
