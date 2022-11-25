using Geometria;

Rettangolo rettangolo = new Rettangolo();
Console.Write("Inserisci la base: ");
bool valid = false;
while (valid == false) {
    try {
        rettangolo.baseRettangolo = int.Parse(Console.ReadLine());
        valid = true;
    } catch {
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

Console.WriteLine("Ecco il disegno del tuo rettangolo: ");
rettangolo.disegna();

Console.Write("Premi Invio per uscire.");
Console.ReadLine();