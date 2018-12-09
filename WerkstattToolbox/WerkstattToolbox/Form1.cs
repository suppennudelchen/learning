using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerkstattToolbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Drehzahl Berechnen Button
        private void Btn_Berechne_Drehzahl_Click(object sender, EventArgs e)
        {
            try
            {
                double durchmesser = Convert.ToDouble(textBox_Durchmesser.Text);
                double schnittgeschwindigkeit = Convert.ToDouble(textBox_Schnittgeschwindigkeit.Text);

                Ausgabe_Drehzahl.Text = ZerspanungFormeln.Drehzahl_n(durchmesser, schnittgeschwindigkeit).ToString("0");
            }
            catch
            {
                Ausgabe_Drehzahl.Text = "Fehler!";
            }
        }

        private void Btn_Berechne_Vorschub_Click(object sender, EventArgs e)
        {
            try
            {
                double anzahlZaehne = Convert.ToDouble(textBox_AnzahlZaehne.Text);
                double vorschubProZahn = Convert.ToDouble(textBox_VorschubProZahn.Text);
                double durchmesser = Convert.ToDouble(textBox_Durchmesser.Text);
                double schnittgeschwindigkeit = Convert.ToDouble(textBox_Schnittgeschwindigkeit.Text);

                Ausgabe_Vorschub.Text = ZerspanungFormeln.Vorschubgeschwindigkeit_Vf(vorschubProZahn, anzahlZaehne, ZerspanungFormeln.Drehzahl_n(durchmesser, schnittgeschwindigkeit)).ToString("0");
            }
            catch
            {
                Ausgabe_Vorschub.Text = "Fehler!";
            }

        }

        private void ButtonBerechneDrehzahl_Click(object sender, EventArgs e)
        {

        }
    }
}
