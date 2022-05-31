namespace SinemaBüfeSatisPaneli
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        //Ürün adetiyle işlem yaparken string'ten int'e tür değişimiyle uğraşmamak için yeni int değişkenleri tanımladım.
        int countMisir = 0, countSu = 0, countCay = 0, countBO = 0, countBY = 0;
       
        //ÜRÜN EKLEME BUTONLARI
        private void MısırArtıButton_Click(object sender, EventArgs e)
        {
            countMisir++;
            labelMisirAdet.Text = countMisir.ToString();
        }

        private void SuArtiButton_Click(object sender, EventArgs e)
        {
            countSu++;
            labelSuAdet.Text = countSu.ToString();
        }

        private void CayArtiButton_Click(object sender, EventArgs e)
        {
            countCay++;
            labelCayAdet.Text = countCay.ToString();
        }

        private void BOArtiButton_Click(object sender, EventArgs e)
        {
            countBO++;
            labelBltOgrAdet.Text = countBO.ToString();
        }

        private void BYArtiButton_Click(object sender, EventArgs e)
        {
            countBY++;
            labelBltYtsAdet.Text = countBY.ToString();
        }
        //ÜRÜN ÇIKARMA BUTONLARI
        private void MısırEksiButton_Click(object sender, EventArgs e)
        {
            //adet miktarını negatif değer döndürmemesi için adet miktarı 0'ken değeri 0'a sabitledim.
            if (Convert.ToInt16(labelMisirAdet.Text) == 0 )
                countMisir = 0;
            else
            {
                countMisir--;
            }
            labelMisirAdet.Text = countMisir.ToString();
        }

        

        private void SuEksiButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(labelSuAdet.Text) == 0 )
                countSu = 0;
            else
            {
                countSu--;
            }
            labelSuAdet.Text = countSu.ToString();
        }

        

        private void CayEksiButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(labelCayAdet.Text) == 0 )
                countCay = 0;
            else
            {
                countCay--;
            }
            labelCayAdet.Text = countCay.ToString();
        }

        private void BOEksiButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(labelBltOgrAdet.Text) == 0 )
                countBO = 0;
            else
            {
                countBO--;
            }
            labelBltOgrAdet.Text = countBO.ToString();
        }

        private void BYEksiButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(labelBltYtsAdet.Text) == 0 )
                countBY = 0;
            else
            {
                countBY--;
            }
            labelBltYtsAdet.Text = countBY.ToString();
        }


        int hesap;
        int kasaHesap = 0;

        private void HesaplaButton_Click(object sender, EventArgs e)
        {

            hesap = (countMisir*12 + countSu*2 + countCay*4 + countBO*20 + countBY*30);
            labelToplam.Text = "Toplam: " + hesap + " TL";

            kasaHesap += hesap;
            labelKasa.Text = kasaHesap + " TL";

            //yeni işlem yapabilmek için değerleri eski haline getirdim.
            labelMisirAdet.Text = "0";
            labelSuAdet.Text = "0";
            labelCayAdet.Text = "0";
            labelBltOgrAdet.Text = "0";
            labelBltYtsAdet.Text = "0";


            countMisir = 0;
            countSu = 0;
            countCay = 0;
            countBO = 0;
            countBY = 0;

        }
        //son eklenen hesabı kasadan çıkarma butonu(yanlış işlem olursa diye)
        private void button1_Click(object sender, EventArgs e)
        {
            int yenikasa = kasaHesap - hesap;
            labelKasa.Text = yenikasa + " TL";
            labelToplam.Text = "Toplam: 00 TL";

        }
    }
}