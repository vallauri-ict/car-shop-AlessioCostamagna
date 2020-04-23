using System;
using System.Windows.Forms;
using VenditaVeicoliDllProject;

namespace WindowsFormsAppProject
{
    public partial class FormMain : Form
    {
        SerializableBindingList<Veicolo> bindingListVeicoli;

        public FormMain()
        {
            InitializeComponent();
            bindingListVeicoli = new SerializableBindingList<Veicolo>();
            listBoxVeicoli.DataSource = bindingListVeicoli;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CaricaDatiDiTest();
        }

        private void CaricaDatiDiTest()
        {
            Moto m = new Moto();
            bindingListVeicoli.Add(m);
            m = new Moto("Honda", "Tsunami", "Rosso", 1000, 120, DateTime.Now, false, false, 0, "Quintino");
            bindingListVeicoli.Add(m);
            Auto a = new Auto("Jeep", "Compass", "Blue", 1600, 90, DateTime.Now, false, false, 0, 8);
            bindingListVeicoli.Add(a);
        }

        private void toolStripButtonAddVeicolo_Click(object sender, EventArgs e)
        {
        }

        private void nuovoToolStripButton_Click(object sender, EventArgs e)
        {
            FormDialogAggiungiVeicolo dialogAggiungi = new FormDialogAggiungiVeicolo(bindingListVeicoli);
            dialogAggiungi.ShowDialog();
        }

        private void apriToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apri...");
        }

        private void salvaToolStripButton_Click(object sender, EventArgs e)
        {
            Utils.SerializeToCsv(bindingListVeicoli, @".\Veicoli.csv");

            Utils.SerializeToXml(bindingListVeicoli, @".\Veicoli.xml");

            Utils.SerializeToJson(bindingListVeicoli, @".\Veicoli.json");
        }
    }
}
