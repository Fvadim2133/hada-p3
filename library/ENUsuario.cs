using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENUsuario
    {

        private string _nif;
        private string _nombre;
        private int _edad;

        public string nif
        {
            get { return _nif; }
            set { _nif = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public ENUsuario(){ nif = "";nombre = ""; edad = 0;}

        public ENUsuario(string nif, string nombre , int edad){ this.nif = nif; this.nombre = nombre; this.edad = edad;}

        public bool readUsuario()
        {
            return true;   
        }

        public bool readFirstUsuario()
        {
            return true;
        }

        public bool readPrevUsuario()
        {
            return true;
        }

        public bool readNextUsuario()
        {
            return true;
        }

        public bool createUsuario()
        {
            return true;
        }

        public bool updateUsuario()
        {
            return true;
        }

        public bool deleteUsuario()
        {
            return true;
        }

    }
}
