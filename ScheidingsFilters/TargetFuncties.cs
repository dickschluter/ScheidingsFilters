using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheidingsFilters
{
    // retourneert FuncFnaarComplex die theoretische doelkarakteristiek kan berekenen
    static class TargetFuncties
    {
        public static FuncFnaarComplex GeneriekeLP(double f0, int orde, params double[] coefficienten)
        {
            if (coefficienten.Length != orde - 1)
                throw new ArgumentException("Aantal coefficienten onjuist");

            Func<double, Complex> functie =
                f =>
                {
                    double fRel = f / f0; // relatieve frequentie
                    double fMacht = 1.0; // macht van de relatieve frequentie
                    double product = 0.0; // term in de noemer

                    double xNoemer = 1.0, yNoemer = 0.0; // accumulatie van de noemer
                    for (int macht = 1; macht <= orde; macht++)
                    {
                        fMacht *= fRel;
                        int teken = macht / 2 % 2 == 0 ? 1 : -1; // optellen bij 0,1, aftrekken bij 2,3, etc
                        double coefficient = macht < orde ? coefficienten[macht - 1] : 1;
                        product = teken * coefficient * fMacht;
                        if (macht % 2 == 0)
                            xNoemer += product;
                        else
                            yNoemer += product;
                    }

                    return 1 / new Complex(xNoemer, yNoemer);
                };

            return new FuncFnaarComplex(functie);
        }

        public static FuncFnaarComplex GeneriekeHP(double f0, int orde, params double[] coefficienten)
        {
            if (coefficienten.Length != orde - 1)
                throw new ArgumentException("Aantal coefficienten onjuist");

            Func<double, Complex> functie =
                f =>
                {
                    double fRel = f / f0; // relatieve frequentie
                    double fMacht = 1.0; // macht van de relatieve frequentie
                    double product = 0.0; // term in de noemer en in de teller

                    double xNoemer = 1.0, yNoemer = 0.0; // accumulatie van de noemer
                    for (int macht = 1; macht <= orde; macht++)
                    {
                        fMacht *= fRel;
                        int teken = macht / 2 % 2 == 0 ? 1 : -1; // optellen bij 0,1, aftrekken bij 2,3, etc
                        double coefficient = macht < orde ? coefficienten[macht - 1] : 1;
                        product = teken * coefficient * fMacht;
                        if (macht % 2 == 0)
                            xNoemer += product;
                        else
                            yNoemer += product;
                    }

                    Complex teller = orde % 2 == 0 ? new Complex(product, 0) : new Complex(0, product);

                    return teller / new Complex(xNoemer, yNoemer);
                };

            return new FuncFnaarComplex(functie);
        }
    }
}
