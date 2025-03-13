namespace zadnie_13._03._25
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_SSD = new System.Windows.Forms.RadioButton();
            this.rb_SATA1 = new System.Windows.Forms.RadioButton();
            this.rb_SATA2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.procesory = new System.Windows.Forms.ComboBox();
            this.but_ok = new System.Windows.Forms.Button();
            this.but_anuluj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cena_dysk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cena_proc = new System.Windows.Forms.TextBox();
            this.cena_reszta = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Komputer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "procesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "dysk";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "reszta:";
            // 
            // rb_SSD
            // 
            this.rb_SSD.AutoSize = true;
            this.rb_SSD.Checked = true;
            this.rb_SSD.Location = new System.Drawing.Point(275, 266);
            this.rb_SSD.Name = "rb_SSD";
            this.rb_SSD.Size = new System.Drawing.Size(102, 20);
            this.rb_SSD.TabIndex = 5;
            this.rb_SSD.TabStop = true;
            this.rb_SSD.Text = "240 GB SSD";
            this.rb_SSD.UseVisualStyleBackColor = true;
            // 
            // rb_SATA1
            // 
            this.rb_SATA1.AutoSize = true;
            this.rb_SATA1.Location = new System.Drawing.Point(275, 292);
            this.rb_SATA1.Name = "rb_SATA1";
            this.rb_SATA1.Size = new System.Drawing.Size(107, 20);
            this.rb_SATA1.TabIndex = 6;
            this.rb_SATA1.Text = "500GB SATA";
            this.rb_SATA1.UseVisualStyleBackColor = true;
            // 
            // rb_SATA2
            // 
            this.rb_SATA2.AutoSize = true;
            this.rb_SATA2.Location = new System.Drawing.Point(275, 318);
            this.rb_SATA2.Name = "rb_SATA2";
            this.rb_SATA2.Size = new System.Drawing.Size(114, 20);
            this.rb_SATA2.TabIndex = 7;
            this.rb_SATA2.Text = "1000GB SATA";
            this.rb_SATA2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "zł";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 33);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // procesory
            // 
            this.procesory.FormattingEnabled = true;
            this.procesory.Location = new System.Drawing.Point(190, 164);
            this.procesory.Name = "procesory";
            this.procesory.Size = new System.Drawing.Size(254, 24);
            this.procesory.TabIndex = 10;
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(245, 415);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(75, 23);
            this.but_ok.TabIndex = 11;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = true;
            // 
            // but_anuluj
            // 
            this.but_anuluj.Location = new System.Drawing.Point(403, 415);
            this.but_anuluj.Name = "but_anuluj";
            this.but_anuluj.Size = new System.Drawing.Size(75, 23);
            this.but_anuluj.TabIndex = 12;
            this.but_anuluj.Text = "Anuluj";
            this.but_anuluj.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "zł";
            // 
            // cena_dysk
            // 
            this.cena_dysk.Location = new System.Drawing.Point(275, 235);
            this.cena_dysk.Name = "cena_dysk";
            this.cena_dysk.Size = new System.Drawing.Size(100, 22);
            this.cena_dysk.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "zł";
            // 
            // cena_proc
            // 
            this.cena_proc.Location = new System.Drawing.Point(282, 124);
            this.cena_proc.Name = "cena_proc";
            this.cena_proc.Size = new System.Drawing.Size(100, 22);
            this.cena_proc.TabIndex = 16;
            // 
            // cena_reszta
            // 
            this.cena_reszta.Location = new System.Drawing.Point(245, 376);
            this.cena_reszta.Name = "cena_reszta";
            this.cena_reszta.Size = new System.Drawing.Size(100, 22);
            this.cena_reszta.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cena_reszta);
            this.Controls.Add(this.cena_proc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cena_dysk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.but_anuluj);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.procesory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rb_SATA2);
            this.Controls.Add(this.rb_SATA1);
            this.Controls.Add(this.rb_SSD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_SSD;
        private System.Windows.Forms.RadioButton rb_SATA1;
        private System.Windows.Forms.RadioButton rb_SATA2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ComboBox procesory;
        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.Button but_anuluj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cena_dysk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cena_proc;
        private System.Windows.Forms.TextBox cena_reszta;
    }
}