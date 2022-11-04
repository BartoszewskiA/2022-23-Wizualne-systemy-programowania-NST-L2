namespace lab01p04
{
    public partial class Form1 : Form
    {
        private int wartosc_zrodlowa = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            wartosc_zrodlowa = hScrollBar1.Value;
            label1.Text = wartosc_zrodlowa.ToString() + " m";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double wartosc_wynikowa;
            if (radioButton1.Checked)
            {
                wartosc_wynikowa = wartosc_zrodlowa / 1000.0;
            } else if(radioButton2.Checked)
            {
                wartosc_wynikowa = wartosc_zrodlowa * 10;
            }else
            {
                wartosc_wynikowa = wartosc_zrodlowa * 1000;
            }

            label2.Text = wartosc_wynikowa.ToString();
        }
    }
}