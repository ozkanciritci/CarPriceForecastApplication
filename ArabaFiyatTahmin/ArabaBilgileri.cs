using System.Data.SqlClient;

namespace ArabaFiyatTahmin
{
    public partial class ArabaBilgileri : Form
    {
        public static double arabaBilgileriHesaplananFiyat;
        public static double arabaBilgileriToplamCarpan;
        int arabaEnYuksekFiyat;
        public static int arabaEnDusukFiyat;
        //double toplamDegerKaybi;


        int arabaYas = 1;
        double arabaKm = 1;
        double arabaBeygir = 1;
        double dbGelenMaxBeygir = 1;
        int arabaDurumPuan = 1;
        double arabaYiliCarpani = 1;
        double arabaKmCarpani = 1;
        double arabaBeygirCarpani = 1;
        double arabaPaketCarpani = 1;
        double arabaDurumCarpani = 1;
        double renkCarpani = 1;
        double yakitCarpani = 1;
        double govdeTipiCarpani = 1;



        SqlConnection baglan = new SqlConnection(@"Data Source=™ZKAN\SQLEXPRESS;Initial Catalog=Db_OtomobiBilgileri;Integrated Security=True");
        public ArabaBilgileri()
        {
            InitializeComponent();
        }




        private void aracyilicomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            arabaYas = 33 - (aracyilicomboBox.SelectedIndex);
            arabaYiliCarpani = (1 - (arabaYas * 0.03)); // 0.03

        }


        private void aracmarkasi_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                baglan.Open();

                //SqlCommand sqlKomut = new SqlCommand("Select* FROM ArabaBilgisi where ArabaMarkaId='1'", baglan);
                string query = "SELECT * FROM ArabaBilgisi WHERE ArabaMarkaId = @markaId";
                SqlCommand sqlKomut = new SqlCommand(query, baglan);

                aracModelicomboBox.Items.Clear();
                int arabaMarkaSelectedIndex = aracmarkasicomboBox.SelectedIndex;
                int markaIndex = arabaMarkaSelectedIndex + 1;

                sqlKomut.Parameters.AddWithValue("@markaId", markaIndex);
                SqlDataReader sqlDR = sqlKomut.ExecuteReader();
                while (sqlDR.Read())
                {
                    aracModelicomboBox.Items.Add(sqlDR[2].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("modeller dbden gelmedi" + ex.ToString());
            }
            finally
            {
                if (baglan != null)
                    baglan.Close();
            }

        }

        private void aracModelicomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                baglan.Open();

                string query = "SELECT beygir,EnYuksekFiyat,EnDusukFiyat FROM ArabaBilgisi WHERE Model =  @beygir";

                SqlCommand sqlKomut = new SqlCommand(query, baglan);

                String modelAdi = aracModelicomboBox.Text;
                sqlKomut.Parameters.AddWithValue("@beygir", modelAdi);

                SqlDataReader sqlDR = sqlKomut.ExecuteReader();

                sqlDR.Read();
                // denemelertextBox.Text = sqlDR[0].ToString();

