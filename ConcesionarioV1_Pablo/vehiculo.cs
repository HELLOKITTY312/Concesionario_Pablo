using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionarioV1_Pablo
{
    public class vehiculo
    {
        //CONSTANTES


        //MIEMBROS PRIVADOS
        private string _marca;
        private string _modelo;
        //CONSTRUCTORES
        public vehiculo(string marca, string modelo)
        {
            Marca= marca;
            Modelo= modelo;
        }
        //Propiedades
        public string Marca
        {
            get { return _marca; }
            //TODO: Proporcionar seguridad y proteccion al miembro - _marca
            set { _marca = value; }
        }
        public string Modelo
        {
            get { return _modelo; }
            //TODO: Proporcionar seguridad y proteccion al miembro - _modelo
            set { _modelo = value; }
        }
        //MÉTODOS PÚBLICOS


        //MÉTODOS PRIVADOS
    }
}
