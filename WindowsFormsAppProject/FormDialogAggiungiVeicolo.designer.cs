namespace WindowsFormsAppProject
{
    partial class FormDialogAggiungiVeicolo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTipoVeicolo = new System.Windows.Forms.ComboBox();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMarcaSella = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModello = new System.Windows.Forms.TextBox();
            this.txtVersione = new System.Windows.Forms.TextBox();
            this.nmrCilindrata = new System.Windows.Forms.NumericUpDown();
            this.dtpImmatricolazione = new System.Windows.Forms.DateTimePicker();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblCarburante = new System.Windows.Forms.Label();
            this.cmbCarburante = new System.Windows.Forms.ComboBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtTipoVeicolo = new System.Windows.Forms.TextBox();
            this.txtTarga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCilindrata)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoVeicolo
            // 
            this.cmbTipoVeicolo.FormattingEnabled = true;
            this.cmbTipoVeicolo.Items.AddRange(new object[] {
            "MOTO",
            "AUTO"});
            this.cmbTipoVeicolo.Location = new System.Drawing.Point(70, 12);
            this.cmbTipoVeicolo.Name = "cmbTipoVeicolo";
            this.cmbTipoVeicolo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoVeicolo.TabIndex = 0;
            this.cmbTipoVeicolo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVeicolo_SelectedIndexChanged);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnulla.Location = new System.Drawing.Point(51, 564);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 1;
            this.btnAnnulla.Text = "ANNULLA";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(132, 564);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 2;
            this.btnAggiungi.Text = "AGGIUNGI";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MARCA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MODELLO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "VERSIONE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CILINDRATA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "TIPO DI VEICOLO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "IMMATRICOLAZIONE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "KM";
            // 
            // lblMarcaSella
            // 
            this.lblMarcaSella.AutoSize = true;
            this.lblMarcaSella.Location = new System.Drawing.Point(12, 333);
            this.lblMarcaSella.Name = "lblMarcaSella";
            this.lblMarcaSella.Size = new System.Drawing.Size(64, 13);
            this.lblMarcaSella.TabIndex = 12;
            this.lblMarcaSella.Text = "TIPOLOGIA";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(128, 93);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 14;
            // 
            // txtModello
            // 
            this.txtModello.Location = new System.Drawing.Point(128, 138);
            this.txtModello.Name = "txtModello";
            this.txtModello.Size = new System.Drawing.Size(100, 20);
            this.txtModello.TabIndex = 15;
            // 
            // txtVersione
            // 
            this.txtVersione.Location = new System.Drawing.Point(128, 179);
            this.txtVersione.Name = "txtVersione";
            this.txtVersione.Size = new System.Drawing.Size(100, 20);
            this.txtVersione.TabIndex = 23;
            // 
            // nmrCilindrata
            // 
            this.nmrCilindrata.Location = new System.Drawing.Point(128, 228);
            this.nmrCilindrata.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrCilindrata.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrCilindrata.Name = "nmrCilindrata";
            this.nmrCilindrata.Size = new System.Drawing.Size(100, 20);
            this.nmrCilindrata.TabIndex = 25;
            this.nmrCilindrata.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // dtpImmatricolazione
            // 
            this.dtpImmatricolazione.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpImmatricolazione.Location = new System.Drawing.Point(128, 426);
            this.dtpImmatricolazione.Name = "dtpImmatricolazione";
            this.dtpImmatricolazione.Size = new System.Drawing.Size(100, 20);
            this.dtpImmatricolazione.TabIndex = 29;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Nuovo",
            "Usato"});
            this.cmbTipo.Location = new System.Drawing.Point(128, 325);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(100, 21);
            this.cmbTipo.TabIndex = 32;
            // 
            // lblCarburante
            // 
            this.lblCarburante.AutoSize = true;
            this.lblCarburante.Location = new System.Drawing.Point(12, 481);
            this.lblCarburante.Name = "lblCarburante";
            this.lblCarburante.Size = new System.Drawing.Size(81, 13);
            this.lblCarburante.TabIndex = 33;
            this.lblCarburante.Text = "CARBURANTE";
            // 
            // cmbCarburante
            // 
            this.cmbCarburante.FormattingEnabled = true;
            this.cmbCarburante.Items.AddRange(new object[] {
            "Benzina",
            "Gasolio",
            "GPL",
            "Benzina/GPL",
            "Metano"});
            this.cmbCarburante.Location = new System.Drawing.Point(128, 473);
            this.cmbCarburante.Name = "cmbCarburante";
            this.cmbCarburante.Size = new System.Drawing.Size(100, 21);
            this.cmbCarburante.TabIndex = 34;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(128, 378);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(100, 20);
            this.txtKm.TabIndex = 35;
            // 
            // txtTipoVeicolo
            // 
            this.txtTipoVeicolo.Location = new System.Drawing.Point(128, 275);
            this.txtTipoVeicolo.Name = "txtTipoVeicolo";
            this.txtTipoVeicolo.Size = new System.Drawing.Size(100, 20);
            this.txtTipoVeicolo.TabIndex = 36;
            // 
            // txtTarga
            // 
            this.txtTarga.Location = new System.Drawing.Point(128, 56);
            this.txtTarga.Name = "txtTarga";
            this.txtTarga.Size = new System.Drawing.Size(100, 20);
            this.txtTarga.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "TARGA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "PREZZO";
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(128, 517);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(100, 20);
            this.txtPrezzo.TabIndex = 40;
            // 
            // FormDialogAggiungiVeicolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnulla;
            this.ClientSize = new System.Drawing.Size(387, 609);
            this.Controls.Add(this.txtPrezzo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTarga);
            this.Controls.Add(this.txtTipoVeicolo);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.cmbCarburante);
            this.Controls.Add(this.lblCarburante);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.dtpImmatricolazione);
            this.Controls.Add(this.nmrCilindrata);
            this.Controls.Add(this.txtVersione);
            this.Controls.Add(this.txtModello);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarcaSella);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.cmbTipoVeicolo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDialogAggiungiVeicolo";
            this.Text = "AGGIUNGI VEICOLO";
            this.Load += new System.EventHandler(this.FormDialogAggiungiVeicolo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrCilindrata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoVeicolo;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMarcaSella;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.TextBox txtVersione;
        private System.Windows.Forms.NumericUpDown nmrCilindrata;
        private System.Windows.Forms.DateTimePicker dtpImmatricolazione;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblCarburante;
        private System.Windows.Forms.ComboBox cmbCarburante;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtTipoVeicolo;
        private System.Windows.Forms.TextBox txtTarga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrezzo;
    }
}