                dbGelenMaxBeygir = Convert.ToInt32(sqlDR[0]);
                arabaEnYuksekFiyat = Convert.ToInt32(sqlDR[1]);
                arabaEnDusukFiyat = Convert.ToInt32(sqlDR[2]);
                // denemelertextBox.Text = arabaEnYuksekFiyat.ToString();




            }
            catch (Exception ex)
            {
                MessageBox.Show("beygir dbden gelmedi" + ex.ToString());
            }
            finally
            {
                if (baglan != null)
                    baglan.Close();
            }


        }

        private void aracinkmsitextBox1_TextChanged_3(object sender, EventArgs e)
        {

            arabaKm = Convert.ToDouble(aracinkmsitextBox1.Text);
            arabaKmCarpani = (1 - ((arabaKm / 5000) * 0.01));//500.000   carpan duzelt


        }


        private void arabaDurumPuancomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            arabaDurumPuan = 10 - (arabaDurumPuancomboBox.SelectedIndex);
            arabaDurumCarpani = (1 - (arabaDurumPuan * 0.05));

        }



        private void beygirtextBox1_TextChanged(object sender, EventArgs e)
        {
            arabaBeygir = Convert.ToDouble(beygirtextBox1.Text);
            arabaBeygirCarpani = arabaBeygir / dbGelenMaxBeygir;


        }

        private void ortaPaketradioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (ortaPaketradioButton2.Checked == true)
            {
                arabaPaketCarpani = 0.95;


            }
        }

        private void doluPaketradioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (doluPaketradioButton3.Checked == true)
            {
                arabaPaketCarpani = 1;


            }
        }

        private void dusukPaketradioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (dusukPaketradioButton1.Checked == true)
            {
                arabaPaketCarpani = 0.9;

            }
        }

        private void ileributton_Click(object sender, EventArgs e)
        {
            arabaBilgileriHesaplananFiyat = arabaEnYuksekFiyat;
            arabaBilgileriToplamCarpan = arabaYiliCarpani * arabaKmCarpani * arabaBeygirCarpani * arabaPaketCarpani * arabaDurumCarpani * renkCarpani * yakitCarpani * govdeTipiCarpani;
            System.Diagnostics.Debug.WriteLine(arabaBilgileriToplamCarpan);

            BoyaHasar boyaHasar = new BoyaHasar();
            this.Hide();
            boyaHasar.Show();


        }

        private void govdeTipicomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (govdeTipicomboBox.SelectedIndex > 2)
            {
                govdeTipiCarpani = 1.03;
            }
        }

        private void yakitTipicomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (yakitTipicomboBox.SelectedIndex == 1)
            {
                yakitCarpani = 1.03;
            }
            else {
                yakitCarpani = 1;
            }
            
        }

        private void renkcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (renkcomboBox.SelectedIndex < 2)
            {
                renkCarpani = 0.98;
            }
            else
            {
                renkCarpani = 1.02;
            }


        }

        private void ArabaBilgileri_Load(object sender, EventArgs e)
        {


            try
            {
                baglan.Open();

                SqlCommand sqlKomut = new SqlCommand("Select* FROM ArabaMarka", baglan);
                SqlDataReader sqlDR = sqlKomut.ExecuteReader();
                while (sqlDR.Read())
                {

                    aracmarkasicomboBox.Items.Add(sqlDR[1].ToString());


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("markalar dbden gelmedi" + ex.ToString());
            }
            finally
            {
                if (baglan != null)
                    baglan.Close();
            }





            string[] govdeTipi = { "sedan", "hatchback", "suv", "cupe", "cabrio", "sportback" };//SON 3 DE 1,03 SON 3 DE CARP
            govdeTipicomboBox.Items.AddRange(govdeTipi);
            string[] renkler = { "beyaz","siyah" , "gri", "mavi", "kirmizi", "altýn", "bej", "bordo", "fume", "kahverengi", "mavi", "mor", "sampanya", "sari", "turuncu", "yesil", "diger" }; //%0.02 ILK 5 DE DUS
            renkcomboBox.Items.AddRange(renkler);

            string[] arabadurumupuan = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            arabaDurumPuancomboBox.Items.AddRange(arabadurumupuan);
            string[] yakitTipi = { "benzin", "dizel", "elektirikli" };// DIZELDE 1.03 CARP
            yakitTipicomboBox.Items.AddRange(yakitTipi);


            string[] aracYili = { "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000","2001","2002","2003"
            ,"2004","2005","2006","2007","2008","2009","2010","2011","2012","2013","2014","2015","2016","2017","2018","2019","2020","2021","2022","2023"};
            aracyilicomboBox.Items.AddRange(aracYili);


        }



        private void ArabaBilgileri_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();

        }

        private void aracinDolulukPaketi_Enter(object sender, EventArgs e)
        {

        }

        private void aracinkmsitextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void beygirtextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}