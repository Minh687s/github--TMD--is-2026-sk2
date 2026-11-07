Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("************ Název programu **************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    // Vstup celého čísla
    Console.Write("Zadejte celé číslo: ");
    int number;
    string? input = Console.ReadLine();
    while(!int.TryParse(input, out number))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte první hodnotu znovu (celé číslo): ");
        input = Console.ReadLine();
    }

    // Rekapitulace zadaných hodnot 
    Console.WriteLine();
    Console.WriteLine("============================================");
    // Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"Celé číslo: {number}");
    Console.WriteLine("============================================");
    Console.WriteLine();
    // Jádro algoritmu 
    // 1. Příprava pomocných proměnných pro výpočet
    int numberbackup = number; // Záloha původního čísla pro závěrečný výpis
    int sum = 0; // Neutrální hodnotou pro sčítání je 0
    int multiplier = 1;
    int numberForCalculation = number;
    // 2. Ošetření záporných čísel (znaménko nemá vliv na součet čísel)
    if (numberForCalculation < 0)
    {
        numberForCalculation = -numberForCalculation;
    }
    // 3. Zvláštní případ
    if (numberForCalculation == 0)
    {
        sum = 0;
        multiplier = 0;
    }
    else
    {
        string textNumber = numberForCalculation.ToString();
        foreach (char sign in textNumber)
        {
            int currentDigit = sign - '0';
            sum += currentDigit;
            multiplier *= currentDigit;
        }
    }
    // Jádro algoritmu 
    
    // 5. Výpis výsledku
    Console.WriteLine();
    Console.WriteLine("===============================================");
    Console.WriteLine($"Ciferný součet čísla {numberbackup} je: {sum}");
    Console.WriteLine($"Ciferný součin čísla {numberbackup} je: {multiplier}");
    Console.WriteLine("===============================================");
    Console.WriteLine();

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}