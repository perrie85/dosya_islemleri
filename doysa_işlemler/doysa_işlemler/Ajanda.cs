using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doysa_işlemler
{
    public class Ajanda
    {
        private string telEv;
        private string telCep1;
        private string telIş;
        private string telCep2;
        // burada ise property kullanarak sınıfı kullandım
        // bu sınıfla alakalı tüm fonksiyonlarda da get set fonksiyonlarını göreceksiniz
        public string TelEv
        {
            set { telEv = value; }
            get { return telEv; }
        }

        public string TelCep1
        {
            set { telCep1 = value; }
            get { return telCep1; }
        }

        public string TelIş
        {
            set { telIş = value; }
            get { return telIş; }
        }

        public string TelCep2
        {
            set { telCep2 = value; }
            get { return telCep2; }
        }
    }
}
