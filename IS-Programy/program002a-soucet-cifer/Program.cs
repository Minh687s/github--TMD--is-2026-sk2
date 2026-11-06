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
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte první hodnotu znovu (celé číslo): ");
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
    int digit; //Proměnná pro uložení právě zpracované číslice
    int multiplier = 1;
    // 2. Ošetření záporných čísel (znaménko nemá vliv na součet čísel)
    if (number < 0)
    {
        number = -number; 
    }
    // 3. Zvláštní případ
    if (number == 0)
    {
        sum = 0;
        multiplier = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na jednotlivé číslice (zprava do leva)");
        // 4. Jádro problému - matematický rozklad čísla pomocí cyklu
        while (number > 0)
        {
            // Operátoru % se říká MODULO (slouží k určení zbytku po celočíselném dělení)
            digit = number % 10; // MODULO 10 nám získá poslední číslici 
            sum = sum += digit; // Přičtení číslice k celkovému součtu
            multiplier = multiplier *= digit; // Přičtení číslice k celkovému součinu
            number = number /= 10; // Celočíselné dělení 10kou odstraní poslední číslici
            Console.WriteLine($"Aktuální číslice (zbytek): {digit}");
            Console.WriteLine($"Číslo po odříznutí aktuální  číslice: {number}");
            Console.WriteLine($"Aktuální hodnota součtu: {sum}");
            Console.WriteLine($"Aktuální hodnota součinu: {multiplier}");
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
