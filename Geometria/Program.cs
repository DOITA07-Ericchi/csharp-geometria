using Geometria;

Rettangolo rettangolo = new Rettangolo();
Console.Write("Inserisci la base: ");
bool valid = false;
while (valid == false)
{
    try {
        rettangolo.baseRettangolo = int.Parse(Console.ReadLine());
        valid = true;
    }
    catch {
        Console.Write("Errore. Inserisci di nuovo la base: ");
    }
}
Console.Write("Inserisci l'altezza: ");
valid = false;
while (valid == false)
{
    try {
        rettangolo.altezzaRettangolo = int.Parse(Console.ReadLine());
        valid = true;
    }
    catch {
        Console.Write("Errore. Inserisci di nuovo l'altezza: ");
    }
}
rettangolo.stampaRettangolo();


Rettangolo rettangolo2 = new Rettangolo();
rettangolo2.baseRettangolo = 5;
rettangolo2.altezzaRettangolo = 6;

Rettangolo rettangolo3 = new Rettangolo();
rettangolo3.baseRettangolo = 3;
rettangolo3.altezzaRettangolo = 7;

Console.WriteLine("Eccoti altri rettangoli:");
rettangolo2.stampaRettangolo();
rettangolo3.stampaRettangolo();

Console.Write("Premi Invio per uscire.");
Console.ReadLine();