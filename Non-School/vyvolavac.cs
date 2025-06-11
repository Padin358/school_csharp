Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Vyvolávač 3000\n");
Console.ResetColor();
Console.WriteLine("Kolik žáků je ve vaší třídě");
var fullNum = Console.ReadLine();
Console.WriteLine("Kolik žáků si přejete vyvolat?");
var repeatNum = Console.ReadLine();
int i = 0;
while (i < Int32.Parse(repeatNum))
{
    i = i + 1;
    Console.WriteLine("Vyvolán bude Kuba Olšanský!");
}
Console.WriteLine("Jste spokojen/a s výsledkem?\n(ano/ne/možná)");
var result = Console.ReadLine().ToLower();
if (result == "ano")
{
    Console.WriteLine("Jsme rádi že jste s výsledkem spokojeni a doufáme, že náš program využijete znovu!\nITMH a.s.");
} else if (result == "ne")
{
    Console.WriteLine("Mrzí nás, že nejste spokojeni s výsledkem. Prosím, napište nám na email níže co se vám nelíbilo a my se to pokusíme opravit.\nblackdragons.official@email.cz\nITMH a.s.");
} else if (result == "možná")
{
    Console.WriteLine("Jak jako možná kurva? Rozhodni se vole! Všechno znova!!!\nITMH a.s.");
}
