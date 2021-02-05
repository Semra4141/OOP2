using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //coorporate = TuzelMusteri
    class TuzelMusteri :Musteri  //inheritance, miras alma.  Tüzel müşteri bir müşteridir demek istiyoruz.
    {

        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
