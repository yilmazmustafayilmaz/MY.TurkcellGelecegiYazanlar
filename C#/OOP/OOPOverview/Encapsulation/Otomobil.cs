namespace Encapsulation;

public class Otomobil
{
    private int hiz = 0;
    private bool arabaCalisiyorMu = false;

    public void Calistir()
    {
        arabaCalisiyorMu = true;
    }
    public void GazaBas()
    {
        if (arabaCalisiyorMu)
        {
            hiz++;
        }
        else
        {
            Console.WriteLine("Arabayı çalıştırmalısın.");
        }
    }
    public void Durdur()
    {
        if (!arabaCalisiyorMu)
        {
            hiz = 0;
        }
        else
        {
            Console.WriteLine("Arabayı çalıştırmalısın.");
        }
    }
}
