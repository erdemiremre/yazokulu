using System;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private string ad;
        private string soyad;
        private int id;
        private string numara;
        private string fotograf;
        private double bakiye;
        private string sifre;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Numara
        {
            get { return numara; }
            set { numara = value; }
        }
        public string Fotograf
        {
            get { return fotograf; }
            set { fotograf = value; }
        }
        public double Bakiye
        {
            get { return bakiye; }
            set { bakiye = value; }
        }
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
    }
}
