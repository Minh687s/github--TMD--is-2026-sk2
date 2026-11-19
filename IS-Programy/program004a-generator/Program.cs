Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel ****");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    // Vstup pro počet generovaných čísel
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.Write("Nezadali jste platné celé číslo! Zadejte počet generovaných čísel znovu (celé číslo): ");
    }

    // Vstup pro delní mez
    Console.Write("Zadejte dolní mez(celé číslo): ");
    int lowerBound;
    while(!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte dolní mez znovu (celé číslo): ");
    }
    // Vstup pro horní mez
    Console.Write("Zadejte horní mez(celé číslo větší nebo rovno hodnotě pro dolní mez): ");
    int upperBound;
    while(!int.TryParse(Console.ReadLine(), out upperBound) || upperBound <= lowerBound)
    {
        Console.Write("Nezadali jste celé číslo! Zadejte horní mez znovu (celé číslo): ");
    }

    // Rekapitulace zadaných hodnot 
    Console.WriteLine();
    Console.WriteLine("============================================");
    // Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"Počet generovaných čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound}");
    Console.WriteLine("============================================");
    Console.WriteLine();
    // Jádro algoritmu 
    int[] myRandNumbs = new int[n];
    Random myRandNumb = new Random();
    Console.WriteLine("Generovaná pseudonáhodná čísla: ");
    for (int i = 0; i < myRandNumbs.Length; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write ($"{myRandNumbs[i]}; ");
    }


   

    


    // Jádro algoritmu
    
    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   
