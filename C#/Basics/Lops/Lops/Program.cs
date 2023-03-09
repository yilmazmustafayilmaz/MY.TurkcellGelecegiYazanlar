//******************************While Loop******************************
//Sayı bulmaca oyunu

Random randomNumberGenerator = new Random();

int puzzle = randomNumberGenerator.Next(0, 100);
bool isWin = false;

while (!isWin)
{
    Console.WriteLine("Lütfen tahmininizi girini:");
    int suggest = Convert.ToInt32(Console.ReadLine());

    if (suggest < puzzle)
        Console.WriteLine("Yukarı!");
    else if (suggest > puzzle)
        Console.WriteLine("Aşağı!");
    else
        Console.WriteLine("Bildiniz");
        isWin = true;
}

//Tüm elemanları yazdır
int[] numbers = { 13, 2, 7, 9, -4, 3 };

int index = 0;
while (index < numbers.Length)
{
    Console.WriteLine(numbers[index++]);
}

//******************************For Loop******************************
int[] numbers2 = { 13, 2, 7, 9, -4, 3 };
for (int i = 0; i < numbers2.Length; i++)
{
    Console.WriteLine(numbers2[i]);
}

string[] countries = { "Türkiye", "Almanya", "Hollanda", "İsveç", "Kıbrıs" };
Console.WriteLine("Bir ülke giriniz");
string country = Console.ReadLine();

bool isFind = false;

for (int i = 0;i < countries.Length; i++)
{
    if (countries[i] == country)
    {
        isFind = true;
        break;
    }
}

if (isFind)
{
    Console.WriteLine("Vardır");
}
else
{
    Console.WriteLine("Yoktur");
}


