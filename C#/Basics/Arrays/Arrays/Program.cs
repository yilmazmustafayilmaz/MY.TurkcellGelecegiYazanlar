// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1. Yol: Kaç elemandan oluşacağını biliyorum ama değerlerini bilmiyorum
string[] books = new string[8];
//2. Yol Kaç elemandan oluşacağını da değerlerini de biliyorum
string[] seasons = new string[] { "İlkbahar", "Yaz", "Sonbahar", "Kış" };

books[0] = "Yüzüklerin Efendisi";
books[7] = "Otostopçunun Galaksi Rehberi";

Console.WriteLine(seasons[0]);
Console.WriteLine(seasons[seasons.Length - 1]);

/*
 * Girilen iki basamaklı bir sayıyı yazıya dönüştürme
 */

string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };

Console.WriteLine("İki basamaklı bir sayı giriniz.");
int number = Convert.ToInt32(Console.ReadLine());

int onlarBasamagi = number / 10;
int birlerBasamagi = number % 10;

Console.WriteLine($"{onlar[onlarBasamagi]} {birler[birlerBasamagi]}");