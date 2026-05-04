using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_5
{
    internal class Sale
    {


        public decimal _importe;




        public Sale(decimal importe)
        {
            _importe = importe;
        }



        public virtual decimal CalculateTotal() {
        return _importe;
        
        } 
    }


}

