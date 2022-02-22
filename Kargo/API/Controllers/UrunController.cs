using Class1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class UrunController :ApiController
    {
        UrunIslemleri ui = new UrunIslemleri();
        [HttpGet]
        public List<UrunTip> TumUrunleriGetir()
        {
           
            return ui.TumUrunleriGetir();
        }

        [HttpGet]
        public UrunTip UrunGetirIDyeGore(int UrunID)
        { 
            return ui.UrunGetirIDyeGore(UrunID);
        }

        [HttpGet]
        public List<UrunTip> UrunSilId(int id)
        {
        return ui.UrunSilID(id);    
        }

    }
}