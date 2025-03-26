using System;
using System.Windows.Forms;

namespace zadnie_13._03._25
{
    public partial class MainForm : Form
    {
        private decimal totalPrice = 0;

        public MainForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "Kalkulator Zestawów Komputerowych";
            this.Width = 400;
            this.Height = 300;

            Button computerButton = new Button
            {
                Text = "Komputer",
                Location = new System.Drawing.Point(20, 20),
                Width = 100,
                Height = 30
            };
            computerButton.Click += ComputerButton_Click;

            Button monitorButton = new Button
            {
                Text = "Monitor",
                Location = new System.Drawing.Point(140, 20),
                Width = 100,
                Height = 30
            };
            monitorButton.Click += MonitorButton_Click;

            Label totalPriceLabel = new Label
            {
                Text = "Cena zł",
                Location = new System.Drawing.Point(20, 70),
                AutoSize = true
            };

            TextBox totalPriceTextBox = new TextBox
            {
                Location = new System.Drawing.Point(80, 70),
                Width = 100,
                ReadOnly = true
            };

            this.Controls.AddRange(new Control[] { 
                computerButton, 
                monitorButton, 
                totalPriceLabel,
                totalPriceTextBox
            });
        }

        private void ComputerButton_Click(object sender, EventArgs e)
        {
            ComputerForm computerForm = new ComputerForm();
            computerForm.Show();
        }

        private void MonitorButton_Click(object sender, EventArgs e)
        {
            MonitorForm monitorForm = new MonitorForm();
            monitorForm.Show();
        }
    }
} 