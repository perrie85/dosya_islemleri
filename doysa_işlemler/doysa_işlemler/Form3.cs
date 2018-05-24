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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            List<Personel> personels = Personel.DosyadanOku();

            for (int i = 0; i < personels.Count; i++)
            {
                if (personels[i].ad==ad)
                {
                    Personel personel = personels[i];
                    MessageBox.Show(personels[i].ad + "," + personels[i].soyad + "," + personels[i].doğumTarihi.Year + ","
                                    +personels[i].doğumTarihi.Month + "," + personels[i].doğumTarihi.Day 
                                    + "," + personels[i].meslek + ","+ personels[i].cinsiyet + "," + personels[i].medeniDurum + "," + personels[i].maas);
                    Form2 form2 = new Form2(personel);
                    form2.MdiParent = MdiParent;
                    form2.Show();
                    this.Hide();
                    break;
                }
                
            }
        }
    }
}
