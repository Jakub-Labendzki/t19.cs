// Zad 1
int liczba = int.Parse(Console.ReadLine());
int najmniejszaCyfra = 9;
int największaCyfra = 0;
int środkowaCyfra = 0;

while (liczba != 0)
{
    int cyfra = liczba % 10;
    if (cyfra < najmniejszaCyfra)
    {
        najmniejszaCyfra = cyfra;
    }
    if (cyfra > największaCyfra)
    {
        największaCyfra = cyfra;
    }
    liczba /= 10;
}

liczba = int.Parse(Console.ReadLine());

while (liczba != 0)
{
    int cyfra = liczba % 10;
    if (cyfra > najmniejszaCyfra && cyfra < największaCyfra)
    {
        środkowaCyfra = cyfra;
        break;
    }
    liczba /= 10;
}

Console.WriteLine(środkowaCyfra);



// Zad 2
int a = int.Parse(Console.ReadLine());

int rekue(int n)
{
    if (n == 1) return 1;
    if (n == 2) return 1;
    if (n == 3) return 2;

    return 2 * rekue(n - 1) + 2 * rekue(n - 2) + 2 * rekue(n - 3);
}

for (int i = 1; i <= a; i++)
{
    Console.WriteLine(rekue(i));
}


// Zad 3
string filePath = "boki.txt";
int liczbaPar = 20;
Random random = new Random();
using (StreamWriter sw = new StreamWriter(filePath))
{
    for (int i = 0; i < liczbaPar; i++)
    {
        int podstawa = random.Next(1, 10);
        int wysokosc = random.Next(1, 10);
        sw.WriteLine($"{podstawa} {wysokosc}");
    }
}
double sumaPol = 0;
using (StreamReader sr = new StreamReader(filePath))
{
    string line;
    while ((line = sr.ReadLine()) != null)
    {
        string[] parts = line.Split(' ');
        int podstawa = int.Parse(parts[0]);
        int wysokosc = int.Parse(parts[1]);
        double pole = 0.5 * podstawa * wysokosc;
        sumaPol += pole;
    }
}
Console.WriteLine(sumaPol);
