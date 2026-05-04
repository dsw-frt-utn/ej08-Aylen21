using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Dsw2026Ej8.Problema_2
{
    internal class Problema2
    {


        public string CrearResumenVenta(long productCode,string productDescription,int quantity, decimal unitPrice) {

              decimal total;

            if (quantity <= 0)
            {

                total = 0;

            }
            else {

                  total = quantity * unitPrice;
            }
            var claseAnonima = new { Code = productCode , Description = productDescription, Quantity = quantity, Total = total};

            return $"{claseAnonima.Code} - {claseAnonima.Description} - {FormatearMoneda(claseAnonima.Total)} ";
        
        
        
        }


        public string FormatearMoneda(decimal price)
        {
            return price.ToString("C");
        }
    }
}
