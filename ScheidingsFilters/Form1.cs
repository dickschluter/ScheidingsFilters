using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScheidingsFilters
{
    public partial class Form1 : Form
    {
        FrequentieKarakteristiek frequentieKarakteristiek = new FrequentieKarakteristiek();
        TextBox[] textBoxCoefficientLP = new TextBox[3];
        TextBox[] textBoxCoefficientHP = new TextBox[3];

        public Form1()
        {
            InitializeComponent();
            this.Controls.Add(frequentieKarakteristiek);

            for (int i = 0; i < 3; i++)
            {
                textBoxCoefficientLP[i] = new TextBox();
                textBoxCoefficientLP[i].Size = new Size(50, 20);
                textBoxCoefficientLP[i].Location = new Point(160, 30 + 30 * i);
                textBoxCoefficientLP[i].Enabled = false;
                textBoxCoefficientLP[i].Text = "1";
                groupBoxLP.Controls.Add(textBoxCoefficientLP[i]);

                textBoxCoefficientHP[i] = new TextBox();
                textBoxCoefficientHP[i].Size = new Size(50, 20);
                textBoxCoefficientHP[i].Location = new Point(160, 30 + 30 * i);
                textBoxCoefficientHP[i].Enabled = false;
                textBoxCoefficientHP[i].Text = "1";
                groupBoxHP.Controls.Add(textBoxCoefficientHP[i]);
            }
        }

        private void numericUpDownOrdeLP_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                textBoxCoefficientLP[i].Enabled = i + 1 < numericUpDownOrdeLP.Value;
        }

        private void numericUpDownOrdeHP_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                textBoxCoefficientHP[i].Enabled = i + 1 < numericUpDownOrdeHP.Value;
        }

        private void ToonCurves(object sender, EventArgs e)
        {
            double f;
            double.TryParse(textBoxFrequentieLP.Text, out f);
            if (f < 10) // zinvol minimum
            {
                f = 10;
                textBoxFrequentieLP.Text = "10";
            }
            int orde = (int)numericUpDownOrdeLP.Value;
            double[] coefficienten = new double[orde - 1];
            for (int i = 0; i < orde - 1; i++)
            {
                double.TryParse(textBoxCoefficientLP[i].Text, out coefficienten[i]);
                if (coefficienten[i] < 0.1) // zinvol minimum
                {
                    coefficienten[i] = 0.1;
                    textBoxCoefficientLP[i].Text = (0.1).ToString();
                }
            }
            FuncFnaarComplex lp = TargetFuncties.GeneriekeLP(f, orde, coefficienten);

            double.TryParse(textBoxFrequentieHP.Text, out f);
            if (f < 10) // zinvol minimum
            {
                f = 10;
                textBoxFrequentieHP.Text = "10";
            }
            orde = (int)numericUpDownOrdeHP.Value;
            coefficienten = new double[orde - 1];
            for (int i = 0; i < orde - 1; i++)
            {
                double.TryParse(textBoxCoefficientHP[i].Text, out coefficienten[i]);
                if (coefficienten[i] < 0.1) // zinvol minimum
                {
                    coefficienten[i] = 0.1;
                    textBoxCoefficientHP[i].Text = (0.1).ToString();
                }
            }
            FuncFnaarComplex hp = TargetFuncties.GeneriekeHP(f, orde, coefficienten);

            OverdrachtsFuncties.Verversen();
            if (checkBoxTonenLP.Checked)
                OverdrachtsFuncties.Toevoegen(lp, Color.Orange);
            if (checkBoxTonenHP.Checked)
                OverdrachtsFuncties.Toevoegen(hp, Color.Yellow);
            if (checkBoxTonenSom.Checked)
                OverdrachtsFuncties.Toevoegen(lp + hp, Color.Silver);
            if (checkBoxTonenVerschil.Checked)
                OverdrachtsFuncties.Toevoegen(lp - hp, Color.Fuchsia);

            frequentieKarakteristiek.TekenCurves(OverdrachtsFuncties.Lijst);
        }
    }
}
