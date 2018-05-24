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
        public Form2()
        {
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
            Personel eklenecek = new Personel(tbad.Text,tbsoyad.Text, dtpDoğumTarihi.Value, tbmeslek.Text,CinsiyetKontrol(),
                                              MedeniDurumKontrol(),(int)nudMaas.Value);
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
    }
}
