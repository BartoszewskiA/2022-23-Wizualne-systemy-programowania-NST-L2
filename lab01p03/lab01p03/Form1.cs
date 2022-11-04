namespace lab01p03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int metry;
            double kilometry;
            metry = hScrollBar1.Value;
            kilometry = metry / 1000.0;
            label1.Text = metry.ToString() + " m";
            label2.Text = kilometry.ToString() + " km";
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int metry;
            double kilometry;
            metry = hScrollBar1.Value;
            kilometry = metry / 1000.0;
            label1.Text = metry.ToString() + " m";
            label2.Text = kilometry.ToString() + " km";
        }
    }
}