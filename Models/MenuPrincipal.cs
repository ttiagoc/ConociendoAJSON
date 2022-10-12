using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConociendoAJSON.Models
{
    public class MenuPrincipal
    {
        private string _nombrePlato;
        private int _precioUnitario;

        public MenuPrincipal(){
            _nombrePlato = "";
            _precioUnitario = 0;
        }

        public MenuPrincipal(string pnombrePlato, int pprecioUnitario){
            _nombrePlato = pnombrePlato;
            _precioUnitario = pprecioUnitario;
        }

        public string NombrePlato{
            get{return _nombrePlato;}
        }
        public int PrecioUnitario{
            get{return _precioUnitario;}
        }
        
    }
}