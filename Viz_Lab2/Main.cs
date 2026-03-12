namespace Viz_Lab2
{
    public partial class Zamów_jedzenie : Form
    {
        public Zamów_jedzenie()
        {
            InitializeComponent();
        }

        public void AddToMainListView(ListViewItem item)
        {
            listView1.Items.Add((ListViewItem)item.Clone());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Choose chooseForm = new Choose(this);
            chooseForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transport transportForm = new Transport();
            transportForm.Show();
        }
    }
}