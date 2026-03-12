using System;
using System.Windows.Forms;

namespace Viz_Lab2
{
    public partial class Zamów_jedzenie : Form
    {
        private decimal sumaCalkowita = 0;
        private string aktualnyTransport = ""; 

        public Zamów_jedzenie()
        {
            InitializeComponent();
            listView1.View = View.Details;
        }

        public void AddToMainListView(string nazwa, decimal cena)
        {
            listView1.View = View.Details;

            if (listView1.Columns.Count == 0)
            {
                listView1.Columns.Add("Produkt", 130);
                listView1.Columns.Add("Cena", 70);
            }

            ListViewItem item = new ListViewItem(nazwa);
            item.SubItems.Add(cena.ToString("0.00") + " zł");
            listView1.Items.Add(item);
            sumaCalkowita += cena;
            lblSuma.Text = $"Suma: {sumaCalkowita:0.00} zł";
            listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choose chooseForm = new Choose(this);
            chooseForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Transport transportForm = new Transport())
            {
                if (transportForm.ShowDialog() == DialogResult.OK)
                {
                    aktualnyTransport = transportForm.WybranaOpcja;
                    lblTransportStatus.MaximumSize = new Size(160, 0);
                    lblTransportStatus.AutoSize = true;
                    lblTransportStatus.Text = "Transport:\n" + aktualnyTransport;
                }
            }
        }

        private void btnOpenPay_Click(object sender, EventArgs e)
        {
            if (sumaCalkowita == 0)
            {
                MessageBox.Show("Twój koszyk jest pusty! Dodaj najpierw jedzenie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(aktualnyTransport) || aktualnyTransport == "Brak" || aktualnyTransport == "Brak wyboru")
            {
                MessageBox.Show("Proszę najpierw wybrać opcję transportu!", "Brak transportu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (Pay payForm = new Pay(sumaCalkowita))
            {
                if (payForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Twoje zamówienie zostało przyjęte do realizacji!\nJedzenie już do Ciebie jedzie. Smacznego!", "Zamówienie w drodze", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView1.Items.Clear();
                    sumaCalkowita = 0;
                    aktualnyTransport = ""; 
                    lblSuma.Text = "Suma: 0.00 zł";
                    lblTransportStatus.Text = "Transport: ---";
                }
            }
        }
    }
    
}