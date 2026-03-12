namespace Viz_Lab2
{
    public partial class Choose : Form
    {
        private Zamów_jedzenie _mainForm;

        public Choose(Zamów_jedzenie mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                _mainForm.AddToMainListView(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}