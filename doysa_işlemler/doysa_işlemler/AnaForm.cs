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
    public partial class AnaForm : Form
    {
        Form1 form1;

        public AnaForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            form1.Hide();
        }


        protected override void OnClosed(EventArgs e)
        {
            form1.Close();
        }


        private void personelKayıtEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void personelAramaEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }
    }
}
