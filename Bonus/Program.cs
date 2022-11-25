using Geometria;

Rettangolo rettangolo = new Rettangolo();
Console.Write("Inserisci la base: ");
rettangolo.baseRettangolo = int.Parse(Console.ReadLine());
Console.Write("Inserisci l'altezza: ");
rettangolo.altezzaRettangolo = int.Parse(Console.ReadLine());
rettangolo.stampaRettangolo();

Console.WriteLine("Ecco il disegno del tuo rettangolo: ");
rettangolo.disegna();

Console.Write("Premi Invio per uscire.");
Console.ReadLine();