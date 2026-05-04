using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema_3
{
    internal class Product

    {

        private string _description;

        public Product(string description) { 
        
            _description = description;
        
        }

        public String GetDescription()
        {

            return _description;

        }
        public void SetDescription(String description)
        {
            _description = description;

        }
        public void CambiarDescripcion(string nuevaDescripcion)
        {
            _description = nuevaDescripcion;
        }


    }
}
