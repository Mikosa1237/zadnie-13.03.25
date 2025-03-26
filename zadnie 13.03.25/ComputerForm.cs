using System;
using System.Windows.Forms;

namespace zadnie_13._03._25
{
    public partial class ComputerForm : Form
    {
        private ComboBox processorComboBox;
        private ComboBox diskComboBox;
        private TextBox priceTextBox;
        private decimal totalPrice = 0;

        public ComputerForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "Komputer";
            this.Width = 400;
            this.Height = 400;

            // Processor section
            Label processorLabel = new Label
            {
                Text = "Procesor",
                Location = new System.Drawing.Point(20, 20),
                AutoSize = true
            };

            processorComboBox = new ComboBox
            {
                Location = new System.Drawing.Point(20, 40),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            processorComboBox.Items.AddRange(new string[] {
                "Intel Core i5",
                "Intel Core i7",
                "AMD Ryzen 5",
                "AMD Ryzen 7"
            });
            processorComboBox.SelectedIndexChanged += UpdatePrice;

            // Disk section
            Label diskLabel = new Label
            {
                Text = "Dysk",
                Location = new System.Drawing.Point(20, 80),
                AutoSize = true
            };

            diskComboBox = new ComboBox
            {
                Location = new System.Drawing.Point(20, 100),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            diskComboBox.Items.AddRange(new string[] {
                "240 GB SSD",
                "500 GB SATA",
                "1000 GB SATA"
            });
            diskComboBox.SelectedIndexChanged += UpdatePrice;

            // Price section
            Label priceLabel = new Label
            {
                Text = "Reszta:",
                Location = new System.Drawing.Point(20, 160),
                AutoSize = true
            };

            priceTextBox = new TextBox
            {
                Location = new System.Drawing.Point(80, 160),
                Width = 100,
                Text = "1000",
                ReadOnly = true
            };

            Label zlLabel = new Label
            {
                Text = "zł",
                Location = new System.Drawing.Point(190, 160),
                AutoSize = true
            };

            // Buttons
            Button okButton = new Button
            {
                Text = "OK",
                Location = new System.Drawing.Point(20, 200),
                Width = 75
            };
            okButton.Click += (s, e) => this.Close();

            Button cancelButton = new Button
            {
                Text = "ANULUJ",
                Location = new System.Drawing.Point(110, 200),
                Width = 75
            };
            cancelButton.Click += (s, e) => this.Close();

            this.Controls.AddRange(new Control[] {
                processorLabel,
                processorComboBox,
                diskLabel,
                diskComboBox,
                priceLabel,
                priceTextBox,
                zlLabel,
                okButton,
                cancelButton
            });
        }

        private void UpdatePrice(object sender, EventArgs e)
        {
            totalPrice = 1000; // Base price
            // Add logic here to calculate price based on selections
            priceTextBox.Text = totalPrice.ToString();
        }
    }
} 