using System;

namespace VenditaVeicoliDllProject
{

    [Serializable()]
    public class Auto : Veicolo
    {
        private string carburante;
        public Auto(string targa, string marca, string modello, string versione,
            int cilindrata, string tipoVeicolo, string tipologia, int km, DateTime immatricolazione, string carburante, double prezzo) 
            : base(
                targa,
                marca,
                modello,
                versione,
                cilindrata,
                tipoVeicolo,
                tipologia,
                km,
                immatricolazione,
                prezzo)
        {
            this.Carburante = carburante; 
        }

        public string Carburante { get => carburante; set => carburante = value; }

        public override string ToString()
        {
            return $"Auto: {base.ToString()} - {this.Carburante}" ;
        }

    }
}
