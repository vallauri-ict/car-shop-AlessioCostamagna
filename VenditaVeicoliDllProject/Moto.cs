using System;

namespace VenditaVeicoliDllProject
{
    [Serializable()]
    public class Moto:Veicolo
    {
        public Moto(string targa,string marca, string modello, string versione,
            int cilindrata, string tipoVeicolo, string tipologia, int km, DateTime immatricolazione, double prezzo) 
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
            
        }

        public override string ToString()
        {
            return $"Moto: {base.ToString()}";
        }
    }
}
