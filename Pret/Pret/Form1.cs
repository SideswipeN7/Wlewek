using System;
using System.Windows.Forms;

namespace Pret
{
    public partial class Form1 : Form
    {
        private static double vWalca = 5977.59;
        private static double vStozka = 8946.26;
        private double wysokoscWlewka;
        private double vNaddatku;
        private double lPreta;
        private double vWlewka;
        private double vWlewkaMojego;
        private double pMatrycy;
        private double h;
        private double r;
        private bool pret = true;
        private int ksztalt = 1;

        public Form1()
        {
            InitializeComponent();
            lbRod.Text = "Długośc pręta wynosi:  [mm]";
            lbPole.Text = "Średnica przekroju matrycy";
            ClearData();
        }

        private void LiczPret()
        {
            double uzyteczne = vWlewka - (vWalca + vStozka + vNaddatku);
            lPreta = uzyteczne / pMatrycy;
        }

        private void LiczWlewek()
        {
            double uzyteczne = lPreta * pMatrycy;
            vWlewkaMojego = uzyteczne + vWalca + vStozka + vNaddatku;
            wysokoscWlewka = vWlewkaMojego / (Math.PI*(Math.Pow(r,2)/4));
            string s = String.Format("Maksymalna wysokość wlewka: {0:N1} mm", wysokoscWlewka);
            lbUzysk.Text = s;
        }

        private void LiczNaddatek()
        {
            vNaddatku = pMatrycy * 17.10;
        }

        private void LiczUzysk()
        {
            double u = ((vWlewka - (vNaddatku + vWalca + vStozka)) / vWlewka) * 100;
            string s = String.Format("Uzysk: {0:N1} %", u);
            lbUzysk.Text = s;
        }

        private void txDim_TextChanged(object sender, EventArgs e)
        {
            double liczba;


            if (double.TryParse(txPole.Text, out liczba) && double.TryParse(txProm.Text, out r) && double.TryParse(txWys.Text, out h))
            {
                vWlewka = h * (Math.PI * (Math.Pow(r, 2) / 4));
                switch (ksztalt)
                {
                    case 1: pMatrycy = (Math.PI * (Math.Pow(liczba, 2) / 4)); break;
                    case 2: pMatrycy = ((Math.Pow(liczba, 2) * Math.Sqrt(3)) / 4); break;
                    case 3: pMatrycy = Math.Pow(liczba, 2); break;
                    case 4: pMatrycy = liczba; break;
                }
                LiczNaddatek();

                if (pret)
                {
                    LiczPret();
                    LiczUzysk();
                    string s = String.Format("Długość pręta wynosi: {0:N1} mm", lPreta);
                    lbRod.Text = s;
                }
                else
                {
                    lPreta = h;
                    LiczWlewek();
                    string s = String.Format("Objętość wlewka wynosi: {0:N1} mm3", vWlewkaMojego);
                    lbRod.Text = s;

                }
            }

        }

        private void rdWheel_CheckedChanged(object sender, EventArgs e)
        {
            lbPole.Text = "Średnica przekroju matrycy";
            lbDim2.Text = " mm";
            ksztalt = 1;
            ClearData();
        }

        private void rdTriangle_CheckedChanged(object sender, EventArgs e)
        {
            lbPole.Text = "Długość boku trójkąta";
            lbDim2.Text = " mm";
            ksztalt = 2;
            ClearData();
        }

        private void rdSquare_CheckedChanged(object sender, EventArgs e)
        {
            lbPole.Text = "Długość boku kwadratu";
            lbDim2.Text = " mm";
            ksztalt = 3;
            ClearData();
        }

        private void rdAll_CheckedChanged(object sender, EventArgs e)
        {
            lbPole.Text = "Pole przekroju otoworu matrycy";
            lbDim2.Text = " mm2";
            ksztalt = 4;
            ClearData();
        }

        private void rdLicz1_CheckedChanged(object sender, EventArgs e)
        {
            pret = true;
            lnWys.Text = "Wysokość Wlewka";
            lbDimension.Text = " mm";
            lbRod.Text = "Długość pręta wynosi:  mm";
            lbUzysk.Text = ("Uzysk:  %");
            ClearData();
        }

        private void rdLicz2_CheckedChanged(object sender, EventArgs e)
        {
            pret = false;
            lnWys.Text = "Długość pręta";
            lbDimension.Text = " mm";
            lbRod.Text = "Objętość wlewka wynosi:  mm3";
            lbUzysk.Text = "Maksymalna wysokość wlewka:  mm";
            ClearData();
        }

        private void ClearData()
        {
            txPole.Text = "";
            txProm.Text = "";
            txWys.Text = "";

            if (pret)
            {
                lbUzysk.Text = ("Uzysk:  %");
                lbRod.Text = "Długość pręta wynosi:  mm";

            }
            else
            {
                lbUzysk.Text = "Maksymalna wysokość wlewka:  mm";
                lbRod.Text = "Objętość wlewka wynosi:  mm3";

            }
        }
    }
}