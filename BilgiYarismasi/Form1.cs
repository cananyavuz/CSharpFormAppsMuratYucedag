namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        int soruNo = 0, yanlis = 0,dogru=0;

        private void button5_Click(object sender, EventArgs e)
        { 
            soruNo++;
            LabelSoruNo.Text = soruNo.ToString();
            
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            switch (soruNo)
            {
                case 1 :
                    richTextBox1.Text = "Türkiye'nin baþkenti neresidir?";
                    button1.Text = "Ýstanbul";
                    button2.Text = "Ýzmir";
                    button3.Text = "Bursa";
                    button4.Text = "Ankara";
                    button5.Text = "Sonraki";
                    DogruSecenek.Text = "Ankara";
                    break;
                case 2 :
                    richTextBox1.Text = " 10 + 28 kaçtýr? ";
                    button1.Text = "45";
                    button2.Text = "12";
                    button3.Text = "38";
                    button4.Text = "29";
                    button5.Text = "Sonraki";
                    DogruSecenek.Text = "38";
                    break;
                case 3 :
                    richTextBox1.Text = "Cumhuriyet kaç yýlýnda ilan edilmiþtir?";
                    button1.Text = "1920";
                    button2.Text = "1923";
                    button3.Text = "1938";
                    button4.Text = "1919";
                    button5.Text = "Sonraki";
                    DogruSecenek.Text = "1923";
                    break;
                case 4:
                    richTextBox1.Text = "Sýnav Bitti";
                    button1.Text = " ";
                    button2.Text = " ";
                    button3.Text = " ";
                    button4.Text = " ";
                    button5.Text = "Sonuçlar";

                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    break ;

            }
        }
        
        public void butonreset()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (DogruSecenek.Text == button1.Text)
            {
                dogru++;
                LabelDogru.Text = Convert.ToString(dogru);

            }
            else
            {
                yanlis++;
                LabelYanlis.Text = Convert.ToString(yanlis);
            }
            

            butonreset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DogruSecenek.Text == button2.Text)
            {
                dogru++;
                LabelDogru.Text = Convert.ToString(dogru);

            }
            else
            {
                yanlis++;
                LabelYanlis.Text = Convert.ToString(yanlis);
            }


            butonreset();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (DogruSecenek.Text == button3.Text)
            {
                dogru++;
                LabelDogru.Text = Convert.ToString(dogru);

            }
            else
            {
                yanlis++;
                LabelYanlis.Text = Convert.ToString(yanlis);
            }


            butonreset();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (DogruSecenek.Text == button4.Text)
            {
                dogru++;
                LabelDogru.Text = Convert.ToString(dogru);

            }
            else
            {
                yanlis++;
                LabelYanlis.Text = Convert.ToString(yanlis);
            }


            butonreset();
        }

        
    }
}