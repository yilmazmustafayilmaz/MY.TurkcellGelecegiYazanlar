﻿using Encapsulation;

Otomobil otomobil = new Otomobil();
otomobil.Calistir();
otomobil.GazaBas();
otomobil.Durdur();

Product product = new Product();
int price = int.Parse(Console.ReadLine());
product.SetPrice(price);
Console.WriteLine(product.GetPrice);

product.Name = "Telefon";

product.Stock = 1000;

//if (price > 0)
//{

//}
//else
//{
//    Console.WriteLine("Kesinlikle olamaz.");
//}
