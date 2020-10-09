using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Model
{
    class DatoList
    {
        private List<Dato> datos;

        public DatoList()
        {
            datos = new List<Dato>();
        }

        public void addDato(Dato a)
        {
            datos.Add(a);
        }

        public List<Dato> getDatos()
        {
            return datos;
        }

        public void setDatos(List<Dato> a)
        {
            this.datos = a;
        }      
    }
}
