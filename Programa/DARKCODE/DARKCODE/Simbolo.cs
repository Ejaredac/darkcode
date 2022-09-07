using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DARKCODE
{
    class Simbolo : IEquatable<string>
    {
        public Simbolo(string nom, int id)
        {
            this.Nombre = nom;
            this.ID = id;
        }
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        public bool Equals(string other)
        {
            return other.Equals(Nombre);
        }

        public override string ToString()
        {
            return Nombre;
        }
        private string _strValor;

        public string Valor
        {
            get { return _strValor; }
            set { _strValor = value; }
        }
        private string _strTipo;

        public string Tipo
        {
            get { return _strTipo; }
            set { _strTipo = value; }
        }


    }
}
