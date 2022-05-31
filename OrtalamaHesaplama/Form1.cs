namespace OrtalamaHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Tek satýrda da yazýlabilirdi ama rahat anlaþýlabilmesi için böyle yazdým.
            int sinav1 = Convert.ToInt32(TxtVize.Text);
            int sinav2 = Convert.ToInt32(TxtFinal.Text);
            int proje = Convert.ToInt32(TxtQuiz.Text);
            int ogrenciort = ((sinav1 * 35) + (sinav2 * 50) + (proje * 15)) / 100;

            

            listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort);
        }

        
    }
}
