using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArabaFiyatTahmin
{
    enum ParcaKontrol
    {
        Orjinal,
        Boyali,
        Degisen
    }
    public partial class BoyaHasar : Form
    {


        int degisenSayisi = 0;
        int boyaliSayisi = 0;
        int orjinalSayisi = 0;
        double degisenCarpani;
        double boyaliCarpani;
        double orjinalCarpani;
        double tramerCarpani=1;
        int tramer=0;
        public static double arabaBoyaHasarFormuSonrasiFiyat = ArabaBilgileri.arabaBilgileriHesaplananFiyat;
        public static double boyaHasarToplamCarpan = ArabaBilgileri.arabaBilgileriToplamCarpan;
        int endusukFiyat = ArabaBilgileri.arabaEnDusukFiyat;
        double toplamCarpan;
        ParcaKontrol[] parcaListesi = new ParcaKontrol[13];


        public BoyaHasar()
        {
            InitializeComponent();
        }



        private void tramerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tramerComboBox.SelectedIndex == 2)
            {
                tramerCarpani = 0.65;
            }

        }

        private void toplamTramerTutarıTextBox_TextChanged(object sender, EventArgs e)
        {
            tramer = Convert.ToInt32(toplamTramerTutarıTextBox.Text);

            //arabaBoyaHasarFormuSonrasiFiyat = arabaBoyaHasarFormuSonrasiFiyat - tramer;
        }

        private void sagArkaCamurlukcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (sagArkaCamurlukcomboBox1.SelectedIndex == 0)
            {
                parcaListesi[0] = ParcaKontrol.Orjinal;

            }
            else if (sagArkaCamurlukcomboBox1.SelectedIndex == 1)
            {
                parcaListesi[0] = ParcaKontrol.Boyali;
            }
            else
            {
                parcaListesi[0] = ParcaKontrol.Degisen;


            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                parcaListesi[1] = ParcaKontrol.Orjinal;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                parcaListesi[1] = ParcaKontrol.Boyali;
            }
            else
            {
                parcaListesi[1] = ParcaKontrol.Degisen;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                parcaListesi[2] = ParcaKontrol.Orjinal;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                parcaListesi[2] = ParcaKontrol.Boyali;
            }
            else
            {
                parcaListesi[2] = ParcaKontrol.Degisen;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                parcaListesi[3] = ParcaKontrol.Orjinal;
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                parcaListesi[3] = ParcaKontrol.Boyali;
            }
            else
            {
                parcaListesi[3] = ParcaKontrol.Degisen;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                parcaListesi[4] = ParcaKontrol.Orjinal;
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                parcaListesi[4] = ParcaKontrol.Boyali;
            }
            else
            {
                parcaListesi[4] = ParcaKontrol.Degisen;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                parcaListesi[5] = ParcaKontrol.Orjinal;
            }
            else if (comboBox5.SelectedIndex == 1)
            {
                parcaListesi[5] = ParcaKontrol.Boyali;
            }
            else
            {
                parcaListesi[5] = ParcaKontrol.Degisen;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex == 0)
            {
                parcaListesi[6] = ParcaKontrol.Orjinal;
            }
            else if (comboBox6.SelectedIndex == 1)
            {
                parcaListesi[6] = ParcaKontrol.Boyali;
            }
            else
            {
                parcaListesi[6] = ParcaKontrol.Degisen;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.SelectedIndex == 0)
            {
                parcaListesi[7] = ParcaKontrol.Orjinal;
            }
            else if (comboBox7.SelectedIndex == 1)
            {
                parcaListesi[7] = ParcaKontrol.Boyali;
            }
            else
            {
                parcaListesi[7] = ParcaKontrol.Degisen;
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox8.SelectedIndex == 0)
            {
                parcaListesi[8] = ParcaKontrol.Orjinal;
            }
            else if (comboBox8.SelectedIndex == 1)
            {
                parcaListesi[8] = ParcaKontrol.Boyali;
            }
            else
            {
                parcaListesi[8] = ParcaKontrol.Degisen;
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox9.SelectedIndex == 0)
            {
                parcaListesi[9] = ParcaKontrol.Orjinal;
            }
            else if (comboBox9.SelectedIndex == 1)
            {
                parcaListesi[9] = ParcaKontrol.Boyali;
            }
            else
            {
                parcaListesi[9] = ParcaKontrol.Degisen;
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.SelectedIndex == 0)
            {
                parcaListesi[10] = ParcaKontrol.Orjinal;
            }
            else if (comboBox10.SelectedIndex == 1)
            {
                parcaListesi[10] = ParcaKontrol.Boyali;
            }
            else
            {
                parcaListesi[10] = ParcaKontrol.Degisen;
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox11.SelectedIndex == 0)
            {
                parcaListesi[11] = ParcaKontrol.Orjinal;
            }
            else if (comboBox11.SelectedIndex == 1)
            {
                parcaListesi[11] = ParcaKontrol.Boyali;
            }
            else
            {
                parcaListesi[11] = ParcaKontrol.Degisen;
            }
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox12.SelectedIndex == 0)
            {
                parcaListesi[12] = ParcaKontrol.Orjinal;
            }
            else if (comboBox12.SelectedIndex == 1)
            {
                parcaListesi[12] = ParcaKontrol.Boyali;
            }
            else
            {
                parcaListesi[12] = ParcaKontrol.Degisen;
            }

            //  var groupedParcaListesi = parcaListesi.GroupBy(p => p);
            //
            //  foreach (var group in groupedParcaListesi)
            //  {
            //      aracbilgileridenemetextBox1.AppendText($"{group.Key}: {group.Count()}{Environment.NewLine}");
            //  }

        }

        private void hesaplaButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(endusukFiyat);

            Sonuc sonucsayfasi = new Sonuc();






            foreach (ParcaKontrol parca in parcaListesi)
            {
                switch (parca)
                {
                    case ParcaKontrol.Degisen:
                        degisenSayisi++;
                        break;
                    case ParcaKontrol.Boyali:
                        boyaliSayisi++;
                        break;
                    case ParcaKontrol.Orjinal:
                        orjinalSayisi++;
                        break;
                }
            }

            degisenCarpani = 1 - (degisenSayisi * 0.024);
            boyaliCarpani = 1 - (boyaliSayisi * 0.015);
            orjinalCarpani = 1;

            toplamCarpan = boyaHasarToplamCarpan * degisenCarpani * boyaliCarpani * orjinalCarpani;
            arabaBoyaHasarFormuSonrasiFiyat = arabaBoyaHasarFormuSonrasiFiyat * toplamCarpan* tramerCarpani;
            arabaBoyaHasarFormuSonrasiFiyat = arabaBoyaHasarFormuSonrasiFiyat - tramer;
           if (arabaBoyaHasarFormuSonrasiFiyat < endusukFiyat) {
               arabaBoyaHasarFormuSonrasiFiyat = endusukFiyat;
           }

            Sonuc sonucekrani = new Sonuc();

            sonucsayfasi.Owner = this;
            this.Hide();
            sonucsayfasi.Show();


        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            ArabaBilgileri arabaBilgileri = new ArabaBilgileri();
            this.Hide();
            arabaBilgileri.Show();
        }

        private void BoyaHasar_Load(object sender, EventArgs e)
        {

            
            System.Diagnostics.Debug.WriteLine("BoyaHasar_Load");


            System.Diagnostics.Debug.WriteLine(boyaHasarToplamCarpan);
            string[] tramer = { "yok", "var", "agir hasarli" };
            tramerComboBox.Items.AddRange(tramer);

            string[] aracparcasi = { "orjinal", "boyali", "degisen" };
            sagArkaCamurlukcomboBox1.Items.AddRange(aracparcasi);
            comboBox1.Items.AddRange(aracparcasi);
            comboBox2.Items.AddRange(aracparcasi);
            comboBox3.Items.AddRange(aracparcasi);
            comboBox4.Items.AddRange(aracparcasi);
            comboBox5.Items.AddRange(aracparcasi);
            comboBox6.Items.AddRange(aracparcasi);
            comboBox7.Items.AddRange(aracparcasi);
            comboBox8.Items.AddRange(aracparcasi);
            comboBox9.Items.AddRange(aracparcasi);
            comboBox10.Items.AddRange(aracparcasi);
            comboBox11.Items.AddRange(aracparcasi);
            comboBox12.Items.AddRange(aracparcasi);

            


        }



        private void BoyaHasar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void aracbilgileridenemetextBox1_TextChanged(object sender, EventArgs e)
        {




        }

        private void toplamTramerTutarıTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void sonuctextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
