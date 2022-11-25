using System;
namespace Geometria {
    public class Rettangolo {
        public int baseRettangolo;
        public int altezzaRettangolo;

        public int calcolaPerimetro() {
            return ((baseRettangolo * 2) + (altezzaRettangolo * 2));
        }
        public int calcolaArea() {
            return (baseRettangolo * altezzaRettangolo);
        }
        public string stampaRettangolo() {
            int area = calcolaArea();
            int perimetro = calcolaPerimetro();
            string output = $"Area: {area}\tPerimetro: {perimetro}";
            Console.WriteLine(output);
            return output;
        }
    }
}

