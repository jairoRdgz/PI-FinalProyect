using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Model
{
    class Dato
    {
        private string departamento;
        private string municipio;
        private string arma;
        private string genero;
        private string edad;
        private string cantidad;

        public Dato(string depa, string muni, string arm, string gene, string eda, string canti)
        {
            this.departamento = depa;
            this.municipio = muni;
            this.arma = arm;
            this.genero = gene;
            this.edad = eda;
            this.cantidad = canti;
        }

        public string getDepartamento()
        {
            return departamento;
        }

        public string getMunicipio()
        {
            return municipio;
        }

        public string getArma()
        {
            return arma;
        }

        public string getGenero()
        {
            return genero;
        }

        public string getEdad()
        {
            return edad;
        }

        public string getCantidad()
        {
            return cantidad;
        }
    }
}
