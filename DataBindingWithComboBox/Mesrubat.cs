using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingWithComboBox
{
    public class Mesrubat
    {
        public string Ad { get; set; }
        public int Fiyat { get; set; }

        public Mesrubat(string _ad, int _fiyat)
        {
            Ad = _ad;
            Fiyat = _fiyat;
        }
    }
}
