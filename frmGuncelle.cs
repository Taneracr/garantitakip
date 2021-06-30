using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garantiTakip
{
    public partial class frmGuncelle : Form
    {
        public frmGuncelle()
        {
            InitializeComponent();
        }

        stajyerEntities3 db = new stajyerEntities3();

        private void button4_Click(object sender, EventArgs e)
        {

        }



        private void frmGuncelle_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_cari.Select(x => new
            {
                x.IND,
                x.FIRMAKODU,
                x.FIRMAADI,
                x.YETKILI,
                x.VERGIDAIRESI,
                x.VERGINO,
                x.KAYITTARIHI,
                x.ISKONTO,
                x.tbl_firmaTipi.FIRMATİPİ,
                x.tbl_Yetkili.AD,
                x.tbl_Yetkili.SOYAD,
                x.UNVAN,
                x.tbl_sektor.SEKTORADI,
                x.MARKA,
                x.EMAIL,
                x.URL,
                x.TELEFON1,
                x.TELEFON2,
                x.ADRESFATURA,
                x.ADRESSEVK,
                x.PARABIRIMI,
                x.IL,
                x.SEHIR,
                x.PERSONELNO,
                x.tbl_status.STATUS,
                x.tbl_Yetkili.DGMTARİH,
                x.tbl_hizmetturu.HIZMETTURU,
                x.tbl_baslangicBitisTarih.BASLANGICTARİH,
                x.tbl_baslangicBitisTarih.BİTİSTARİH,
                x.tbl_Yetkili.MAIL,
                x.tbl_Yetkili.TELEFON,



            }).ToList();

            foreach (var item in db.tbl_sektor)
            {
                comboSektor.Items.Add(item.SEKTORADI);
            }

            foreach (var firma in db.tbl_firmaTipi)
            {
                comboFirmatipi.Items.Add(firma.FIRMATİPİ);
            }

            foreach (var hizmet in db.tbl_hizmetturu)
            {
                comboHizmetturu.Items.Add(hizmet.HIZMETTURU);
            }


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtFirmaKod.Text = (dataGridView1.CurrentRow.Cells[1].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[1].Value.ToString());
            txtFirmaAd.Text = (dataGridView1.CurrentRow.Cells[2].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[2].Value.ToString());
            txtYetkili.Text = (dataGridView1.CurrentRow.Cells[3].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[3].Value.ToString());
            comboFirmatipi.Text = (dataGridView1.CurrentRow.Cells[8].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[8].Value.ToString());
            comboSektor.Text = (dataGridView1.CurrentRow.Cells[12].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[12].Value.ToString());
            txtSehir.Text = (dataGridView1.CurrentRow.Cells[22].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[22].Value.ToString());
            txtTel.Text = (dataGridView1.CurrentRow.Cells[16].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[16].Value.ToString());
            txtTel2.Text = (dataGridView1.CurrentRow.Cells[17].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[17].Value.ToString());
            txtMail.Text = (dataGridView1.CurrentRow.Cells[14].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[14].Value.ToString());
            txtUrl.Text = (dataGridView1.CurrentRow.Cells[15].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[15].Value.ToString());
            comboHizmetturu.Text = (dataGridView1.CurrentRow.Cells[26].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[26].Value.ToString());
            txtAdresSevk.Text = (dataGridView1.CurrentRow.Cells[19].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[19].Value.ToString());
            txtAdresFatura.Text = (dataGridView1.CurrentRow.Cells[18].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[18].Value.ToString());
            txtIskonto.Text = (dataGridView1.CurrentRow.Cells[7].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[7].Value.ToString());
            txtVergiDaire.Text = (dataGridView1.CurrentRow.Cells[4].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[4].Value.ToString());
            txtVergiNo.Text = (dataGridView1.CurrentRow.Cells[5].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[5].Value.ToString());
            comboParabirimi.Text = (dataGridView1.CurrentRow.Cells[20].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[20].Value.ToString());
            txtBaslangıcTarih.Text = (dataGridView1.CurrentRow.Cells[27].Value == null) ? DateTime.Now.Date.ToString() : (dataGridView1.CurrentRow.Cells[27].Value.ToString());
            txtBitisTarih.Text = (dataGridView1.CurrentRow.Cells[28].Value == null) ? DateTime.Now.Date.ToString() : (dataGridView1.CurrentRow.Cells[28].Value.ToString());
            txtYetkiliAd.Text = (dataGridView1.CurrentRow.Cells[9].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[9].Value.ToString());
            txtYetkiliMail.Text = (dataGridView1.CurrentRow.Cells[29].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[29].Value.ToString());
            txtYetkiliTel.Text = (dataGridView1.CurrentRow.Cells[30].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[30].Value.ToString());
            txtyetkiliSoyadi.Text = (dataGridView1.CurrentRow.Cells[10].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[10].Value.ToString());
            txtYetkiliDgmTarih.Text = (dataGridView1.CurrentRow.Cells[25].Value == null) ? DateTime.Now.Date.ToString() : (dataGridView1.CurrentRow.Cells[25].Value.ToString());
            lblind.Text = (dataGridView1.CurrentRow.Cells[0].Value == null) ? "BİLİNMİYOR" : (dataGridView1.CurrentRow.Cells[0].Value.ToString());

            bool deger = ((dataGridView1.CurrentRow.Cells[24].Value == null) ? true : Convert.ToBoolean((dataGridView1.CurrentRow.Cells[24].Value.ToString())));

            if (dataGridView1.CurrentRow.Cells[24].Value != null)
            {

                if (deger)
                {
                    RbAktif.Checked = true;

                }
                else
                {
                    RbPasif.Checked = true;
                }
            }
            else
            {

                RbAktif.Checked = false;
                RbPasif.Checked = false;
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ////try
            ////{
            //    int b = int.Parse(lblind.Text);
            //    if (lblind.Text != null)
            //    {

            //        var guncelle = db.tbl_cari.Where(w => w.IND == b).FirstOrDefault();
            //        tbl_sektor sektor = db.tbl_sektor.Where(x => x.SEKTORADI == comboSektor.Text).FirstOrDefault();
            //        tbl_firmaTipi firma = db.tbl_firmaTipi.Where(x => x.FIRMATİPİ == comboFirmatipi.Text).FirstOrDefault();
            //        tbl_hizmetturu hizmet = db.tbl_hizmetturu.Where(x => x.HIZMETTURU == comboHizmetturu.Text).FirstOrDefault();
            //    tbl_status status = db.tbl_status.Where(x => x.STATUS == RbAktif.Checked).FirstOrDefault();

            //        guncelle.SEKTOR = sektor.IND;
            //        guncelle.FIRMAKODU = txtFirmaKod.Text;
            //        guncelle.FIRMAADI = txtFirmaAd.Text;
            //        guncelle.FIRMATIPI = firma.IND;
            //        guncelle.SEHIR = txtSehir.Text;
            //        guncelle.TELEFON1 = txtTel.Text;
            //        guncelle.TELEFON2 = txtTel2.Text;
            //        guncelle.EMAIL = txtMail.Text;
            //        guncelle.HIZMETTURU = hizmet.IND;
            //        guncelle.ADRESSEVK = txtAdresSevk.Text;
            //        guncelle.ADRESFATURA = txtAdresFatura.Text;
            //        guncelle.ISKONTO = decimal.Parse(txtIskonto.Text);
            //        guncelle.VERGIDAIRESI = txtVergiDaire.Text;
            //        guncelle.VERGINO = txtVergiNo.Text;
            //        guncelle.PARABIRIMI = comboParabirimi.Text;
            //        guncelle.tbl_baslangicBitisTarih.BASLANGICTARİH = Convert.ToDateTime( txtBaslangıcTarih.Text);
            //        guncelle.tbl_baslangicBitisTarih.BİTİSTARİH = DateTime.Parse(txtBitisTarih.Text);
            //        guncelle.tbl_Yetkili.AD = txtYetkiliAd.Text;
            //        guncelle.tbl_Yetkili.SOYAD = txtyetkiliSoyadi.Text;
            //        guncelle.tbl_Yetkili.TELEFON = txtYetkiliTel.Text;
            //        guncelle.tbl_Yetkili.MAIL = txtYetkiliMail.Text;
            //        guncelle.tbl_Yetkili.DGMTARİH = DateTime.Parse( txtYetkiliDgmTarih.Text);

            //        db.SaveChanges();

            //        dataGridView1.DataSource = db.tbl_cari.Select(x => new
            //        {
            //            x.IND,
            //            x.FIRMAKODU,
            //            x.FIRMAADI,
            //            x.YETKILI,
            //            x.VERGIDAIRESI,
            //            x.VERGINO,
            //            x.KAYITTARIHI,
            //            x.ISKONTO,
            //            x.tbl_firmaTipi.FIRMATİPİ,
            //            x.tbl_Yetkili.AD,
            //            x.tbl_Yetkili.SOYAD,
            //            x.UNVAN,
            //            x.tbl_sektor.SEKTORADI,
            //            x.MARKA,
            //            x.EMAIL,
            //            x.URL,
            //            x.TELEFON1,
            //            x.TELEFON2,
            //            x.ADRESFATURA,
            //            x.ADRESSEVK,
            //            x.PARABIRIMI,
            //            x.IL,
            //            x.SEHIR,
            //            x.PERSONELNO,
            //            x.tbl_status.STATUS,
            //            x.tbl_Yetkili.DGMTARİH,
            //            x.tbl_hizmetturu.HIZMETTURU,
            //            x.tbl_baslangicBitisTarih.BASLANGICTARİH,
            //            x.tbl_baslangicBitisTarih.BİTİSTARİH,
            //            x.tbl_Yetkili.MAIL,
            //            x.tbl_Yetkili.TELEFON,



            //        }).ToList();
            //    }

            //}
            ////catch
            ////{

            ////    MessageBox.Show("Kullanıcı Bulunamadı");
            ////}
        }
    }
}
