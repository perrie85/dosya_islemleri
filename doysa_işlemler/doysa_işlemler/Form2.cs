using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doysa_işlemler
{
    public partial class Form2 : Form
    {
        public Personel personel1;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Personel personel)
        {
            personel1= personel;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime setDate = new DateTime(1997,1,1);
            tbad.Clear();
            tbsoyad.Clear();
            tbmeslek.Clear();
            tbEvTel.Clear();
            tbCepTel.Clear();
            tbİşTel.Clear();
            tbCep2Tel.Clear();
            rbKadın.Checked = true;
            rbEvli.Checked = true;
            nudMaas.Value = 3000;
            dtpDoğumTarihi.Value = setDate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ajanda telefonlar = new Ajanda();

            if (tbCep2Tel.Text=="")
            {
                tbCep2Tel.Text = "yok";
            }
            if (tbİşTel.Text=="")
            {
                tbİşTel.Text = "yok";
            }
            if (tbCepTel.Text=="")
            {
                tbCepTel.Text = "yok";
            }
            if (tbEvTel.Text == "")
            {
                tbEvTel.Text = "yok";
            }

            telefonlar.TelCep1 = tbCepTel.Text;
            telefonlar.TelEv = tbEvTel.Text;
            telefonlar.TelCep2 = tbCep2Tel.Text;
            telefonlar.TelIş = tbİşTel.Text;
            Personel eklenecek = new Personel(tbad.Text,tbsoyad.Text, dtpDoğumTarihi.Value, tbmeslek.Text,CinsiyetKontrol(),
                                              MedeniDurumKontrol(),(int)nudMaas.Value,telefonlar);
            Personel.DosyayaYaz(eklenecek);
        }

        private string CinsiyetKontrol()
        {
            if (rbErkek.Checked==true)
            {
                return rbErkek.Text;
            }
            else
            {
                return rbKadın.Text;
            }
        }

        private string MedeniDurumKontrol()
        {
            if (rbEvli.Checked == true)
            {
                return rbEvli.Text;
            }
            else
            {
                return rbBekar.Text;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (personel1 != null)
            {
                if (personel1.cinsiyet == "Erkek")
                {
                    rbErkek.Checked=true;
                }
                else
                {
                    rbKadın.Checked=true;
                }
                if (personel1.medeniDurum == "Evli")
                {
                    rbEvli.Checked = true;
                }
                else
                {
                    rbBekar.Checked = true;
                }
                tbad.Text = personel1.ad;
                tbsoyad.Text = personel1.soyad;
                tbmeslek.Text = personel1.meslek;
                nudMaas.Value = personel1.maas;
                dtpDoğumTarihi.Value = personel1.doğumTarihi;
                tbCep2Tel.Text = personel1.telefonlar.TelCep2;
                tbCepTel.Text = personel1.telefonlar.TelCep1;
                tbEvTel.Text = personel1.telefonlar.TelEv;
                tbİşTel.Text = personel1.telefonlar.TelIş;
            }
        }
    }
}
