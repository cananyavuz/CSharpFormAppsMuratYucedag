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

            // Tek satirda da yazilabilirdi ama rahat anlasilabilmesi icin boyle yazdim.
            int sinav1 = Convert.ToInt32(TxtVize.Text);
            int sinav2 = Convert.ToInt32(TxtFinal.Text);
            int proje = Convert.ToInt32(TxtQuiz.Text);
            double ogrenciort = ((sinav1 * 35) + (sinav2 * 50) + (proje * 15)) / 100;



            //AA / 90 - 100 / 4.0 / Basarili
            //BA / 80 - 89 / 3.5 / Basarili
            //BB / 75 - 79 / 3.0 / Basarili
            //CB / 70 - 74 / 2.5 / Basarili
            //CC / 60 - 69 / 2.0 / Basarili
            //DC / 50 - 59 / 1.5 / Koþullu Basarili - Basarisiz
            //DD / 40 - 49 / 1.0 / Basarisiz
            //FD / 30 - 39 / 0.5 / Basarisiz
            //FF / 0 - 29 / 0.0 / Basarisiz

            if (ogrenciort >= 90 && ogrenciort <= 100.0)
            {
                listBox1.Items.Add(TxtAd + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (AA) Basarili");
            }
            else if (ogrenciort >=  80 && ogrenciort <= 89)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (BA) Basarili");
            }
            else if (ogrenciort >= 75 && ogrenciort <= 79)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (BB) Basarili");
            }
            else if (ogrenciort >= 70 && ogrenciort <= 74)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (CB) Basarili");
            }
            else if (ogrenciort >= 60 && ogrenciort <= 69)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (CC) Basarili");
            }
            else if (ogrenciort >= 50 && ogrenciort <= 59)
            {
                listBox1.Items.Add( TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (DC) Koþullu Basarili - Basarisiz");
            }
            else if (ogrenciort >= 40 && ogrenciort <= 49)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (DD) Basarisiz");
            }
            else if (ogrenciort >= 30 && ogrenciort <= 39)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (FD) Basarisiz");
            }
            else
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (FF) Basarisiz");
            }

            TxtAd.Clear();
            TxtSoyad.Clear();
            TxtVize.Clear();
            TxtFinal.Clear(); 
            TxtQuiz.Clear();


        }

        
    }
}
