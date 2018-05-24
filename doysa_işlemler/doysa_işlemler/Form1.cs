using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace doysa_işlemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = @"C:\Users\user\Desktop\c# ödev\kadisifre.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi, sifre;

            kadi = textBox1.Text;
            sifre = textBox2.Text;
            StreamReader oku = new StreamReader(path);

            string satır = oku.ReadLine();
            string[] degiskenler = new string[3]; 
            degiskenler = satır.Split(',');

            while (satır!=null)
            {
                if (kadi == degiskenler[0] && sifre == degiskenler[1])
                {
                    AnaForm anaForm = new AnaForm(this);
                    anaForm.Show();
                    break;
                }
                else
                {
                    satır = oku.ReadLine();
                    degiskenler = satır.Split(',');
                }

                /*if ((satır = oku.ReadLine()) == null)
                {
                    MessageBox.Show("yanlış kullanıcı adı şifre");
                }*/
            }
            
        }
    }
}
