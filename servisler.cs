using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje
{
    class servisler
    {
        public class kayıtlar
        {
            private int _id;
            public int ID
            {
                get { return _id;}
                set{_id =value;}
            }
            private string _tarih;
            public string TARİH
            {
                get { return _tarih; }
                set { _tarih = value; }
            }
            private string _adsoyad;
            public string ADSOYAD
            {
                get{return _adsoyad;}
                set{_adsoyad=value;}
            }
            private string _kurum;
            public string KURUM
            {
                get { return _kurum; }
                set { _kurum = value; }
            }
            private string _telefon;
            public string TELEFON
            {
                get { return _telefon; }
                set { _telefon = value; }
            }
            private string _sikayet;
            public string SİKAYET
            {
                get { return _sikayet; }
                set { _sikayet = value; }
            }
            private string _ilgilibirim;
            public string İLGİLİBİRİM
            {
                get { return _ilgilibirim; }
                set{_ilgilibirim=value;}

            }
            private string _açıklama;
            public string AÇIKLAMA
            {
                get { return _açıklama; }
                set { _açıklama = value; }

            }

            private string _ilce;
            public string İLÇE
            {
                get { return _ilce; }
                set { _ilce = value; }

            }
            private string _mahalle;
            public string MAHALLE
            {
                get { return _mahalle; }
                set { _mahalle = value; }
            }
            private string _cadde;
            public string CADDE
            {
                get { return _cadde; }
                set { _cadde = value; }
            }
            private string _apartman;
            public string APARTMAN
            {
                get { return _apartman; }
                set { _apartman = value; }
            }
            private string _dışkapı;
            public string DIŞKAPI
            {
                get { return _dışkapı; }
                set { _dışkapı = value; }
            }
            private string _içkapı;
            public string İÇKAPI
            {
                get { return _içkapı; }
                set { _içkapı = value; }
            }
            private string _inceleme;
            public string İNCELEME
            {
                get { return _inceleme; }
                set { _inceleme = value; }
            }
            private string _sonuc;
            public string SONUC
            {
                get { return _sonuc; }
                set { _sonuc = value; }
            }
        }
    }
}
