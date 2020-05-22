namespace ProjekatAirmanager
{
    partial class NapraviLinijuF
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.zavrsiPotez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Beograd",
            "Melburn",
            "London",
            "Tokio",
            "Njujork",
            "Rio",
            "Peking"});
            this.checkedListBox1.Location = new System.Drawing.Point(34, 48);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(229, 191);
            this.checkedListBox1.TabIndex = 0;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Beograd",
            "Melburn",
            "London",
            "Tokio",
            "Njujork",
            "Rio",
            "Peking"});
            this.checkedListBox2.Location = new System.Drawing.Point(309, 48);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(241, 191);
            this.checkedListBox2.TabIndex = 1;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // zavrsiPotez
            // 
            this.zavrsiPotez.Location = new System.Drawing.Point(572, 328);
            this.zavrsiPotez.Name = "zavrsiPotez";
            this.zavrsiPotez.Size = new System.Drawing.Size(153, 52);
            this.zavrsiPotez.TabIndex = 2;
            this.zavrsiPotez.Text = "Zavrsi potez";
            this.zavrsiPotez.UseVisualStyleBackColor = true;
            this.zavrsiPotez.Click += new System.EventHandler(this.zavrsiPotez_Click);
            // 
            // NapraviLinijuF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zavrsiPotez);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "NapraviLinijuF";
            this.Text = "NapraviLinijuF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button zavrsiPotez;
    }
}