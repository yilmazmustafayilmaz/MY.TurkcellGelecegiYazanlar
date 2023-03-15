Console.WriteLine("Lütfen şifrenizi giriniz.");
string password = Console.ReadLine();

int score = 0;

LengthCheck(password);
UppercaseCheck(password);
LowercaseCheck(password);
DigitCheck(password);
SpecialCharCheck(password);

Console.WriteLine($"Toplam Puan: {score}");

switch (score)
{
    case 5: 
    case 4: Console.WriteLine("Parolanız çok güçlü seviyede."); 
        break;
    case 3: Console.WriteLine("Parolanız güçlü seviyede."); 
        break;
    case 2: Console.WriteLine("Parolanız orta seviyede."); 
        break;
    case 1: Console.WriteLine("Parolanız zayıf seviyede."); 
        break;
    case 0: Console.WriteLine("Bu nasıl parola lann..!"); 
        break;
    default: Console.WriteLine("ERROR!"); 
        break;
}

void LengthCheck(string password)
{
    if (password.Length > 6)
    {
        score++;
        Console.WriteLine("Minimum uzunluk testi başarılı.");
    }
    else
    {
        Console.WriteLine("Minimum uzunluk testi başarısız.");
    }
}

void UppercaseCheck(string password)
{
    
    if (password.Any(char.IsUpper))
    {
        score++;
        Console.WriteLine("Büyük harf testi başarılı.");
    }
    else
    {
        Console.WriteLine("Büyük harf testi başarısız.");
    }
}

void LowercaseCheck(string password)
{
    if (password.Any(char.IsLower))
    {
        score++;
        Console.WriteLine("Küçük harf testi başarılı.");
    }
    else
    {
        Console.WriteLine("Küçük harf testi başarısız.");
    }
}

void SpecialCharCheck(string password)
{
    if (password.Any(ch => !Char.IsLetterOrDigit(ch)))
    {
        score++;
        Console.WriteLine("Özel karakter testi başarılı.");
    }
    else
    {
        Console.WriteLine("Özel karakter testi başarısız.");
    }
    
}

void DigitCheck(string password)
{
    if (password.Any(char.IsDigit))
    {
        score++;
        Console.WriteLine("Rakam testi başarılı.");
    }
    else
    {
        Console.WriteLine("Rakam testi başarısız.");
    }
}
