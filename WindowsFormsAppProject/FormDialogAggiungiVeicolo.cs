using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;

using VenditaVeicoliDllProject;

namespace WindowsFormsAppProject
{
    public partial class FormDialogAggiungiVeicolo : Form
    {
        private int y = 0;
        BindingList<Veicolo> bindingListaVeicoli;

        public FormDialogAggiungiVeicolo(BindingList<Veicolo> bindingListaVeicoli)
        {
            InitializeComponent();
            this.bindingListaVeicoli = bindingListaVeicoli;
        }

        private void FormDialogAggiungiVeicolo_Load(object sender, EventArgs e)
        {
            this.cmbTipoVeicolo.SelectedIndex = 0;
            y = lblMarcaSella.Top;
            y = txtVersione.Top;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (cmbTipoVeicolo.SelectedIndex == 0)
            {
                Moto m = new Moto(txtTarga.Text, txtMarca.Text, txtModello.Text, txtVersione.Text, Convert.ToInt32(nmrCilindrata.Value), txtTipoVeicolo.Text, cmbTipo.Text, Convert.ToInt32(txtKm.Text), dtpImmatricolazione.Value, Convert.ToDouble(txtPrezzo.Text));
                bindingListaVeicoli.Add(m);
                addDb(m);
            }
            else
            {
                Auto a = new Auto(txtTarga.Text, txtMarca.Text, txtModello.Text, txtVersione.Text, Convert.ToInt32(nmrCilindrata.Value),txtTipoVeicolo.Text,cmbTipo.Text, Convert.ToInt32(txtKm.Text), dtpImmatricolazione.Value, cmbCarburante.Text, Convert.ToDouble(txtPrezzo.Text));
                bindingListaVeicoli.Add(a);
                addDb(a);
            }
            this.Close();
        }

        private void addDb(Veicolo v)
        {
            string sql = $"insert into Veicoli values('{v.Targa}','{v.Marca}','{v.Modello}','{v.Versione}',{v.Cilindrata},'{v.TipoVeicolo}','{v.Tipologia}',{v.Km},#{v.Immatricolazione.Date}#,'{(v is Moto ?"|":(v as Auto).Carburante)}',{v.Prezzo})";
            using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=Veicoli.accdb;")) //data reader: oggetto per recuperare dati
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
        }

        private void cmbTipoVeicolo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoVeicolo.SelectedIndex == 0)
            {
                lblCarburante.Hide();
                cmbCarburante.Hide();
            }
            else
            {
                lblCarburante.Show();
                cmbCarburante.Show();
            }
        }
    }
}
