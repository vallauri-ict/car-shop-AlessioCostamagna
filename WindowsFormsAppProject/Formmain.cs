using System;
using System.Windows.Forms;
using VenditaVeicoliDllProject;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsAppProject
{
    public partial class FormMain : Form
    {
        bool delete= false;
        string constr;
        SerializableBindingList<Veicolo> bindingListVeicoli;

        public FormMain()
        {
            InitializeComponent();
            bindingListVeicoli = new SerializableBindingList<Veicolo>();
            listBoxVeicoli.DataSource = bindingListVeicoli;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            constr = "Provider=Microsoft.Ace.Oledb.12.0;Data Source=Veicoli.accdb;";
            try
            {
                CreateTable(constr);
            }
            catch (OleDbException) { }
            bindingListVeicoli = openDb(constr, "select * from Veicoli");
            listBoxVeicoli.DataSource = bindingListVeicoli;
            this.listBoxVeicoli.SelectedIndexChanged += new System.EventHandler(this.listBoxVeicoli_SelectedIndexChanged);
        }

        private SerializableBindingList<Veicolo> openDb(string constr, string sql)
        {
            var l = new SerializableBindingList<Veicolo>();
            DataTable t = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(constr)) //data reader: oggetto per recuperare dati
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(sql, connection);
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(t);
                foreach (DataRow r in t.Rows)
                {
                    if (r["Carburante"].ToString()=="|")
                    {
                        Moto m = new Moto(r["Targa"].ToString(), r["Marca"].ToString(), r["Modello"].ToString(), r["Versione"].ToString(), Convert.ToInt32(r["Cilindrata"]), r["TipoVeicolo"].ToString(), r["Tipologia"].ToString(), Convert.ToInt32(r["Km"]), Convert.ToDateTime(r["Immatricolazione"]), Convert.ToDouble(r["Prezzo"]));
                        l.Add(m);
                    }
                    else
                    {
                        Auto a = new Auto(r["Targa"].ToString(), r["Marca"].ToString(), r["Modello"].ToString(), r["Versione"].ToString(), Convert.ToInt32(r["Cilindrata"]), r["TipoVeicolo"].ToString(), r["Tipologia"].ToString(), Convert.ToInt32(r["Km"]), Convert.ToDateTime(r["Immatricolazione"]), r["Carburante"].ToString(), Convert.ToDouble(r["Prezzo"]));
                        l.Add(a);
                    }
                }
            }
            return l;
        }
        public void CreateTable(string connString)
        {
            string sql = $"CREATE TABLE Veicoli (" +
                $"Targa varchar(255) NOT NULL PRIMARY KEY," +
                $"Marca varchar(255)," +
                $"Modello varchar(255)," +
                $"Versione varchar(255)," +
                $"Cilindrata int," +
                $"TipoVeicolo varchar(255)," +
                $"Tipologia varchar(255)," +
                $"Km int," +
                $"Immatricolazione datetime," +
                $"Carburante varchar(255)," +
                $"Prezzo double,"+
                $");";
            using (OleDbConnection connection = new OleDbConnection(connString)) //data reader: oggetto per recuperare dati
            {
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
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
            bindingListVeicoli = openDb(constr, "select * from veicoli");
        }

        private void salvaToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void listBoxVeicoli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!delete)
            {
                if (MessageBox.Show("Vuoi eliminare il veicolo?", "elimina", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    delete = true;
                    var v = bindingListVeicoli[listBoxVeicoli.SelectedIndex];
                    using (OleDbConnection connection = new OleDbConnection(constr)) //data reader: oggetto per recuperare dati
                    {
                        connection.Open();
                        OleDbCommand cmd = new OleDbCommand("Delete from Veicoli where targa='" + v.Targa + "'", connection);
                        cmd.ExecuteNonQuery();
                    }
                    bindingListVeicoli.Remove(v);
                    listBoxVeicoli.ClearSelected();
                }
            }
            else
                delete = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Utils.CreateHtml(bindingListVeicoli);
        }
    }
}
