using System;
using System.Windows.Forms;

namespace zadnie_13._03._25
{
    public partial class Form2 : Form
    {
        private decimal basePrice = 0;
        private decimal processorPrice = 0;
        private decimal diskPrice = 0;

        public Form2()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Add processor options
            procesory.Items.AddRange(new string[] {
                "Intel Core i5 - 800 zł",
                "Intel Core i7 - 1200 zł",
                "AMD Ryzen 5 - 900 zł",
                "AMD Ryzen 7 - 1100 zł"
            });

            // Set initial values
            cena_reszta.Text = basePrice.ToString();
            cena_proc.ReadOnly = true;
            cena_dysk.ReadOnly = true;

            // Add event handlers
            procesory.SelectedIndexChanged += Procesory_SelectedIndexChanged;
            rb_SSD.CheckedChanged += Disk_CheckedChanged;
            rb_SATA1.CheckedChanged += Disk_CheckedChanged;
            rb_SATA2.CheckedChanged += Disk_CheckedChanged;
            but_ok.Click += But_ok_Click;
            but_anuluj.Click += But_anuluj_Click;
            cena_reszta.TextChanged += Cena_reszta_TextChanged;
        }

        private void Cena_reszta_TextChanged(object sender, EventArgs e)
        {
            // Only allow numbers
            if (!decimal.TryParse(cena_reszta.Text, out decimal value))
            {
                cena_reszta.Text = basePrice.ToString();
            }
        }

        private void Procesory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (procesory.SelectedItem != null)
            {
                string selected = procesory.SelectedItem.ToString();
                if (selected.Contains("i5")) processorPrice = 800;
                else if (selected.Contains("i7")) processorPrice = 1200;
                else if (selected.Contains("Ryzen 5")) processorPrice = 900;
                else if (selected.Contains("Ryzen 7")) processorPrice = 1100;

                cena_proc.Text = processorPrice.ToString();
                UpdateTotalPrice();
            }
        }

        private void Disk_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_SSD.Checked)
            {
                diskPrice = 300;
                cena_dysk.Text = "300";
            }
            else if (rb_SATA1.Checked)
            {
                diskPrice = 200;
                cena_dysk.Text = "200";
            }
            else if (rb_SATA2.Checked)
            {
                diskPrice = 400;
                cena_dysk.Text = "400";
            }

            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            decimal total = basePrice + processorPrice + diskPrice;
            cena_reszta.Text = total.ToString();
        }

        private void But_ok_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(cena_reszta.Text, out decimal total))
            {
                Form1 mainForm = (Form1)Application.OpenForms["Form1"];
                if (mainForm != null)
                {
                    mainForm.UpdateTotalPrice(total);
                }
            }
            this.Close();
        }

        private void But_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // This label doesn't need click handling
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Form load event is handled in SetupForm
        }
    }
}
