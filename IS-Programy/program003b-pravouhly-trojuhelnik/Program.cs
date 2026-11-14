Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("******** Vykreslení  trojúhelníku ********");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    // Vstup pro výšku
    Console.Write("Zadejte výšku (celé číslo): ");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé číslo! Zadejte výšku znovu (celé číslo): ");
        Console.ResetColor();
    }

    // Rekapitulace zadaných hodnot 
    Console.WriteLine();
    Console.WriteLine("============================================");
    // Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"Výška: {height}");
    Console.WriteLine("============================================");
    Console.WriteLine();
    // Jádro algoritmu
    // Vnější cyklus: i jde od 1 do zadané velikosti
    for (int i = 1; i <= height; i++)
    {
    // Vnitřní cyklus: j se zastaví na hodnotě aktuálního řádku i!
    for (int j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine(); // Odřádkování
   }

    // Jádro algoritmu
    Console.ResetColor();
    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}
