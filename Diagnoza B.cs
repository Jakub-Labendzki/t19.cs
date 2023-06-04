// Zad 1
/*int suma = 0;
for (int i = 100; i < 1000; i++)
{
    suma += i;
}
Console.WriteLine(suma);*/

// Zad 2
/*int suma = 0;
int ilosc = 0;
for (int i = 12; i < 100; i++)
{
    if (i % 6 == 0)
    {
        suma += i;
        ilosc++;
    }
}
Console.WriteLine($"suma to: {suma}, ilosc to: {ilosc}");*/

// Zad 3
/*int maxik = int.MinValue;
Random r = new Random();
for (int i = 0; i < 5; i++)
{
    int losowa = r.Next(1000, 10000);
    if (losowa > maxik)
    {
        maxik = losowa;
    }
}
Console.WriteLine(maxik);*/

// Zad 4
/*int a = int.Parse(Console.ReadLine());
int sum = 0;
while (a != 0)
{
    int ost = a % 10;
    sum += ost;
    a /= 10;
}
Console.WriteLine("Suma cyfr w liczbie: " + sum);*/

// Zad 5
/*int a = int.Parse(Console.ReadLine());
int min = 9;
while (a != 0)
{
    int ost = a % 10;
    if (ost < min)
    {
        min = ost;
    }
    a /= 10;
}

Console.WriteLine(min);*/

// Algorytmy
// Zad 1
/*int a = int.Parse(Console.ReadLine());
int licznikdzielnikow = 0;
for (int i = 1; i < a + 1; i++)
{
    if (a % i == 0)
    {
        Console.WriteLine(i);
        licznikdzielnikow++;
    }
}
if (licznikdzielnikow == 2)
{
    Console.WriteLine("Pierwsza");
}
else
{
    Console.WriteLine("Złożona");
}*/

// Zad 2
/*int a = int.Parse(Console.ReadLine());
int licznikdzielnikow = 0;
for (int i = 1; i < a + 1; i++)
{
    if (a % i == 0)
    {
        Console.WriteLine(i);
        licznikdzielnikow++;
    }
}
if (licznikdzielnikow == 2)
{
    Console.WriteLine("Pierwsza");
}
else
{
    Console.WriteLine("Złożona");
}*/

// Zad 3
/*static int GCD(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}
int c = int.Parse(Console.ReadLine());
if (GCD(c, 24) == 1)
{
    Console.WriteLine("TAk");
}
else
{
    Console.WriteLine("NIe");
}*/


// Zad 4
/*
class Program
{
    static string EncodeCesar(string s, int k)
    {
        char[] encodedChars = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (char.IsLetter(c))
            {
                char baseChar = char.IsUpper(c) ? 'A' : 'a';
                encodedChars[i] = (char)((c - baseChar + k) % 26 + baseChar);
            }
            else
            {
                encodedChars[i] = c;
            }
        }
        return new string(encodedChars);
    }

    static void Main(string[] args)
    {
        Console.Write("Wpisz słowo: ");
        string s = Console.ReadLine();

        Console.Write("Wpisz klucz k: ");
        int k = Convert.ToInt32(Console.ReadLine());

        string encoded = EncodeCesar(s, k);
        Console.WriteLine("Zakodowane słowo: " + encoded);
    }
}*/

// Zad 5
/*static int GCD(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}
Console.Write("Wpisz ułamek c/d: ");
string[] ab = Console.ReadLine().Split("/");
int a = int.Parse(ab[0]);
int b = int.Parse(ab[1]);

Console.Write("Wpisz ułamek c/d: ");
string[] cd = Console.ReadLine().Split("/");
int c = int.Parse(cd[0]);
int d = int.Parse(cd[1]);

int x = b, y = d;
int ilocz = x * y;

while (y > 0)
{
    int temp = y;
    y = x % y;
    x = temp;
}

int nww = ilocz / x;

int e = (nww / b) * a;
int f = (nww / d) * c;
int g = e + f;

Console.WriteLine($"{a}/{b} + {c}/{d} = {e}/{nww} + {f}/{nww} = {g}/{nww}");

int dz = GCD(a, b);

int c1 = g / nww;
int l = g % nww;
int m = nww;

int x1 = l / dz;
int y2 = m / dz;

Console.WriteLine($"Mieszany: {g}/{nww} = {c1} {x1}/{y2}");

int x2 = g / dz;
int y3 = nww / dz;

Console.WriteLine($"Nieskracalny: {g}/{nww} = {x2}/{y3}");*/

// Zad 6
/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int iloczyn = a * b;
while (a != b)
{
    if (a > b)
    {
        a = a - b;
    }
    if (b > a)
    {
        b = b - a;
    }
}
int nww = a;
Console.WriteLine(iloczyn / nww);*/

// Kartka
// Zad 1
/* 8822+/234*---
8
88
882
8822
884
82
822
8223
82234
82212
82-10
812
-4
*/

// Zad 2
/* (3+8)/4-6*(3*4/2)
  k     | r
(+)     | 38+
/-*(* /)| 38+46342
/-*     |38+46342* /*-/
*/

// Zad 3
/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
while (a != b)
{
    if (a > b)
    {
        a = a - b;
    }
    if (b > a)
    {
        b = b - a;
    }
}
Console.WriteLine(a);*/

/*
a  | b  | r = a - b
35 | 56 | 56 - 35 = 21
35 | 21 | 35 - 21 = 14
14 | 21 | 21 - 14 = 7
14 | 7  | 14 - 7 = 7
7  | 7  |
Wynik to: 7
*/

/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

while (b > 0)
{
    int temp = a;
    a = b;
    b = temp % b;
}

Console.WriteLine(a);*/

/*
a  | b  | r = a % b
35 | 56 | 35 % 56 = 35
56 | 35 | 56 % 35 = 21
35 | 21 | 35 % 21 = 14
21 | 14 | 21 % 14 = 7
14 | 7  | 14 % 7 = 7
7  | 7  |
Wynik to: 7
*/

// Napisy
//Zad 1
/*string a0 = Console.ReadLine();
int a01 = CountOccurrences(a0, 'c');
Console.WriteLine(a01);
static int CountOccurrences(string input, char character)
{
    int count = 0;
    foreach (char c in input)
    {
        if (c == character)
        {
            count++;
        }
    }
    return count;
}*/

// Zad 2
/*string a02 = Console.ReadLine();
bool result = Sprawdz(a02);
Console.WriteLine(result);
static bool Sprawdz(string input)
{
    for (int i = 1; i < input.Length; i++)
    {
        if (input[i - 1] > input[i])
        {
            return true;
        }
    }
    return false;
} */


// Zad 3
/*string[] slowa = new string[3];
for (int i = 0; i < 3; i++)
{
    slowa[i] = Console.ReadLine();
}
string najdluzszy = slowa[0];
for (int i = 1; i < 3; i++)
{
    if (slowa[i].Length > najdluzszy.Length)
    {
        najdluzszy = slowa[i];
    }
}
Console.WriteLine(najdluzszy); */
