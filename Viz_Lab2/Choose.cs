using System;
using System.Windows.Forms;

namespace Viz_Lab2
{
    public partial class Choose : Form
    {
        private Zamów_jedzenie _mainForm;

        public Choose(Zamów_jedzenie mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            listBox1.Items.Add("Pizza Margherita - 32,00");
            listBox1.Items.Add("Burger Wołowy - 28,50");
            listBox1.Items.Add("Sałatka Cezar - 24,00");
            listBox1.Items.Add("Kawa - 10,00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string linia = listBox1.SelectedItem.ToString();
                string[] czesci = linia.Split('-');
                string nazwa = czesci[0].Trim();
                string cenaString = czesci[1].Trim();
                cenaString = cenaString.Replace(",", ".");
                decimal cena = decimal.Parse(cenaString, System.Globalization.CultureInfo.InvariantCulture);

                _mainForm.AddToMainListView(nazwa, cena);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}