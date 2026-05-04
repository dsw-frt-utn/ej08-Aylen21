using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_5
{
    internal class WholesaleSale : Sale
    {
        public WholesaleSale(decimal importe) : base(importe)
        {
        }
        public override decimal CalculateTotal()
        {

            decimal descuento = _importe * 0.1m;



            return _importe-descuento;

        }

    }
}
