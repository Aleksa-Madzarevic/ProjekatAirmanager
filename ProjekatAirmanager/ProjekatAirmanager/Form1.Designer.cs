namespace ProjekatAirmanager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kupiAvion = new System.Windows.Forms.Button();
            this.KupiMesto = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.lblVreme = new System.Windows.Forms.Label();
            this.lblDan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnPrikažiPosede = new System.Windows.Forms.Button();
            this.lblDanUNedelji = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProjekatAirmanager.Properties.Resources.mapaSveta;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1216, 617);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // kupiAvion
            // 
            this.kupiAvion.Location = new System.Drawing.Point(1235, 43);
            this.kupiAvion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kupiAvion.Name = "kupiAvion";
            this.kupiAvion.Size = new System.Drawing.Size(75, 109);
            this.kupiAvion.TabIndex = 6;
            this.kupiAvion.Text = "Kupi Avion";
            this.kupiAvion.UseVisualStyleBackColor = true;
            this.kupiAvion.Click += new System.EventHandler(this.button1_Click);
            // 
            // KupiMesto
            // 
            this.KupiMesto.Location = new System.Drawing.Point(1234, 156);
            this.KupiMesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KupiMesto.Name = "KupiMesto";
            this.KupiMesto.Size = new System.Drawing.Size(75, 111);
            this.KupiMesto.TabIndex = 7;
            this.KupiMesto.Text = "Kupi Parking Mesto";
            this.KupiMesto.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1234, 271);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 112);
            this.button3.TabIndex = 8;
            this.button3.Text = "Napravi liniju";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Location = new System.Drawing.Point(12, 17);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(46, 17);
            this.lblVreme.TabIndex = 9;
            this.lblVreme.Text = "label1";
            // 
            // lblDan
            // 
            this.lblDan.AutoSize = true;
            this.lblDan.Location = new System.Drawing.Point(203, 17);
            this.lblDan.Name = "lblDan";
            this.lblDan.Size = new System.Drawing.Size(46, 17);
            this.lblDan.TabIndex = 10;
            this.lblDan.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnPrikažiPosede
            // 
            this.BtnPrikažiPosede.Location = new System.Drawing.Point(1234, 388);
            this.BtnPrikažiPosede.Name = "BtnPrikažiPosede";
            this.BtnPrikažiPosede.Size = new System.Drawing.Size(75, 130);
            this.BtnPrikažiPosede.TabIndex = 12;
            this.BtnPrikažiPosede.Text = "Prikaži posede";
            this.BtnPrikažiPosede.UseVisualStyleBackColor = true;
            // 
            // lblDanUNedelji
            // 
            this.lblDanUNedelji.AutoSize = true;
            this.lblDanUNedelji.Location = new System.Drawing.Point(255, 17);
            this.lblDanUNedelji.Name = "lblDanUNedelji";
            this.lblDanUNedelji.Size = new System.Drawing.Size(101, 17);
            this.lblDanUNedelji.TabIndex = 13;
            this.lblDanUNedelji.Text = "lblDanUNedelji";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 672);
            this.Controls.Add(this.lblDanUNedelji);
            this.Controls.Add(this.BtnPrikažiPosede);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDan);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.KupiMesto);
            this.Controls.Add(this.kupiAvion);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kupiAvion;
        private System.Windows.Forms.Button KupiMesto;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Label lblDan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnPrikažiPosede;
        private System.Windows.Forms.Label lblDanUNedelji;
    }
}

