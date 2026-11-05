using System;
using System.Collections.Generic;
using System.Text;

namespace MuzeumApp
{
    internal class Festmeny : Mutargy
    {
        public int KorEvekben { get; set; }
        public Festmeny(string azonosito, int becsultErtek, int KorEvekben) : base(azonosito, becsultErtek)
        {
            this.KorEvekben = KorEvekben;
        }
        public override int BiztositasDij()
        {
            return (int)(base.BiztositasiDij() + KorEvekben * 500);
        }
        public override string ToString()
        {
            return (base.ToString()) + $" | Kor: {KorEvekben} év";
        }
    }
}
