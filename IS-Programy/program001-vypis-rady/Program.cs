// jednořádkový 

/* 
Toto je
více řádkový 
komentář
*/

// jako první si připravíme smyčku pro opakování programu

Console.Clear();
string again = "a";
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání "a" tak i "A"
while(again.ToLower() == "a" )
{
    Console.WriteLine();
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("*************** Výpis řady ***************");
    Console.WriteLine("******************************************");
    Console.WriteLine("************** Tomáš Žižka ***************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    // Vstup počáteční hodnoty - špatně řešený
    Console.Write("Zadejte první číslo řady: ");
    int first = int.Parse(Console.ReadLine()); 


    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";

}   