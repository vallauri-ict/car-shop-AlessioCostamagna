using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsAppProject
{
    public partial class frmAggiungiVeicolo : Form
    {
        public frmAggiungiVeicolo()
        {
            InitializeComponent();
        }
        private void frmAggiungiVeicolo_Load(object sender, EventArgs e)
        {
            this.cmbAggiungi.SelectedIndex = 0;
        }
        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aggiungi");
            this.Close();
        }
    }
}
