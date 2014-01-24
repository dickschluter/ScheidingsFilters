using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScheidingsFilters
{
    class FrequentieKarakteristiek : PictureBox
    {
        int fMin = 20;
        int aantalDecaden = 3;
        bool toonFase;

        int breedte = 1049; // Standaardbereik: 96 px/oktaaf --> 3 * 96 + 32 = 320 px/decade --> 3 * 320 + 1 + 2 * 32 = 1025 px
        int hoogte = 750;
        int breedteZijRand = 44;
        int maxDB = 9;
        int minDB = -36;
        int pixelsPerDB = 15;

        Bitmap bitmapLegeGrafiek, bitmapGrafiek;
        Pen groenePen = new Pen(Color.Green);
        Pen lichtgroenePen = new Pen(Color.FromArgb(0, 192, 0));
        Pen rodePen = new Pen(Color.Red);
        SolidBrush witteKwast = new SolidBrush(Color.White);

        NumericUpDown numericStartFrequentie, numericAantalDecaden;
        CheckBox checkBoxToonFase;

        public FrequentieKarakteristiek()
        {
            this.BackColor = Color.Black;
            this.Size = new Size(breedte, hoogte);
            bitmapLegeGrafiek = new Bitmap(breedte, hoogte);
            maakLegeGrafiek();

            numericStartFrequentie = new NumericUpDown();
            numericStartFrequentie.Location = new Point(280, 710);
            numericStartFrequentie.Size = new Size(50, 20);
            numericStartFrequentie.BackColor = Color.Black;
            numericStartFrequentie.ForeColor = Color.White;
            numericStartFrequentie.Minimum = 10;
            numericStartFrequentie.Maximum = 1000;
            numericStartFrequentie.Value = 20;
            numericStartFrequentie.ValueChanged += new EventHandler(numericStartFrequentie_ValueChanged);
            this.Controls.Add(numericStartFrequentie);

            numericAantalDecaden = new NumericUpDown();
            numericAantalDecaden.Location = new Point(480, 710);
            numericAantalDecaden.Size = new Size(50, 20);
            numericAantalDecaden.BackColor = Color.Black;
            numericAantalDecaden.ForeColor = Color.White;
            numericAantalDecaden.Minimum = 1;
            numericAantalDecaden.Maximum = 4;
            numericAantalDecaden.Value = 3;
            numericAantalDecaden.ValueChanged += new EventHandler(numericAantalDecaden_ValueChanged);
            this.Controls.Add(numericAantalDecaden);

            for (int i = 0; i < 2; i++)
            {
                Label label = new Label();
                label.Location = new Point(337 + 200 * i, 713);
                label.ForeColor = Color.White;
                label.Text = i == 0 ? "Startfrequentie" : "Aantal decaden";
                this.Controls.Add(label);
            }

            checkBoxToonFase = new CheckBox();
            checkBoxToonFase.Location = new Point(680, 710);
            checkBoxToonFase.BackColor = Color.Black;
            checkBoxToonFase.ForeColor = Color.White;
            checkBoxToonFase.Text = "Toon fase";
            checkBoxToonFase.CheckedChanged += new EventHandler(checkBoxToonFase_CheckedChanged);
            this.Controls.Add(checkBoxToonFase);
        }

        void numericStartFrequentie_ValueChanged(object sender, EventArgs e)
        {
            int[] waarden = { 10, 20, 50, 100, 200, 500, 1000 };
            int index = 0;
            while (waarden[index] < fMin)
                index++;

            if (numericStartFrequentie.Value > fMin) // verhogen
                numericStartFrequentie.Value = waarden[index + 1];
            else
                numericStartFrequentie.Value = waarden[index - 1];

            fMin = (int)numericStartFrequentie.Value;
            maakLegeGrafiek();
            TekenCurves(OverdrachtsFuncties.Lijst);
        }

        void numericAantalDecaden_ValueChanged(object sender, EventArgs e)
        {
            aantalDecaden = (int)numericAantalDecaden.Value;
            maakLegeGrafiek();
            TekenCurves(OverdrachtsFuncties.Lijst);
        }

        void checkBoxToonFase_CheckedChanged(object sender, EventArgs e)
        {
            toonFase = checkBoxToonFase.Checked;
            maakLegeGrafiek();
            TekenCurves(OverdrachtsFuncties.Lijst);
        }

        void maakLegeGrafiek()
        {
            Font letter8pt = new Font("Microsoft Sans Serif", 8f);
            Pen lijnenPen;

            using (Graphics graphics = Graphics.FromImage(bitmapLegeGrafiek))
            {
                graphics.Clear(Color.Black);
                // verticale lijnen 
                foreach (var lijn in Iterators.frequentieLijnen(fMin, aantalDecaden, breedte - 2 * breedteZijRand))
                {
                    graphics.DrawLine(groenePen, breedteZijRand + lijn.Item1, 0, breedteZijRand + lijn.Item1, (maxDB - minDB) * pixelsPerDB);
                    if (lijn.Item2 != null)
                    {
                        int xPositie = breedteZijRand + lijn.Item1 - (3 * lijn.Item2.Length + 1);
                        graphics.DrawString(lijn.Item2, letter8pt, witteKwast, xPositie, (maxDB - minDB) * pixelsPerDB + 6);
                    }
                }
                // horizontale lijnen
                for (int dB = minDB; dB <= maxDB; dB++)
                {
                    int yPositie = (maxDB - dB) * pixelsPerDB;
                    lijnenPen = groenePen;
                    if (dB == 0)
                        lijnenPen = rodePen;
                    else if (toonFase && dB == -18)
                        lijnenPen = lichtgroenePen;
                    graphics.DrawLine(lijnenPen, breedteZijRand + 1, yPositie, breedte - breedteZijRand - 2, yPositie);
                    if (dB % 2 == 0)
                    {
                        int xPositieTekst = 34 - 6 * dB.ToString().Length;
                        if (dB < 0)
                            xPositieTekst += 2;
                        graphics.DrawString(dB.ToString(), letter8pt, witteKwast, xPositieTekst, yPositie - 7); // linker dB-schaal
                        if (toonFase == false)
                            graphics.DrawString(dB.ToString(), letter8pt, witteKwast, breedte - breedteZijRand - 13 + xPositieTekst, yPositie - 7); // rechter dB-schaal
                    }
                    if (toonFase && dB % 3 == 0 && dB <= 0)
                    {
                        int fase = (dB + 18) * 10;
                        int xPositieFaseTekst = breedte - breedteZijRand + 24 - 6 * fase.ToString().Length;
                        if (fase < 0)
                            xPositieFaseTekst += 2;
                        graphics.DrawString(fase.ToString(), letter8pt, witteKwast, xPositieFaseTekst, yPositie - 7); // fase-schaal
                    }
                }
            }
            this.Image = bitmapLegeGrafiek;
        }

        public void TekenCurves(List<Tuple<FuncFnaarComplex, Color>> tuples)
        {
            bitmapGrafiek = new Bitmap(bitmapLegeGrafiek);
            
            foreach (var tuple in tuples)
            {
                Func<double, Complex> functie = tuple.Item1.Functie;
                Color curveKleur = tuple.Item2;
                int xPositie = breedteZijRand;
                foreach (double f in Iterators.FrequentieReeks(fMin, aantalDecaden, 288 / aantalDecaden))
                {
                    Complex functieWaarde = functie(f);
                    double dB = functieWaarde.ModulusInDB;
                    if (dB >= minDB && dB <= maxDB)
                    {
                        int yPositie = (int)((maxDB - dB) * pixelsPerDB);
                        bitmapGrafiek.SetPixel(xPositie, yPositie, curveKleur);
                    }
                    if (toonFase)
                    {
                        double fase = functieWaarde.Fase;
                        int yPositie = maxDB * pixelsPerDB + (int)((180 - fase) * 1.5);
                        bitmapGrafiek.SetPixel(xPositie, yPositie, curveKleur);
                    }
                    xPositie++;
                }
            }

            this.Image = bitmapGrafiek;
        }
    }
}
