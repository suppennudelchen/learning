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

        private void button_Berechnen_1_Click(object sender, EventArgs e)
        {
            ErrorBox.Text = "";
            try
            {
                double durchmesser = Convert.ToDouble(textBox_Durchmesser.Text);
                double schnittgeschwindigkeit = Convert.ToDouble(textBox_Schnittgeschwindigkeit.Text);
                double anzahlZaehne = Convert.ToDouble(textBox_AnzahlZaehne.Text);
                double vorschubProZahn = Convert.ToDouble(textBox_VorschubProZahn.Text);

                Ausgabe_Drehzahl.Text = ZerspanungFormeln.Drehzahl_n(durchmesser, schnittgeschwindigkeit).ToString("0");
                Ausgabe_Vorschub.Text = ZerspanungFormeln.Vorschubgeschwindigkeit_Vf(vorschubProZahn, anzahlZaehne, ZerspanungFormeln.Drehzahl_n(durchmesser, schnittgeschwindigkeit)).ToString("0");
            }
            catch (DivideByZeroException)
            {
                ErrorBox.Text = "Division durch Null. Eingaben überprüfen.";
                return;
            }
            catch
            {
                ErrorBox.Text = "Bitte Eingaben überprüfen.";
            }
        }



        
    }
}
