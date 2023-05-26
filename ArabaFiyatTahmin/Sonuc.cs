using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaFiyatTahmin
{
    public partial class Sonuc : Form
    {

        public static double sonuc = BoyaHasar.arabaBoyaHasarFormuSonrasiFiyat;

        public Sonuc()
        {
            InitializeComponent();
        }

        private void Sonuc_Load(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("tr-TR");

            int sonsonuc = (int)sonuc;
            int enuygunfiyat = (int)(sonsonuc * 0.90);
            int pahaliFiyat = (int)(sonsonuc * 1.1);

            piyasaFiyatiTextBox.Text = sonsonuc.ToString("N0", culture);
            enUygunTextBox.Text = enuygunfiyat.ToString("N0", culture);

            pahaliFiyatiTextBox.Text = pahaliFiyat.ToString("N0", culture);
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anaSayfayaDon_Click(object sender, EventArgs e)
        {
            ArabaBilgileri arabaBilgileri = new ArabaBilgileri();
            this.Hide();
            arabaBilgileri.ResetText();
            arabaBilgileri.Show();
        }

        private void aracBilgileriListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Sonuc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void enUygunTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void piyasaFiyatiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pahaliFiyatiTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
