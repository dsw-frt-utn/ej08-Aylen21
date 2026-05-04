using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Text;

namespace Dsw2026Ej8.Problema_3
{
    internal class Problema3
    {


        public string CompararCopias(int originalValue, Product product) {

            int copyValue = originalValue;
            copyValue++;
            
            
            Product copyProduct = product;

            copyProduct.CambiarDescripcion("Teclado Mecanico");

            return $"{originalValue} - {copyValue} - {copyProduct.GetDescription()}";
        
        }


    }
}
