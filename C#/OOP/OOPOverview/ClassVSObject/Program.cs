using ClassVSObject;

Product product1 = new Product();
product1.Name = "Laptop";

Product product2 = product1;

product2.Name = "Telefon";

Console.WriteLine(product1.Name);