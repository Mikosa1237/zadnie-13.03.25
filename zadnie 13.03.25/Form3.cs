using System;
using System.Windows.Forms;

namespace zadnie_13._03._25
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Add monitor options
            listView.Items.AddRange(new string[] {
                "Dell 24\" Full HD - 899 zł",
                "LG 27\" 4K - 1299 zł",
                "Samsung 32\" Gaming - 1499 zł"
            });

            // Set textbox as read-only
            textBox1.ReadOnly = true;

            // Add event handlers
            listView.SelectedIndexChanged += ListView_SelectedIndexChanged;
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                string selected = listView.SelectedItem.ToString();
                string price = selected.Split('-')[1].Trim().Split(' ')[0];
                textBox1.Text = price;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal price))
            {
                Form1 mainForm = (Form1)Application.OpenForms["Form1"];
                if (mainForm != null)
                {
                    mainForm.UpdateTotalPrice(price);
                }
            }
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
