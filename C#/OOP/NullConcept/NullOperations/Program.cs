//Boxing: Kutulamak
object o = "Bir nesne";
o = 9;
o = false;
o = new Random();

Random random = new Random();
object empty = new object();

int x = 0;
decimal y = 0;

Console.WriteLine($"int ve decimal: { x == y}");
Console.WriteLine($"int ve decimal: {x.Equals(y)}");

//== referans
//Equals: Değer

Address address1 = new Address() { City = "Gaziantep" };
Address address2 = new Address() { City = "Hatay" };

Console.WriteLine(address1.Equals(address2));
Console.WriteLine(address2 == address1);

string deney1 = "TURKCELL";
string deney2 = "TURKCELL";
string deney3 = "TURKCELLx".Substring(0,8);
object deney4 = deney3;

Console.WriteLine($"== ile: { deney1 == deney2}");
Console.WriteLine($"Equals ile: {deney1.Equals(deney2)}");

Console.WriteLine($"== ile: {deney1 == deney3}");
Console.WriteLine($"Equals ile: {deney1.Equals(deney3)}");

Console.WriteLine($"== ile: {deney1 == deney4}");
Console.WriteLine($"Equals ile: {deney1.Equals(deney4)}");

Address address = null;
Console.WriteLine(address ?? new Address { City = "Burdur" });
Console.WriteLine(address?.City);

public class Address
{
    public string City { get; set; }

    public override string ToString()
    {
        return $"Bu adres {City} şehrinde bulunuyor";
    }
}

