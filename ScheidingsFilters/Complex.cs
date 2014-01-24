using System;
using System.Collections.Generic;
using System.Text;

namespace ScheidingsFilters
{
    public struct Complex
    // representeert complex getal
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public bool IsNul { get { return (X == 0 && Y == 0); } }

        public double Modulus
        {
            get { return Math.Sqrt(X * X + Y * Y); }
        }

        public double ModulusInDB
        {
            get { return 20 * Math.Log10(Math.Sqrt(X * X + Y * Y)); }
        }

        // fase in graden tussen -180 en 180
        public double Fase
        {
            get
            {
                if (X == 0)
                {
                    if (Y > 0)
                        return 90.0;
                    if (Y < 0)
                        return -90.0;
                    return 0;
                }

                double fase = Math.Atan(Y / X) * 180 / Math.PI;
                if (X < 0) fase = fase + 180;
                if (fase > 180) fase = fase - 360;
                return fase;
            }
        }

        public Complex(double x, double y)
            : this()
        {
            X = x;
            Y = y;
        }

        public static Complex Nul = new Complex();

        public static Complex UitModulusFase(double mod, double fase)
        {
            return new Complex(mod * Math.Cos(fase * Math.PI / 180), mod * Math.Sin(fase * Math.PI / 180));
        }

        public static implicit operator Complex(double x)
        {
            return new Complex(x, 0);
        }

        public static Complex operator +(Complex c1, Complex c2) // Optellen
        {
            return new Complex(c1.X + c2.X, c1.Y + c2.Y);
        }

        public static Complex operator -(Complex c1, Complex c2) // Aftrekken
        {
            return new Complex(c1.X - c2.X, c1.Y - c2.Y);
        }

        public static Complex operator *(Complex c1, Complex c2) // Vermenigvuldigen
        {
            double x = c1.X * c2.X - c1.Y * c2.Y;
            double y = c1.X * c2.Y + c1.Y * c2.X;
            return new Complex(x, y);
        }

        public static Complex operator /(Complex c1, Complex c2) // Delen
        {
            if (c2.IsNul)
                throw new DivideByZeroException("Noemer is nul");

            double noemer = c2.X * c2.X + c2.Y * c2.Y;
            double x = (c1.X * c2.X + c1.Y * c2.Y) / noemer;
            double y = (c1.Y * c2.X - c1.X * c2.Y) / noemer;
            return new Complex(x, y);
        }
    }
}
