using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    public class UrunIslemleri
    {
        KargoEntities _ent = new KargoEntities();

        public List<UrunTip> TumUrunleriGetir()
        {
           return _ent.Urun.Select(p=>new UrunTip() { 
                Desi = p.Desi,  
                GeldigiYer = p.GeldigiYer,
                GidecegiYer = p.GidecegiYer,
                KaydedenPersonelID = p.KaydedenPersonelID,
                TeslimatAdresi = p.TeslimatAdresi,
                Ucret = p.Ucret,
                UrunID = p.UrunID
            }).ToList();
        }

        public UrunTip UrunGetirIDyeGore( int UrunID)
        {
            return _ent.Urun.Where(p=>p.UrunID == UrunID).Select(p => new UrunTip()
            {
                Desi = p.Desi,
                GeldigiYer = p.GeldigiYer,
                GidecegiYer = p.GidecegiYer,
                KaydedenPersonelID = p.KaydedenPersonelID,
                TeslimatAdresi = p.TeslimatAdresi,
                Ucret = p.Ucret,
                UrunID = p.UrunID
            }).FirstOrDefault();
        }

        public List<UrunTip> UrunSilID(int id)
        {
            Urun silinecek = _ent.Urun.Find(id);
            _ent.Urun.Remove(silinecek);
            _ent.SaveChanges();
            return TumUrunleriGetir();
        }
    }
    public class UrunTip
    {
        public int UrunID { get; set; }
        public string GeldigiYer { get; set; }
        public string GidecegiYer { get; set; }
        public string TeslimatAdresi { get; set; }
        public Nullable<double> Ucret { get; set; }
        public Nullable<double> Desi { get; set; }
        public Nullable<int> KaydedenPersonelID { get; set; }
    }
}
