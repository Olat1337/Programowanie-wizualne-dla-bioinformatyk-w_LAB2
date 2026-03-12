using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Viz_Lab2
{
    public partial class Transport : Form
    {
        public string WybranaOpcja { get; private set; }

        public Transport()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<string> wybrane = new List<string>();
            if (checkBox1.Checked) wybrane.Add(checkBox1.Text);
            if (checkBox2.Checked) wybrane.Add(checkBox2.Text);
            if (checkBox3.Checked) wybrane.Add(checkBox3.Text);
            if (checkBox4.Checked) wybrane.Add(checkBox4.Text);
            WybranaOpcja = wybrane.Count > 0 ? string.Join(", ", wybrane) : "Brak wyboru";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}