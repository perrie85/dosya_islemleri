using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace doysa_işlemler
{


    public class Personel
    {
        //değişkenler
        public string ad;
        public string soyad;
        public string meslek;
        public string cinsiyet;
        public string medeniDurum;
        public DateTime doğumTarihi;
        public int maas;
        public Ajanda telefonlar;
        //enumlar
        enum MedeniDurum { Evli, Bekar }
        enum Cinsiyet { Kadın, Erkek }
        //constructor ad soyadlı
        public Personel(string ad, string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
        }
        
        public Personel(string ad, string soyad,
                        DateTime doğumTarihi, string meslek, string cinsiyet, 
                        string medeniDurum, int maas,Ajanda telefonlar) : this(ad,soyad)
        {
            this.meslek = meslek;
            this.cinsiyet = cinsiyet;
            this.medeniDurum = medeniDurum;
            this.doğumTarihi = doğumTarihi;
            this.maas = maas;
            this.telefonlar = telefonlar;
        }

        //yas icin datetime getteri
        public int Yas
        {
            get { return DateTime.Now.Year - doğumTarihi.Year; }
        }
        //ilerideki fonksiyonları vb daha öncesinde constructor ile yazmış olduğumdan ötürü
        //bu propertyleri hiç kullanmadım, constructorlar işimi tamamen gördü
        public string Meslek { get => meslek; set => meslek = value; }
        public string Cinsiyet1 { get => cinsiyet; set => cinsiyet = value; }
        public string MedeniDurum1 { get => medeniDurum; set => medeniDurum = value; }
        public DateTime DoğumTarihi { get => doğumTarihi; set => doğumTarihi = value; }
        public int Maas { get => maas; set => maas = value; }

        //zamyap fonksiyonu
        public void ZamYap(int oran)
        {
            maas += maas * (oran / 100);
        }
        //kalan gün sayısı fonksiyonu
        public int KalanGünSayısı()
        {
            return (57 * 365) - (DateTime.Now.Day - doğumTarihi.Day);
        }
        
        //dosyadan okuma fonksiyonu
        public static List<Personel> DosyadanOku()
        {
            List<Personel> kayıt = new List<Personel>();
            FileStream fs = new FileStream(@"C:\Users\user\Desktop\c# ödev/Personel.txt", FileMode.Open, FileAccess.Read);
            StreamReader oku = new StreamReader(fs);
            string satır = oku.ReadLine();
            
            while (true)
            {
                satır = oku.ReadLine();
                if (satır==null)//satır boş olduğu zaman değişkenler fonksiyonunda out of bounds uyarısı verdiğinden ötürü bu 
                {               //kontrolü kullandım
                    break;
                }
                string[] degiskenler = satır.Split(',');
                DateTime date = new DateTime(Convert.ToInt32(degiskenler[2]), Convert.ToInt32(degiskenler[3]), Convert.ToInt32(degiskenler[4]));
                Ajanda telefonlar = new Ajanda();
                telefonlar.TelEv = degiskenler[9];
                telefonlar.TelCep1 = degiskenler[10];
                telefonlar.TelIş = degiskenler[11];
                telefonlar.TelCep2 = degiskenler[12];
                Personel kayıtE = new Personel(degiskenler[0], degiskenler[1], date,
                                               degiskenler[5], degiskenler[6], degiskenler[7],
                                               Convert.ToInt32(degiskenler[8]),telefonlar);

                
                kayıt.Add(kayıtE);

            }
            oku.Close();
            fs.Close();
            return kayıt;
        }
        // dosyaya yazma fonksiyonu
        public static void DosyayaYaz(Personel personel)
        {
            string dosya_yolu = @"C:\Users\user\Desktop\c# ödev/Personel.txt";

            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);

            StreamWriter yazıcı = new StreamWriter(fs);

            yazıcı.WriteLine(personel.ad + "," + personel.soyad + "," + personel.doğumTarihi.Year+","+ personel.doğumTarihi.Month + "," +personel.doğumTarihi.Day+ ","+ personel.meslek + ","
                             + personel.cinsiyet + "," + personel.medeniDurum + "," + personel.maas+","
                             +personel.telefonlar.TelEv+","+personel.telefonlar.TelCep1+","+personel.telefonlar.TelIş+","+personel.telefonlar.TelCep2);

            yazıcı.Flush();
            yazıcı.Close();
            fs.Close();
        }
    }
}
