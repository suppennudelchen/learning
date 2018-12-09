using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerkstattToolbox
{
    public static class ZerspanungFormeln
    {

        //statische Klasse, Keyword static
        // Das ist der Commit 99
        
        //Schnittgeschwindigkeit Vc
        public static double Schnittgeschwindigkeit_Vc(double durchmesser, double drehzahl)
        {
            return ((durchmesser * Math.PI * drehzahl) / 1000);
        }

        //Drehzahl n
        public static double Drehzahl_n(double durchmesser, double schnittgeschwindigkeit)
        {
            return ((schnittgeschwindigkeit * 1000) / (Math.PI * durchmesser));
        }

        //Vorschubgeschwindigkeit Vf
        public static double Vorschubgeschwindigkeit_Vf(double vorschubProZahn, double anzahlZaehne, double drehzahl)
        {
            return (vorschubProZahn * anzahlZaehne * drehzahl);
        }

        //Vorschub pro Zahn fz
        public static double VorschubProZahn_fz(double vorschubgeschwindigkeit, double anzahlZaehne, double drehzahl)
        {
            return (vorschubgeschwindigkeit / (anzahlZaehne * drehzahl));
        }

        //Effektiver fz bei ae bis 0.25*d
        public static double VorschubProZahn_fz_effektiv(double vorschubgeschwindigkeit, double anzahlZaehne, double drehzahl, double durchmesser, double ae)
        {
            return (vorschubgeschwindigkeit / (anzahlZaehne * drehzahl) * Math.Sqrt(durchmesser / ae));
        }
    }
}
