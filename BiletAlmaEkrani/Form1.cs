namespace BiletAlmaEkrani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Y�n de�i�tirme butonu
        private void button1_Click(object sender, EventArgs e)
        {
            //Tan�mlad���m de�i�ken sayesinde iki farkl� de�eri birbirlerine atad�m.
            string nereden = comboBoxNereden.Text;
            comboBoxNereden.Text = comboBoxNereye.Text; 
            comboBoxNereye.Text = nereden;
        }

        //U�u� ve Yolcu Bilgilerini RichTextBox'a yazd�rma ve panelleri eski haline getirme butonu
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            //Kullan�c�n�n girdi�i bilgileri richTextBox'a yazd�ran kod
            richTextBox.Text = ("KAYIT B�LG�S� " +
                "\nYolcu Ad Soyad: " + TxtAdSoyad.Text +
                "\nYolcu Tipi: " + comboBoxYolcuTipi.Text +
                "\nYolcu TC: " + maskedTextBoxTc.Text +
                "\nYolcu Telefonu: " + maskedTextBoxTelefon.Text +
                "\nU�u� Rotas�: " + comboBoxNereden.Text + " - " + comboBoxNereye.Text +
                "\nU�u� Tarihi" + dateTimePicker1.Text +
                "\nU�u� Saati:" + maskedTextBoxSaat.Text +
                "\n---------------------------------------");

            //Kullan�c�dan yeni bilgi al�rken kolayl�k sa�lamak i�in panelleri eski haline getiren kod
            TxtAdSoyad.Clear();
            comboBoxYolcuTipi.Text = "Yolcu Tipi Se�iniz";
            maskedTextBoxTc.Clear();
            maskedTextBoxTelefon.Clear();   
            comboBoxNereden.Text = "�ehir Se�iniz";
            comboBoxNereye.Text = "�ehir Se�iniz";
            dateTimePicker1.ResetText();
            maskedTextBoxSaat.ResetText();

        }
    }
}