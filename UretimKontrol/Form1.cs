using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UretimKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            UrunlerDAL urunler = new UrunlerDAL();

            urunGrid.DataSource = urunler.GetUrunler();

            UretimDAL uretim = new UretimDAL();

            uretimGrid.DataSource = uretim.GetUretim();

            personelGrid.DataSource = uretim.GetPersonel();

            makineGrid.DataSource = uretim.GetMakine();
        }

        private void urunEkleBtn_Click(object sender, EventArgs e)
        {
            UrunlerDAL urunler = new UrunlerDAL();

            string UrunAdi = urunAdiTxt.Text;
            string Kategori = urunKategoriTxt.Text;
            urunler.UrunEkle(UrunAdi,Kategori);
            MessageBox.Show("Urun Eklendi!");
            urunGrid.DataSource = urunler.GetUrunler();

        }

        private void uretimEkleBtn_Click(object sender, EventArgs e)
        {
            UretimDAL uretimDAL = new UretimDAL();

            int urunId = int.Parse(uretimUrunId.Text);

            int personelId = int.Parse(uretimPersonelId.Text);

            int makineId = int.Parse(uretimMakineId.Text);

            DateTime uretimDate = urunTarihDate.Value;

            int urunSayi = int.Parse(uretimSayisi.Text);

            uretimDAL.UretimEkle(urunId, personelId, makineId, uretimDate, urunSayi);

            UretimDAL uretim = new UretimDAL();

            uretimGrid.DataSource = uretim.GetUretim();

        }

        private void personelEkle_Click(object sender, EventArgs e)
        {
           

            UretimDAL uretim = new UretimDAL();

            string adi = personelAdi.Text;
            string soyadi = personelSoyadi.Text;

            uretim.PersonelEkle(adi,soyadi);
   

            personelGrid.DataSource = uretim.GetPersonel();

            MessageBox.Show("Personel Eklendi !");

        }

        private void makineEkle_Click(object sender, EventArgs e)
        {


            UretimDAL uretim = new UretimDAL();

            string marka = makineMarka.Text;
            string adi = makineAdi.Text;

            uretim.MakineEkle(marka, adi);

            makineGrid.DataSource = uretim.GetMakine();

            MessageBox.Show("Makine Eklendi!");
        }
    }
}
