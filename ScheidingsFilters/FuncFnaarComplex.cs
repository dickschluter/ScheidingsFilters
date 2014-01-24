using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheidingsFilters
{
    // Basisklasse van alle netwerk-componenten 
    // is een inkapseling van een Func<double, Complex>
    // die een complexe waarde als functie van de frequentie kan berekenen
    // inkapseling is nodig om operatoren te definieren
    class FuncFnaarComplex
    {
        public Func<double, Complex> Functie { get; private set; }

        public FuncFnaarComplex(Func<double, Complex> functie)
        {
            this.Functie = functie;
        }

        public static FuncFnaarComplex operator +(FuncFnaarComplex func1, FuncFnaarComplex func2)
        {
            return new FuncFnaarComplex(f => func1.Functie(f) + func2.Functie(f));
        }

        public static FuncFnaarComplex operator -(FuncFnaarComplex func1, FuncFnaarComplex func2)
        {
            return new FuncFnaarComplex(f => func1.Functie(f) - func2.Functie(f));
        }

        public static FuncFnaarComplex operator *(FuncFnaarComplex func1, FuncFnaarComplex func2)
        {
            return new FuncFnaarComplex(f => func1.Functie(f) * func2.Functie(f));
        }

        public static FuncFnaarComplex operator /(FuncFnaarComplex func1, FuncFnaarComplex func2)
        {
            return new FuncFnaarComplex(f => func1.Functie(f) / func2.Functie(f));
        }

        public static FuncFnaarComplex operator |(FuncFnaarComplex func1, FuncFnaarComplex func2) // parallelschakeling
        {
            return new FuncFnaarComplex(f =>
                func1.Functie(f).IsNul || func2.Functie(f).IsNul ?
                Complex.Nul :
                (func1.Functie(f) * func2.Functie(f)) / (func1.Functie(f) + func2.Functie(f)));
        }
    }
}
