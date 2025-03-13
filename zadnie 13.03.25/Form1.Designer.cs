namespace zadnie_13._03._25
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_komp = new System.Windows.Forms.Button();
            this.but_mon = new System.Windows.Forms.Button();
            this.but_suma = new System.Windows.Forms.TextBox();
            this.but_cena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_komp
            // 
            this.but_komp.Location = new System.Drawing.Point(199, 140);
            this.but_komp.Name = "but_komp";
            this.but_komp.Size = new System.Drawing.Size(112, 23);
            this.but_komp.TabIndex = 0;
            this.but_komp.Text = "Komputer";
            this.but_komp.UseVisualStyleBackColor = true;
            this.but_komp.Click += new System.EventHandler(this.but_komp_Click);
            // 
            // but_mon
            // 
            this.but_mon.Location = new System.Drawing.Point(339, 140);
            this.but_mon.Name = "but_mon";
            this.but_mon.Size = new System.Drawing.Size(112, 23);
            this.but_mon.TabIndex = 1;
            this.but_mon.Text = "Monitor";
            this.but_mon.UseVisualStyleBackColor = true;
            this.but_mon.Click += new System.EventHandler(this.but_mon_Click);
            // 
            // but_suma
            // 
            this.but_suma.Location = new System.Drawing.Point(489, 141);
            this.but_suma.Name = "but_suma";
            this.but_suma.Size = new System.Drawing.Size(100, 22);
            this.but_suma.TabIndex = 2;
            this.but_suma.TextChanged += new System.EventHandler(this.but_suma_TextChanged);
            // 
            // but_cena
            // 
            this.but_cena.AutoSize = true;
            this.but_cena.Location = new System.Drawing.Point(507, 97);
            this.but_cena.Name = "but_cena";
            this.but_cena.Size = new System.Drawing.Size(52, 16);
            this.but_cena.TabIndex = 3;
            this.but_cena.Text = "cena zł";
            this.but_cena.Click += new System.EventHandler(this.but_cena_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_cena);
            this.Controls.Add(this.but_suma);
            this.Controls.Add(this.but_mon);
            this.Controls.Add(this.but_komp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_komp;
        private System.Windows.Forms.Button but_mon;
        private System.Windows.Forms.TextBox but_suma;
        private System.Windows.Forms.Label but_cena;
    }
}

