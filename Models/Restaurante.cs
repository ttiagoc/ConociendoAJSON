using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConociendoAJSON.Models
{
    public class Restaurante
    {
        
        private int _idRestaurante, _añoApertura;
        private string _nombre, _logo, _ubicacion;
        private List<Reseña> _reseñas;
        private List<string> _dueño;
        private MenuPrincipal _menuPrincipal;

        public Restaurante(){

            _idRestaurante = 0;
            _nombre = "";
            _añoApertura = 0;
            _ubicacion = "";
            _dueño = null;
            _logo = "";
            _reseñas = null;
            _menuPrincipal = null;

        }

        public Restaurante(int pidRestaurante, string pnombre, int pañoApertura, string pubicacion, List<string> pdueño, string plogo, List<Reseña> preseñas, MenuPrincipal pmenuPrincipal){

            _idRestaurante = pidRestaurante;
            _nombre = pnombre;
            _añoApertura = pañoApertura;
            _ubicacion = pubicacion;
            _dueño = pdueño;
            _logo = plogo;
            _reseñas = preseñas;
            _menuPrincipal = pmenuPrincipal;

        }

        public int IdRestaurante{
            get{return _idRestaurante;}            
        }
        
        public int Año_Apertura{
            get{return _añoApertura;}
            
        }

        public string Nombre{
            get{return _nombre;}
            
        }

        public string Ubicacion{
            get{return _ubicacion;}
            
        }

        public List<string> Dueño{
            get{return _dueño;}
        }

        public string Logo{
            get{return _logo;}
        }

        public List<Reseña> Reseñas{
            get{return _reseñas;}
        }

        public MenuPrincipal MenuPrincipal{
            get{return _menuPrincipal;}
        }      



    }
}