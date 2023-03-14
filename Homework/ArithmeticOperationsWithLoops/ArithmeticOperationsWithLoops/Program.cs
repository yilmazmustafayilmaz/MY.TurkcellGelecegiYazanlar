#region FoorLoop

int[] numbers = new int[] { 100, 200, 300, 400, 500 };
int sum = 0;
int avg = 0;

int max = numbers[0];
int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine($"Toplam: {sum}");

for (int i = 0; i < numbers.Length; i++)
{
    avg += numbers[i];
}
Console.WriteLine($"Ortalama: {avg / numbers.Length}");

for (int i = 0; i < numbers.Length; i++)
{
    if (max < numbers[i])
        max = numbers[i];
}
Console.WriteLine($"En büyük değer: {max}");

for (int i = 0; i < numbers.Length; i++)
{
    if (min > numbers[i])
        min = numbers[i];
}
Console.WriteLine($"En küçük değer: {min}");

#endregion

#region WhileLoop

int[] numbers2 = new int[] { 500, 400, 300, 200, 100 };
int sum2 = 0;
int avg2 = 0;

int max2 = numbers[0];
int min2 = numbers[0];

int j = 0;

while (j < numbers2.Length)
{
    if (min > numbers2[j])
        min = numbers2[j];

    if (max < numbers2[j])
        max = numbers2[j];

    sum2 += numbers2[j++];
    avg2 = sum2 / numbers2.Length;

}
Console.WriteLine($"Toplam: {sum2} / Ortalama: {avg2} / En büyük değer: {max2} / En küçük değer: {min2}");

#endregion
