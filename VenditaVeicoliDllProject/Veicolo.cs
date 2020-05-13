using System;
using System.Xml.Serialization;

namespace VenditaVeicoliDllProject
{
    [Serializable()]
    [XmlInclude(typeof(Moto))]
    [XmlInclude(typeof(Auto))]
    public abstract class Veicolo
    {

        #region fields
        private string targa;
        private string marca;
        private string modello;
        private string versione;
        private int cilindrata;
        private string tipoVeicolo;
        private string tipologia;
        private int km;
        private DateTime immatricolazione;
        private double prezzo;
        #endregion

        public Veicolo() { }

        public Veicolo(string targa,string marca, string modello, string versione, int cilindrata, string tipoVeicolo, string tipologia, int km, DateTime immatricolazione, double prezzo)
        {
            this.Targa = targa;
            this.Marca = marca;
            this.Modello = modello;
            this.Versione = versione;
            this.Cilindrata = cilindrata;
            this.TipoVeicolo = tipoVeicolo;
            this.Tipologia = tipologia;
            this.Km = km;
            this.Immatricolazione = immatricolazione;
            this.Prezzo = prezzo;
        }

        public string Targa { get => targa; set => targa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modello { get => modello; set => modello = value; }
        public string Versione { get => versione; set => versione = value; }
        public int Cilindrata { get => cilindrata; set => cilindrata = value; }
        public string TipoVeicolo { get => tipoVeicolo; set => tipoVeicolo = value; }
        public string Tipologia { get => tipologia; set => tipologia = value; }
        public int Km { get => km; set => km = value; }
        public DateTime Immatricolazione { get => immatricolazione; set => immatricolazione = value; }
        public double Prezzo { get => prezzo; set => prezzo = value; }

        public override string ToString()
        {
            return $"{this.Marca} {this.Modello} ({this.Immatricolazione.Year})"; 
        }

    }
}
