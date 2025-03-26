using System;
using System.Windows.Forms;

namespace zadnie_13._03._25
{
    public partial class MonitorForm : Form
    {
        private ListView monitorListView;
        private TextBox priceTextBox;
        private decimal totalPrice = 0;

        public MonitorForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "Monitor";
            this.Width = 400;
            this.Height = 400;

            // List view
            monitorListView = new ListView
            {
                Location = new System.Drawing.Point(20, 20),
                Width = 340,
                Height = 200,
                View = View.Details,
                FullRowSelect = true
            };

            monitorListView.Columns.Add("Model", 200);
            monitorListView.Columns.Add("Cena", 100);

            // Add some sample monitors
            string[][] monitors = new string[][]
            {
                new string[] { "Dell 24\" Full HD", "899" },
                new string[] { "LG 27\" 4K", "1299" },
                new string[] { "Samsung 32\" Gaming", "1499" }
            };

            foreach (string[] monitor in monitors)
            {
                ListViewItem item = new ListViewItem(monitor);
                monitorListView.Items.Add(item);
            }

            monitorListView.SelectedIndexChanged += UpdatePrice;

            // Price section
            Label priceLabel = new Label
            {
                Text = "Cena",
                Location = new System.Drawing.Point(20, 240),
                AutoSize = true
            };

            priceTextBox = new TextBox
            {
                Location = new System.Drawing.Point(80, 240),
                Width = 100,
                ReadOnly = true
            };

            Label zlLabel = new Label
            {
                Text = "zł",
                Location = new System.Drawing.Point(190, 240),
                AutoSize = true
            };

            // Buttons
            Button okButton = new Button
            {
                Text = "OK",
                Location = new System.Drawing.Point(20, 280),
                Width = 75
            };
            okButton.Click += (s, e) => this.Close();

            Button cancelButton = new Button
            {
                Text = "ANULUJ",
                Location = new System.Drawing.Point(110, 280),
                Width = 75
            };
            cancelButton.Click += (s, e) => this.Close();

            this.Controls.AddRange(new Control[] {
                monitorListView,
                priceLabel,
                priceTextBox,
                zlLabel,
                okButton,
                cancelButton
            });
        }

        private void UpdatePrice(object sender, EventArgs e)
        {
            if (monitorListView.SelectedItems.Count > 0)
            {
                string priceStr = monitorListView.SelectedItems[0].SubItems[1].Text;
                if (decimal.TryParse(priceStr, out totalPrice))
                {
                    priceTextBox.Text = totalPrice.ToString();
                }
            }
        }
    }
} 