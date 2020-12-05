using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Model
{
    class DatoControl
    {
        private Dictionary<String, Dato> dataSetBank { get; set; }
        private Dictionary<String, Dato> classifiedBank { get; set; }

        //Class constructor
        public DatoControl()
        {
            this.dataSetBank = new Dictionary<string, Dato>();
            this.classifiedBank = new Dictionary<string, Dato>();
        }

        public Dictionary<String, Dato> GetPatients()
        {
            return this.dataSetBank;
        }

        public Dictionary<String, Dato> GetClassifiedPatients()
        {
            return this.classifiedBank;
        }

        private void addTestData(String[] attributes, int id)
        {
            AddDato(id+"", attributes[0], attributes[1], attributes[2], attributes[3], attributes[4], attributes[5], attributes[6], attributes[7], attributes[8]);
        }

        private void AddDato(String[] attributes, int id)
        {
            Dato p = new Dato(attributes[0], attributes[1], attributes[2], attributes[3], attributes[4], attributes[5], attributes[6], attributes[7], attributes[8]);

            dataSetBank.Add(id + "", p);
        }

        public void AddDato(string id, string age, string job, string marital, string education, string debt, string balance, string housing, string loan, string y)
        {
            Dato p = new Dato(age, job, marital, education, debt, balance, housing ,loan, y);

            this.classifiedBank.Add(id, p);
        }

        public DataTable LoadCSV()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            string dir = "../../data/Dataset.csv";
            if (File.Exists(dir))
            {

                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(dir);
                string[] columns = lines[0].Split(',');

                //This for adds the columns on the data table and adds all the categories that can be filtered on the combo box


                for (int i = 0; i < columns.Length; i++)
                {
                    dt.Columns.Add(columns[i]);
                }

                //This for adds the rows to the data table
                for (int i = 1; i < lines.Length; i++)
                {
                    //split the line by ","
                    string[] aux = lines[i].Split(';');
                    AddDato(aux, i);
                    dt.Rows.Add(aux);
                }
            }

            return dt;
        }

        public DataTable LoadCSVTest()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            string dir = "../../data/Dataset.csv";
            if (File.Exists(dir))
            {
                Console.WriteLine("Biem");
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(dir);
                string[] columns = lines[0].Split(',');

                //This for adds the columns on the data table and adds all the categories that can be filtered on the combo box
                for (int i = 0; i < columns.Length; i++)
                {
                    dt.Columns.Add(columns[i]);
                }

                //This for adds the rows to the data table
                for (int i = 1; i < lines.Length; i++)
                {
                    //split the line by ","
                    string[] aux = lines[i].Split(',');
                    addTestData(aux, i);
                    dt.Rows.Add(aux);
                }
            }
            else
            {
                Console.WriteLine("AAAAAh");
            }

            return dt;
        }
    }
}
