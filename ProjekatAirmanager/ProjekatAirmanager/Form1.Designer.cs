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
            this.NapraviLiniju = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.kupiAvion.Size = new System.Drawing.Size(75, 145);
            this.kupiAvion.TabIndex = 6;
            this.kupiAvion.Text = "Kupi Avion";
            this.kupiAvion.UseVisualStyleBackColor = true;
            this.kupiAvion.Click += new System.EventHandler(this.button1_Click);
            // 
            // KupiMesto
            // 
            this.KupiMesto.Location = new System.Drawing.Point(1235, 192);
            this.KupiMesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KupiMesto.Name = "KupiMesto";
            this.KupiMesto.Size = new System.Drawing.Size(75, 138);
            this.KupiMesto.TabIndex = 7;
            this.KupiMesto.Text = "Kupi Parking Mesto";
            this.KupiMesto.UseVisualStyleBackColor = true;
            this.KupiMesto.Click += new System.EventHandler(this.KupiMesto_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // NapraviLiniju
            // 
            this.NapraviLiniju.Location = new System.Drawing.Point(1235, 334);
            this.NapraviLiniju.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NapraviLiniju.Name = "NapraviLiniju";
            this.NapraviLiniju.Size = new System.Drawing.Size(75, 139);
            this.NapraviLiniju.TabIndex = 8;
            this.NapraviLiniju.Text = "Napravi liniju";
            this.NapraviLiniju.UseVisualStyleBackColor = true;
            this.NapraviLiniju.Click += new System.EventHandler(this.NapraviLiniju_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1235, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 182);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 672);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NapraviLiniju);
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
        private System.Windows.Forms.Button NapraviLiniju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

