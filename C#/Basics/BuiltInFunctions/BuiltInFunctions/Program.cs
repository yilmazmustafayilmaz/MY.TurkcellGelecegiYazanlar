﻿string word = "bilgisayari";
Console.WriteLine(word.ToUpper());
Console.WriteLine(word.Substring(5));

int index = word.IndexOf('i', 2);
Console.WriteLine(index);

/*
 * harf bulamaz ise -1 döndürüyor.
 * belirli bir noktadan aramaya başlayabiliyor.
 * İlk karşılaştığı index değerini veriyor.
 * 
 *  -1 sonucu almadığı sürece
 *     Bir başlangıç noktasından harfi ara
 *     Başlangıç noktasını bulunandan bir fazlası yap
 */

int startIndex = 0;
bool isFind = word.IndexOf('i', startIndex) != -1;
while (isFind)
{
    int findingIndex = word.IndexOf('i', startIndex);
    startIndex = findingIndex + 1;
    Console.WriteLine($"i  harfinin indexi: {findingIndex}");
    isFind = word.IndexOf('i', startIndex) != -1;
}