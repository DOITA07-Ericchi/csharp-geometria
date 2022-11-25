using Geometria;

Rettangolo rettangolo = new Rettangolo();
Console.Write("Inserisci la base: ");
rettangolo.baseRettangolo = int.Parse(Console.ReadLine());
Console.Write("Inserisci l'altezza: ");
rettangolo.altezzaRettangolo = int.Parse(Console.ReadLine());

int area = rettangolo.calcolaArea(rettangolo.baseRettangolo, rettangolo.altezzaRettangolo);
int perimetro = rettangolo.calcolaPerimetro(rettangolo.baseRettangolo, rettangolo.altezzaRettangolo);

Console.WriteLine($"Area: {area}\tPerimetro: {perimetro}");

Console.Write("Premi Invio per uscire.");
Console.ReadLine();