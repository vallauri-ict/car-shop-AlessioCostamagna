using System;
using System.ComponentModel;
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
            this.cmbColore.SelectedIndex = 0;
            this.cmbKmZero.SelectedIndex = 1;
            y = lblMarcaSella.Top;
            y = txtMarcaSella.Top;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbTipoVeicolo.SelectedItem + " - " + txtMarca.Text + " - ");
            if (cmbTipoVeicolo.SelectedIndex == 0)
            {
                Moto m = new Moto(txtMarca.Text, txtModello.Text, cmbColore.SelectedItem.ToString(), Convert.ToInt32(nmrCilindrata.Value), Convert.ToInt32(nmrPotenza.Value), dtpImmatricolazione.Value, rdbNo.Checked? false : true, cmbKmZero.SelectedIndex == 0? true : false, Convert.ToInt32(nmrKmPercorsi.Value), txtMarcaSella.Text);
                bindingListaVeicoli.Add(m);
            }
            else
            {
                Auto a = new Auto(txtMarca.Text, txtModello.Text, cmbColore.SelectedItem.ToString(), Convert.ToInt32(nmrCilindrata.Value), Convert.ToInt32(nmrPotenza.Value), dtpImmatricolazione.Value, rdbNo.Checked ? false : true, cmbKmZero.SelectedIndex == 0 ? true : false, Convert.ToInt32(nmrKmPercorsi.Value), Convert.ToInt32(nmrNumAirbag.Value));
                bindingListaVeicoli.Add(a);
            }
            this.Close();
        }

        private void cmbTipoVeicolo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoVeicolo.SelectedIndex == 0)
            {
                lblNumeroAir.Hide();
                nmrNumAirbag.Hide();
            }
            else
            {
                lblMarcaSella.Hide();
                txtMarcaSella.Hide();
                lblNumeroAir.Show();
                nmrNumAirbag.Show();
                lblNumeroAir.Top = y;
                nmrNumAirbag.Top = y;
            }
        }
    }
}
