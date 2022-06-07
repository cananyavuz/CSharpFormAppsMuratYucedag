namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            int soruNo = Convert.ToInt32(LabelSoruNo.Text);
            int dogru = Convert.ToInt32(LabelDogru.Text);
            int yanlis = Convert.ToInt32(LabelYanlis.Text);

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
                    break;
                case 2 :
                    richTextBox1.Text = " 10 + 28 kaçtýr? ";
                    button1.Text = "45";
                    button2.Text = "12";
                    button3.Text = "38";
                    button4.Text = "29";
                    button5.Text = "Sonraki";
                    break;
                case 3 :
                    richTextBox1.Text = "Cumhuriyet kaç yýlýnda ilan edilmiþtir?";
                    button1.Text = "1920";
                    button2.Text = "1923";
                    button3.Text = "1938";
                    button4.Text = "1919";
                    button5.Text = "Sonraki";
                    break;
                case 4:
                    richTextBox1.Text = "Doðru Sayýsý : " + LabelDogru.Text + "\nYanlýþ Sayýsý : " + LabelYanlis.Text;
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
        

        private void button1_Click(object sender, EventArgs e)
        {
            int soruNo = Convert.ToInt32(LabelSoruNo.Text);
            int dogru = Convert.ToInt32(LabelDogru.Text);
            int yanlis = Convert.ToInt32(LabelYanlis.Text);

            if (button1.Text == "Ýstanbul")
            {
                yanlis++;
                LabelYanlis.Text = yanlis.ToString();
                
            }
            if (button1.Text == "45")
            {
                yanlis++;
                LabelYanlis.Text = yanlis.ToString();

            }
            if (button1.Text == "1920")
            {
                yanlis++;
                LabelYanlis.Text = yanlis.ToString();

            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soruNo = Convert.ToInt32(LabelSoruNo.Text);
            int dogru = Convert.ToInt32(LabelDogru.Text);
            int yanlis = Convert.ToInt32(LabelYanlis.Text);

            if (button1.Text == "Ýzmir")
            {
                yanlis++;
                LabelYanlis.Text = yanlis.ToString();

            }
            if (button1.Text == "12")
            {
                yanlis++;
                LabelYanlis.Text = yanlis.ToString();

            }
            if (button1.Text == "1923")
            {
                dogru++;
                LabelDogru.Text = dogru.ToString();

            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int soruNo = Convert.ToInt32(LabelSoruNo.Text);
            int dogru = Convert.ToInt32(LabelDogru.Text);
            int yanlis = Convert.ToInt32(LabelYanlis.Text);

            if (button1.Text == "Bursa")
            {
                yanlis++;
                LabelYanlis.Text = yanlis.ToString();

            }
            if (button1.Text == "38")
            {
                dogru++;
                LabelDogru.Text = dogru.ToString();

            }
            if (button1.Text == "1938")
            {
                yanlis++;
                LabelYanlis.Text = yanlis.ToString();


            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int soruNo = Convert.ToInt32(LabelSoruNo.Text);
            int dogru = Convert.ToInt32(LabelDogru.Text);
            int yanlis = Convert.ToInt32(LabelYanlis.Text);

            if (button1.Text == "Ankara")
            {
                dogru++;
                LabelDogru.Text = dogru.ToString();

            }
            if (button1.Text == "29")
            {
                yanlis++;
                LabelYanlis.Text = yanlis.ToString();

            }
            if (button1.Text == "1919")
            {
                yanlis++;
                LabelYanlis.Text = yanlis.ToString();

            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void yanlis_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}