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

            // Tek sat�rda da yaz�labilirdi ama rahat anla��labilmesi i�in b�yle yazd�m.
            int sinav1 = Convert.ToInt32(TxtVize.Text);
            int sinav2 = Convert.ToInt32(TxtFinal.Text);
            int proje = Convert.ToInt32(TxtQuiz.Text);
            double ogrenciort = ((sinav1 * 35) + (sinav2 * 50) + (proje * 15)) / 100;



            //AA / 90 - 100 / 4.0 / Ba�ar�l�
            //BA / 80 - 89 / 3.5 / Ba�ar�l�
            //BB / 75 - 79 / 3.0 / Ba�ar�l�
            //CB / 70 - 74 / 2.5 / Ba�ar�l�
            //CC / 60 - 69 / 2.0 / Ba�ar�l�
            //DC / 50 - 59 / 1.5 / Ko�ullu Ba�ar�l� - Ba�ar�s�z.
            //DD / 40 - 49 / 1.0 / Ba�ar�s�z.
            //FD / 30 - 39 / 0.5 / Ba�ar�s�z.
            //FF / 0 - 29 / 0.0 / Ba�ar�s�z.

            if (ogrenciort >= 90 && ogrenciort <= 100.0)
            {
                listBox1.Items.Add(TxtAd + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (AA) Ba�ar�l�");
            }
            else if (ogrenciort >=  80 && ogrenciort <= 89)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (BA) Ba�ar�l�");
            }
            else if (ogrenciort >= 75 && ogrenciort <= 79)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (BB) Ba�ar�l�");
            }
            else if (ogrenciort >= 70 && ogrenciort <= 74)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (CB) Ba�ar�l�");
            }
            else if (ogrenciort >= 60 && ogrenciort <= 69)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (CC) Ba�ar�l�");
            }
            else if (ogrenciort >= 50 && ogrenciort <= 59)
            {
                listBox1.Items.Add( TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (DC) Ko�ullu Ba�ar�l� - Ba�ar�s�z");
            }
            else if (ogrenciort >= 40 && ogrenciort <= 49)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (DD) Ba�ar�s�z");
            }
            else if (ogrenciort >= 30 && ogrenciort <= 39)
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (FD) Ba�ar�s�z");
            }
            else
            {
                listBox1.Items.Add(TxtAd.Text + " " + TxtSoyad.Text + " Ortalama: " + ogrenciort + " / (FF) Ba�ar�s�z");
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
