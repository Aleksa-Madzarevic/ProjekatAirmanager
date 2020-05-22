namespace ProjekatAirmanager
{
    partial class UlaznaForma
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
            this.button1 = new System.Windows.Forms.Button();
            this.moveDuration = new System.Windows.Forms.NumericUpDown();
            this.gameDuration = new System.Windows.Forms.NumericUpDown();
            this.numberOfPlayers = new System.Windows.Forms.NumericUpDown();
            this.startingMoney = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moveDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Započni igru";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // moveDuration
            // 
            this.moveDuration.Location = new System.Drawing.Point(12, 74);
            this.moveDuration.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.moveDuration.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.moveDuration.Name = "moveDuration";
            this.moveDuration.Size = new System.Drawing.Size(139, 22);
            this.moveDuration.TabIndex = 1;
            this.moveDuration.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.moveDuration.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // gameDuration
            // 
            this.gameDuration.Location = new System.Drawing.Point(213, 74);
            this.gameDuration.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gameDuration.Name = "gameDuration";
            this.gameDuration.Size = new System.Drawing.Size(139, 22);
            this.gameDuration.TabIndex = 2;
            this.gameDuration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numberOfPlayers
            // 
            this.numberOfPlayers.Location = new System.Drawing.Point(12, 29);
            this.numberOfPlayers.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numberOfPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberOfPlayers.Name = "numberOfPlayers";
            this.numberOfPlayers.Size = new System.Drawing.Size(139, 22);
            this.numberOfPlayers.TabIndex = 3;
            this.numberOfPlayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // startingMoney
            // 
            this.startingMoney.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.startingMoney.Location = new System.Drawing.Point(213, 29);
            this.startingMoney.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.startingMoney.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.startingMoney.Name = "startingMoney";
            this.startingMoney.Size = new System.Drawing.Size(139, 22);
            this.startingMoney.TabIndex = 4;
            this.startingMoney.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "broj igrača:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "trajanje poteza u sekundama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "početni novac:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "trajanje igre u danima:";
            // 
            // UlaznaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 173);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startingMoney);
            this.Controls.Add(this.numberOfPlayers);
            this.Controls.Add(this.gameDuration);
            this.Controls.Add(this.moveDuration);
            this.Controls.Add(this.button1);
            this.Name = "UlaznaForma";
            this.Text = "UlaznaForma";
            this.Load += new System.EventHandler(this.UlaznaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moveDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown moveDuration;
        private System.Windows.Forms.NumericUpDown gameDuration;
        private System.Windows.Forms.NumericUpDown numberOfPlayers;
        private System.Windows.Forms.NumericUpDown startingMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}