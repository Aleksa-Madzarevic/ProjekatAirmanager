namespace ProjekatAirmanager
{
    partial class LinijeForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinijeForma));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.napraviLiniju = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trajanjeLeta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.validSve = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.izborAviona = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RadniDani = new System.Windows.Forms.NumericUpDown();
            this.Vikend = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.duzinaPuta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RadniDani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vikend)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Beograd",
            "Rio",
            "Tokio",
            "Peking",
            "Madrid",
            "Pariz",
            "Bec",
            "Kairo",
            "Njujork",
            "London",
            "Rim",
            "Melburn",
            "Sidnej",
            "Pert",
            "Boston",
            "San Francisko",
            "Atlanta",
            "Singapur",
            "Moskva"});
            this.checkedListBox1.Location = new System.Drawing.Point(25, 120);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(190, 361);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // napraviLiniju
            // 
            this.napraviLiniju.Location = new System.Drawing.Point(459, 516);
            this.napraviLiniju.Name = "napraviLiniju";
            this.napraviLiniju.Size = new System.Drawing.Size(108, 45);
            this.napraviLiniju.TabIndex = 2;
            this.napraviLiniju.Text = "Napravi liniju";
            this.napraviLiniju.UseVisualStyleBackColor = true;
            this.napraviLiniju.Click += new System.EventHandler(this.napraviLiniju_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aerodromi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Radni dani";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vikend";
            // 
            // trajanjeLeta
            // 
            this.trajanjeLeta.Location = new System.Drawing.Point(638, 129);
            this.trajanjeLeta.Name = "trajanjeLeta";
            this.trajanjeLeta.Size = new System.Drawing.Size(100, 22);
            this.trajanjeLeta.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Trajanje leta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(658, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sve je u redu?";
            // 
            // validSve
            // 
            this.validSve.Location = new System.Drawing.Point(764, 487);
            this.validSve.Name = "validSve";
            this.validSve.Size = new System.Drawing.Size(100, 22);
            this.validSve.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(798, 51);
            this.label7.TabIndex = 14;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // izborAviona
            // 
            this.izborAviona.FormattingEnabled = true;
            this.izborAviona.Location = new System.Drawing.Point(272, 120);
            this.izborAviona.Name = "izborAviona";
            this.izborAviona.Size = new System.Drawing.Size(160, 361);
            this.izborAviona.TabIndex = 15;
            this.izborAviona.SelectedIndexChanged += new System.EventHandler(this.izborAviona_SelectedIndexChanged);
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Location = new System.Drawing.Point(11, 6);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.Size = new System.Drawing.Size(14, 4);
            this.checkedListBox4.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Avioni";
            // 
            // RadniDani
            // 
            this.RadniDani.Location = new System.Drawing.Point(638, 228);
            this.RadniDani.Name = "RadniDani";
            this.RadniDani.Size = new System.Drawing.Size(120, 22);
            this.RadniDani.TabIndex = 18;
            // 
            // Vikend
            // 
            this.Vikend.Location = new System.Drawing.Point(638, 265);
            this.Vikend.Name = "Vikend";
            this.Vikend.Size = new System.Drawing.Size(120, 22);
            this.Vikend.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Duzina puta";
            // 
            // duzinaPuta
            // 
            this.duzinaPuta.Location = new System.Drawing.Point(638, 169);
            this.duzinaPuta.Name = "duzinaPuta";
            this.duzinaPuta.Size = new System.Drawing.Size(100, 22);
            this.duzinaPuta.TabIndex = 21;
            // 
            // LinijeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 584);
            this.Controls.Add(this.duzinaPuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Vikend);
            this.Controls.Add(this.RadniDani);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkedListBox4);
            this.Controls.Add(this.izborAviona);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.validSve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trajanjeLeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.napraviLiniju);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "LinijeForma";
            this.Text = "LinijeForma";
            this.Load += new System.EventHandler(this.LinijeForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RadniDani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vikend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button napraviLiniju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox trajanjeLeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox validSve;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox IzborAviona;
        private System.Windows.Forms.CheckedListBox checkedListBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown RadniDani;
        private System.Windows.Forms.NumericUpDown Vikend;
        private System.Windows.Forms.CheckedListBox izborAviona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox duzinaPuta;
    }
}