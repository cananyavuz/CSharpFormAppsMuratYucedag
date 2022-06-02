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
            double ogrenciort = ((sinav1 * 35) + (sinav2 * 50) + (proje * 15)) / 100;



            //AA / 90 - 100 / 4.0 / Baþarýlý
            //BA / 80 - 89 / 3.5 / Baþarýlý
            //BB / 75 - 79 / 3.0 / Baþarýlý
            //CB / 70 - 74 / 2.5 / Baþarýlý
            //CC / 60 - 69 / 2.0 / Baþarýlý
            //DC / 50 - 59 / 1.5 / Koþullu Baþarýlý - Baþarýsýz.
            //DD / 40 - 49 / 1.0 / Baþarýsýz.
            //FD / 30 - 39 / 0.5 / Baþarýsýz.
            //FF / 0 - 29 / 0.0 / Baþarýsýz.

            if (ogrenciort >= 90 && ogrenciort <= 100.0)
            {
                listBox1.Items.Add(TxtAd + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (AA) Baþarýlý");
            }
            else if (ogrenciort >=  80 && ogrenciort <= 89)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (BA) Baþarýlý");
            }
            else if (ogrenciort >= 75 && ogrenciort <= 79)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (BB) Baþarýlý");
            }
            else if (ogrenciort >= 70 && ogrenciort <= 74)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (CB) Baþarýlý");
            }
            else if (ogrenciort >= 60 && ogrenciort <= 69)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (CC) Baþarýlý");
            }
            else if (ogrenciort >= 50 && ogrenciort <= 59)
            {
                listBox1.Items.Add( TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (DC) Koþullu Baþarýlý - Baþarýsýz");
            }
            else if (ogrenciort >= 40 && ogrenciort <= 49)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (DD) Baþarýsýz");
            }
            else if (ogrenciort >= 30 && ogrenciort <= 39)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (FD) Baþarýsýz");
            }
            else
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (FF) Baþarýsýz");
            }

            TxtAd.Clear();
            TxtSoyad.Clear();
            TxtVize.Clear();
            TxtFinal.Clear(); 
            TxtQuiz.Clear();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
