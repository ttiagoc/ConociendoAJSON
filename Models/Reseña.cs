using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConociendoAJSON.Models
{
    public class Reseña
    {

        private string _nombreUsuario, _descripcion;
        private int _valoracion, _cantidadLikes;

        public Reseña(){
            _nombreUsuario = "";
            _valoracion = 0;
            _descripcion = "";
            _cantidadLikes = 0;
        }
        public Reseña(string pnombreusuario, int pvaloracion, string pdescripcion, int pcantidadLikes){
            _nombreUsuario = pnombreusuario;
            _valoracion = pvaloracion;
            _descripcion = pdescripcion;
            _cantidadLikes = pcantidadLikes;
        }

        public string NombreUsuario{
            get{return _nombreUsuario;}            
        }
        public int Valoracion{
            get{return _valoracion;}            
        }
        public string Descripcion{
            get{return _descripcion;}            
        }
        public int CantidadLikes{
            get{return _cantidadLikes;}            
        }

        
    }
}