using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadnie_13._03._25
{
    public partial class Form1 : Form
    {
        private decimal totalPrice = 0;

        public Form1()
        {
            InitializeComponent();
            but_suma.Text = "0";
            but_suma.ReadOnly = true;
        }

        private void but_komp_Click(object sender, EventArgs e)
        {
            Form2 computerForm = new Form2();
            computerForm.Show();
        }

        private void but_mon_Click(object sender, EventArgs e)
        {
            Form3 monitorForm = new Form3();
            monitorForm.Show();
        }

        private void but_cena_Click(object sender, EventArgs e)
        {
            // This label doesn't need click handling
        }

        private void but_suma_TextChanged(object sender, EventArgs e)
        {
            // This textbox is read-only, so we don't need to handle text changes
        }

        public void UpdateTotalPrice(decimal price)
        {
            totalPrice = price;
            but_suma.Text = totalPrice.ToString();
        }
    }
}
