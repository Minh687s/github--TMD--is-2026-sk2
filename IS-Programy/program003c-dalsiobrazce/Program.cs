Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("*********** Vykreslení  obrazců **********");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    // Vstup pro šířku
    Console.Write("Zadejte šířku (celé číslo): ");
    int width;
    while(!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé číslo! Zadejte šířku znovu (celé číslo): ");
        Console.ResetColor();
    }

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
    Console.WriteLine($"Šířka: {width}; Výška: {height}");
    Console.WriteLine("============================================");
    Console.WriteLine();
    // Jádro algoritmu
    // Vnější cyklus, počet řádků (výška)
    for (int i = 0; i < height; i++)
    {
        if (i % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
        // Vnitřní  cyklus
        for (int j = 0; j < width; j++)
        {
        if (i == 0 || i == height - 1 || j == width - 1 - (i * (width - 1)) / (height - 1))
            {
                Console.Write("* ");
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
            }
        else
            {
                Console.Write("  ");
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    
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