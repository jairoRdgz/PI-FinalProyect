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

        public void loadData()
        {
            //path of the dataset
            //it is inside the projects folder
            string a = "../../Dataset.csv";
            String[] lineas = File.ReadAllLines(a);

            for (int i = 1; i < lineas.Length; i++)
            {
                String[] valores = lineas[i].Split(';');

                list.addDato(new Dato(Int32.Parse(valores[0]), valores[1], valores[2], valores[3],valores[4], Int32.Parse(valores[5]), valores[6], valores[7], valores[16]));
            }   
            fill();
            loadCharts();
        }

        public void initializeTable()
        {
            table = new DataTable();
            table.Columns.Add("AGE");
            table.Columns.Add("JOB");
            table.Columns.Add("MARITAL");
            table.Columns.Add("EDUCATION");
            table.Columns.Add("DEBT");
            table.Columns.Add("BALANCE");
            table.Columns.Add("HOUSING");
            table.Columns.Add("LOAN");
            table.Columns.Add("DEPOSIT");
            tablaDatos.DataSource = table;
        }

        public void fillFiltros()
        {
            filtros.Items.Add("AGE");
            filtros.Items.Add("JOB");
            filtros.Items.Add("MARITAL");
            filtros.Items.Add("EDUCATION");
            filtros.Items.Add("DEBT");
            filtros.Items.Add("BALANCE");
            filtros.Items.Add("HOUSING");
            filtros.Items.Add("LOAN");
            filtros.Items.Add("DEPOSIT");
        }

        public void fill()
        {
            foreach (var item in list.getDatos())
            {
                DataRow row = table.NewRow();
                row[0] = item.Age;
                row[1] = item.Job;
                row[2] = item.Marital;
                row[3] = item.Education;
                row[4] = item.Debt;
                row[5] = item.Balance;
                row[6] = item.Housing;
                row[7] = item.Loan;
                row[8] = item.Y;

                table.Rows.Add(row);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();
           
        }

        private void filtrado_TextChanged(object sender, EventArgs e)
        {
            if (filtros.Text.Equals(""))
            {
                table.DefaultView.RowFilter = $"*";
            }
            else
            {
                string fUno = filtros.Text;
                string fDos = filtrado.Text;
                table.DefaultView.RowFilter = $"'{fUno}' LIKE '{fDos}'";
            }
            
        }

        private void loadCharts()
        {
                        
        }
    }
}
