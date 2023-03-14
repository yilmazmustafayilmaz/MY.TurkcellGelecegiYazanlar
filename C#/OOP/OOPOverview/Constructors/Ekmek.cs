namespace Constructors;

public class Ekmek
{
    public Ekmek() : this(1)
    {
        Adet = 1;
        Tur = "Somun Ekmek";
    }
    public Ekmek(int adet)
    {
        Adet = adet;
        Tur = "Somun Ekmek";
    }
    public Ekmek(string tur)
    {
        Adet = 1;
        Tur = tur;
    }

    public int Adet { get; set; }
    public string Tur { get; set; }
}
