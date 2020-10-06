using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Integrador.Model;

namespace Proyecto_Integrador
{
    public partial class UserInterface : Form
    {
        DatoList list = new DatoList();
        DataTable table;

        public UserInterface()
        {
            InitializeComponent();
            initializeTable();
            fillFiltros();
            
        }

        public void loadData(string a)
        {
            String[] lineas = File.ReadAllLines(a);

            for (int i = 1; i < lineas.Length; i++)
            {
                String[] valores = lineas[i].Split(';');

                list.addDato(new Dato(valores[0], valores[1], valores[3], valores[5],valores[6], valores[7]));
            }   
            fill();
            loadCharts();
        }

        public void initializeTable()
        {
            table = new DataTable();
            table.Columns.Add("DEPARTAMENTO");
            table.Columns.Add("MUNICIPIO");
            table.Columns.Add("ARMA");
            table.Columns.Add("GENERO");
            table.Columns.Add("EDAD");
            table.Columns.Add("CANTIDAD");
            tablaDatos.DataSource = table;
        }

        public void fillFiltros()
        {
            filtros.Items.Add("DEPARTAMENTO");
            filtros.Items.Add("MUNICIPIO");
            filtros.Items.Add("ARMA");
            filtros.Items.Add("GENERO");
            filtros.Items.Add("EDAD");
            filtros.Items.Add("CANTIDAD");
        }

        public void fill()
        {
            foreach (var item in list.getDatos())
            {
                DataRow row = table.NewRow();
                row[0] = item.getDepartamento();
                row[1] = item.getMunicipio();
                row[2] = item.getArma();
                row[3] = item.getGenero();
                row[4] = item.getEdad();
                row[5] = item.getCantidad();

                table.Rows.Add(row);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //
                path.Text = openFileDialog1.FileName;

                loadData(openFileDialog1.FileName);
            }
        }

        private void filtrado_TextChanged(object sender, EventArgs e)
        {
            table.DefaultView.RowFilter = $"'{filtros.Text}' LIKE '{filtrado.Text}'";
        }

        private void loadCharts()
        {
            for (int i = 0; i < 3; i++)
            {
                edades.Series["Edades"].Points.AddXY(list.getEdades().ElementAt(i), list.getEdadesValues()[i]);
            }
            
        }
    }
}
