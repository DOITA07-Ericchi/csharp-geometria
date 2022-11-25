using System;
namespace Geometria {
    public class Rettangolo {
        public int baseRettangolo;
        public int altezzaRettangolo;

        public int calcolaPerimetro(int rBase, int rAltezza) {
            return ((rBase * 2) + (rAltezza * 2));
        }
        public int calcolaArea(int rBase, int rAltezza) {
            return (rBase * rAltezza);
        }
        public string disegna(int rBase, int rAltezza) {
            string k = ""
        }
    }
}

