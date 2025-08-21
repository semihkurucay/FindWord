using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeBulma
{
    internal class KeywordList
    {
        private string[] keywords = { "AİLE", "KOYUN", "HAYVAN", "KİTAP", "MÜHENDİS", "OKUL", "HAYAT", "KÖPEK", "TELEFON", "BİLGİSAYAR", "HASTANE", "TAROT", "KORONA","KORNA","MASA","MÜZİK","EDEBİYAT","DİZİ","KEDİ","DİL","YEMEK","DERS","TUVALET","BÜYÜ","BÜRÜK","İNSAN","SAAT","İNTERNET","ÖĞRETMEN","EBEVEYN","ANNE","BABA","PEDER","HOCA", "ARABA", "OTOBÜS", "UÇAK", "TREN", "BİSİKLET", "TAKSİ", "GEMİ", "MOTOR", "TRAFİK", "YOL", "EV", "APARTMAN", "ODA", "MUTFAK", "BALKON", "KAPI", "PENCERE", "ÇATI", "BANYO", "DOLAP", "MARKET", "MAĞAZA", "PAZAR", "FIRIN", "KASAP", "MANAV", "RESTORAN", "KAFE", "OTEL", "SİNEMA", "ÇOCUK", "ARKADAŞ", "KOMŞU", "DOKTOR", "HEMŞİRE", "POLİS", "ŞOFÖR", "MÜDÜR", "İŞÇİ", "MEMUR", "SU", "EKMEK", "SÜT", "PEYNİR", "YOĞURT", "ÇORBA", "KAHVE", "ÇAY", "MEYVE", "SEBZE", "KALEM", "DEFTER", "KİTAPLIK", "TAHTA", "ÇANTA", "SIRA", "DERSLİK", "KÜTÜPHANE", "ÜNİVERSİTE", "LABORATUVAR", "GÖKYÜZÜ", "BULUT", "YAĞMUR", "KAR", "RÜZGAR", "GÜNEŞ", "AY", "YILDIZ", "DENİZ", "DAĞ", "EL", "AYAK", "GÖZ", "KULAK", "BURUN", "AĞIZ", "SAÇ", "KALP", "BEYİN", "DİŞ", "TOP", "OYUN", "OYUNCAK", "FUTBOL", "BASKETBOL", "VOLEYBOL", "TENİS", "SATRANÇ", "BİLGİSAYAR OYUNU", "KART", "PARA", "CÜZDAN", "KARTVİZİT", "KİMLİK", "PASAPORT", "BİLET", "FATURA", "TELEVİZYON", "RADYO", "GAZETE" };

        public string getKeyword(int index)
        {
            return keywords[index];
        }

        public int getKeywordCount() 
        { 
            return keywords.Length;
        }
    }
}
