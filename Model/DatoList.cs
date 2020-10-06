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
        private List<string> edades = new List<string>();

        public DatoList()
        {
            datos = new List<Dato>();
            edades.Add("ADULTOS");
            edades.Add("ADOLESCENTES");
            edades.Add("MENORES");
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

        public List<string> getEdades()
        {
            return edades;
        }

        public int[] getEdadesValues()
        {
            int[] result = new int[3];

            foreach (var item in datos)
            {
                if (edades.Contains(item.getEdad())){
                    if (item.getEdad().Equals("ADULTOS")){
                        result[0] += 1;
                    }else if (item.getEdad().Equals("ADOLESCENTES")){
                        result[1] += 1;
                    }else if (item.getEdad().Equals("MENORES")){
                        result[2] += 1;
                    }
                }
            }

            return result;
        }

    }
}
