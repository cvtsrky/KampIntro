using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{   //Tüzel Müşteri (Şirket)
    // : ile miras alma / inheritance yapıyoruz.
    class Coorporate : Costumer
    {       
        public string CompanyName { get; set; }
        public string TaxId { get; set; }
    }
}
