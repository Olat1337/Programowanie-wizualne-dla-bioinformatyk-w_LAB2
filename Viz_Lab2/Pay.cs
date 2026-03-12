using System;
using System.Windows.Forms;

namespace Viz_Lab2
{
    public partial class Pay : Form
    {
        private decimal _kwota;

        public Pay(decimal kwotaDoZaplaty)
        {
            InitializeComponent();
            _kwota = kwotaDoZaplaty;
            lblDoZaplaty.Text = _kwota.ToString("0.00") + " zł";
        }

        private void btnFinalizuj_Click(object sender, EventArgs e)
        {
            string metoda = "Nie wybrano";
            if (rb1.Checked) metoda = rb1.Text;
            else if (rb2.Checked) metoda = rb2.Text;
            else if (rb3.Checked) metoda = rb3.Text;
            else if (rb4.Checked) metoda = rb4.Text;
            MessageBox.Show($"Pomyślnie opłacono: {_kwota:0.00} zł\nMetoda: {metoda}", "Płatność", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblDoZaplaty_Click(object sender, EventArgs e)
        {

        }
    }
}