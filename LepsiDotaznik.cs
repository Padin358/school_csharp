var pi = Math.PI;
Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine("--------- Osobní dotazník ---------\nAhoj, jak se jmenujete?");
var name = Console.ReadLine();
Console.WriteLine("\nKolik je Vám let?");
var age = Console.ReadLine();
Console.WriteLine("\nKam chodíte do školy?");
var school = Console.ReadLine();
Console.WriteLine("\nJaké máte záliby?");
var hobby = Console.ReadLine();

Console.WriteLine("\nProgram nyní čeká na stisknutí klávesy ENTER a následně bude pokračovat. (program čeká)");
Console.ReadLine();
// Sinus
var sinus = Math.Sin(Int32.Parse(age)) * pi / 180;
Console.WriteLine($"Sinus z vašeho věku je: {sinus}");
// Počet písmen ve jméně
Console.WriteLine($"Délka vašeho jména je: {name.Length}");
// Čekání na Enter #2
Console.WriteLine("\nProgram nyní čeká na stisknutí klávesy ENTER a následně bude pokračovat. (program čeká)");
Console.ReadLine();

Console.WriteLine($"Výpis ze zadaných informací:\nVaše jméno: {name}\nVáš věk je: {age}\nChodíte do školy: {school}\nVaše záliby jsou: {hobby}\n\nDěkujeme za vyplnění dotazníku!");
