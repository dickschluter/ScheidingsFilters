using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ScheidingsFilters
{
    static class OverdrachtsFuncties // verzamelt alle overdrachtsfuncties die op gegeven moment berekend moeten worden
    {
        public static List<Tuple<FuncFnaarComplex, Color>> Lijst = new List<Tuple<FuncFnaarComplex, Color>>();

        public static void Verversen()
        {
            Lijst.Clear();
        }

        public static void Toevoegen(FuncFnaarComplex func, Color curveKleur)
        {
            Lijst.Add(new Tuple<FuncFnaarComplex,Color>(func, curveKleur));
        }
    }
}
