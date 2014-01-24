using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheidingsFilters
{
    static class Iterators
        // iterators t.b.v. FrequentieKarakteristiek
    {
        public static IEnumerable<double> FrequentieReeks(int fMin, int aantalDecaden, int stappenPerOctaaf) // 961 iteraties; fMin = 1, 2, 5, 10, 20 enz.  
        {
            double factor = Math.Pow(2.0, 1.0 / stappenPerOctaaf);
            double factorTussen4en5 = Math.Pow(1.25, 3.0 / stappenPerOctaaf);

            int fractieF = fMin;
            int exponentF = 0;
            while (fractieF >= 10)
            {
                fractieF /= 10;
                exponentF++;
            }

            int octavenEersteIteratie = 2; // als fractieF = 1
            if (fractieF == 2)
                octavenEersteIteratie = 1;
            else if (fractieF == 5)
            {
                octavenEersteIteratie = 3;
                exponentF++;
            }

            double f = fMin;
            for (int decade = 0; decade < aantalDecaden; decade++)
            {
                for (int i = 0; i < octavenEersteIteratie * stappenPerOctaaf; i++)
                {
                    yield return f;
                    f *= factor;
                }

                for (int i = 0; i < stappenPerOctaaf / 3; i++)
                {
                    yield return f;
                    f *= factorTussen4en5;
                }

                f = 5 * Math.Pow(10, exponentF);
                exponentF++;

                for (int i = 0; i < (3 - octavenEersteIteratie) * stappenPerOctaaf; i++)
                {
                    yield return f;
                    f *= factor;
                }
            }
            yield return f;
        }

        // retourneert het aantal pixels vanaf de eerste frequentielijn en het bijschrift
        public static IEnumerable<Tuple<int, string>> frequentieLijnen(int fMin, int aantalDecaden, int breedteGrafiek)
        {
            int exponentF = (int)Math.Floor(Math.Log10(fMin));
            int fractieF = fMin / (int)Math.Pow(10, exponentF);
            double pixelsPerDecade = (breedteGrafiek - 1) / aantalDecaden;

            int f = fMin;
            while (f <= fMin * Math.Pow(10, aantalDecaden))
            {
                int xPositie = (int)(Math.Log10((double)f / (double)fMin) * pixelsPerDecade + 0.5);
                string bijschrift = null;
                if (fractieF == 1 || fractieF == 2 || fractieF == 5)
                {
                    if (exponentF >= 6)
                        bijschrift = (f / 1000000).ToString() + "M";
                    else if (exponentF >= 3)
                        bijschrift = (f / 1000).ToString() + "k";
                    else
                        bijschrift = f.ToString();
                }
                yield return new Tuple<int, string>(xPositie, bijschrift);

                fractieF++;
                f = fractieF * (int)Math.Pow(10, exponentF);
                if (fractieF == 10)
                {
                    exponentF++;
                    fractieF = 1;
                }
            }
        }
    }
}
