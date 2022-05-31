namespace BiletAlmaEkrani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Yön deðiþtirme butonu
        private void button1_Click(object sender, EventArgs e)
        {
            //Tanýmladýðým deðiþken sayesinde iki farklý deðeri birbirlerine atadým.
            string nereden = comboBoxNereden.Text;
            comboBoxNereden.Text = comboBoxNereye.Text; 
            comboBoxNereye.Text = nereden;
        }

        //Uçuþ ve Yolcu Bilgilerini RichTextBox'a yazdýrma ve panelleri eski haline getirme butonu
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            //Kullanýcýnýn girdiði bilgileri richTextBox'a yazdýran kod
            richTextBox.Text = ("KAYIT BÝLGÝSÝ " +
                "\nYolcu Ad Soyad: " + TxtAdSoyad.Text +
                "\nYolcu Tipi: " + comboBoxYolcuTipi.Text +
                "\nYolcu TC: " + maskedTextBoxTc.Text +
                "\nYolcu Telefonu: " + maskedTextBoxTelefon.Text +
                "\nUçuþ Rotasý: " + comboBoxNereden.Text + " - " + comboBoxNereye.Text +
                "\nUçuþ Tarihi" + dateTimePicker1.Text +
                "\nUçuþ Saati:" + maskedTextBoxSaat.Text +
                "\n---------------------------------------");

            //Kullanýcýdan yeni bilgi alýrken kolaylýk saðlamak için panelleri eski haline getiren kod
            TxtAdSoyad.Clear();
            comboBoxYolcuTipi.Text = "Yolcu Tipi Seçiniz";
            maskedTextBoxTc.Clear();
            maskedTextBoxTelefon.Clear();   
            comboBoxNereden.Text = "Þehir Seçiniz";
            comboBoxNereye.Text = "Þehir Seçiniz";
            dateTimePicker1.ResetText();
            maskedTextBoxSaat.ResetText();

        }
    }
}