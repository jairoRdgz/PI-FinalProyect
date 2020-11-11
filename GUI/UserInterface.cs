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

        public void initializePredictions()
        {

            foreach (var item in list.JobList)
            {
                PredictionJob.Items.Add(item);
            }

            foreach (var item in list.MaritalList)
            {
                predictionMarital.Items.Add(item);
            }

            foreach (var item in list.EducationList)
            {
                PredictionEducation.Items.Add(item);
            }
        }

        public void loadData()
        {
            //path of the dataset
            //it is inside the docs folder
            string a = "../../data/Dataset.csv";
            String[] lineas = File.ReadAllLines(a);

            for (int i = 2; i < lineas.Length; i++)
            {
                String[] valores = lineas[i].Split(';');

                list.addDato(new Dato(valores[0], valores[1], valores[2], valores[3],valores[4], valores[5], valores[6], valores[7], valores[8]));
            }   
            fill();
            loadCharts();
            initializePredictions();
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

        //this method
        //fills the 
        //labels of the tables
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

        //this method filters the table
        private void filtrado_TextChanged(object sender, EventArgs e)
        {
            table.DefaultView.RowFilter = $"{filtros.Text} LIKE '{filtrado.Text}%'";
        }

        //this method loads the charts
        //that allow to visualize the data
        private void loadCharts()
        {
            debtChartInfo();
            housingChartInfo();
            maritalChartInfo();
            ageChartInfo();
            jobChartInfo();
        }

        private void ageChartInfo()
        {
            ////[20,30)
            //int group1 = 0;
            ////[30,40)
            //int group2 = 0;
            ////[40,50)
            //int group3 = 0;
            ////[50,60)
            //int group4 = 0;
            ////(+60)
            //int group5 = 0;

            //for (int i = 0; i < list.getDatos().Count; i++)
            //{
            //    int age = list.getDatos().ElementAt(i).Age;
            //    if (age > 20 && age <= 30)
            //    {
            //        group1++;
            //        Console.WriteLine(group1 + "");
            //    }
            //    else if (age > 31 && age <= 40)
            //    {
            //        group2++;
            //    }
            //    else if (age > 41 && age <= 50)
            //    {
            //        group3++;
            //    }
            //    else if (age > 51 && age <= 60)
            //    {
            //        group4++;
            //    }
            //    else if (age>60){
            //        group5++;
            //    }


            //}
            //ageChart.Series["Series1"].Points.AddXY("20 - 30 ", group1);
            //ageChart.Series["Series1"].Points.AddXY("30 - 40 ", group2);
            //ageChart.Series["Series1"].Points.AddXY("40 - 50 ", group3);
            //ageChart.Series["Series1"].Points.AddXY("50 - 60 ", group4);
            //ageChart.Series["Series1"].Points.AddXY("+60", group5);


        }

        private void debtChartInfo()
        {
            int yes = 0;
            int no = 0;
            int un = 0;
            for (int i = 0; i < list.getDatos().Count; i++)
            {
                //debtChart.Series["Series1"].Points.Add(list.getDatos().ElementAt(i).Debt);
                if (list.getDatos().ElementAt(i).Debt.Equals("yes"))
                {
                    yes++;
                }else if (list.getDatos().ElementAt(i).Debt.Equals("no"))
                {
                    no++;
                }
                else
                {
                    un++;
                }
                
            }
            debtChart.Series["Series1"].Points.AddXY("Yes", yes);
            debtChart.Series["Series1"].Points.AddXY("No", no);
            if (un != 0)
                debtChart.Series["Series1"].Points.AddXY("Unknown", un);
        }

        private void housingChartInfo()
        {
            int yes = 0;
            int no = 0;
            int un = 0;
            for (int i = 0; i < list.getDatos().Count; i++)
            {
                //debtChart.Series["Series1"].Points.Add(list.getDatos().ElementAt(i).Debt);
                if (list.getDatos().ElementAt(i).Housing.Equals("yes"))
                {
                    yes++;
                }
                else if (list.getDatos().ElementAt(i).Housing.Equals("no"))
                {
                    no++;
                }
                else
                {
                    un++;
                }

            }
            housingChart.Series["Series1"].Points.AddXY("Yes", yes);
            housingChart.Series["Series1"].Points.AddXY("No", no);
            if (un != 0)
                housingChart.Series["Series1"].Points.AddXY("Unknown", un);
        }
        private void maritalChartInfo()
        {
            int married = 0;
            int single = 0;
            int divorced = 0;
            for (int i = 0; i < list.getDatos().Count; i++)
            {
                //debtChart.Series["Series1"].Points.Add(list.getDatos().ElementAt(i).Debt);
                if (list.getDatos().ElementAt(i).Marital.Equals("married"))
                {
                    married++;
                }
                else if (list.getDatos().ElementAt(i).Marital.Equals("single"))
                {
                    single++;
                }
                else
                {
                    divorced++;
                }

            }
            maritalChart.Series["Series1"].Points.AddXY("Married", married);
            maritalChart.Series["Series1"].Points.AddXY("Single", single);
            maritalChart.Series["Series1"].Points.AddXY("Divorced", divorced);
        }
        
         private void jobChartInfo()
        {
            int admin = 0;
            int blueCollar = 0;
            int entrepreneur = 0;
            int housemaid = 0;
            int management = 0;
            int retired = 0;
            int selfEmployed = 0;
            int services = 0;
            int student = 0;
            int technician = 0;
            int unemployed = 0;
            int unknown = 0;

            int divorced = 0;
            for (int i = 0; i < list.getDatos().Count; i++)
            {
                //debtChart.Series["Series1"].Points.Add(list.getDatos().ElementAt(i).Debt);
                if (list.getDatos().ElementAt(i).Job.Equals("admin"))
                {
                    admin++;
                }
                else if (list.getDatos().ElementAt(i).Job.Equals("blue-collar"))
                {
                    blueCollar++;
                }
                else if (list.getDatos().ElementAt(i).Job.Equals("entrepreneur"))
                {
                    entrepreneur++;
                }
                else if (list.getDatos().ElementAt(i).Job.Equals("housemaid"))
                {
                    housemaid++;
                }
                else if (list.getDatos().ElementAt(i).Job.Equals("management"))
                {
                    management++;
                }
                else if (list.getDatos().ElementAt(i).Job.Equals("retired"))
                {
                    retired++;
                }
                else if (list.getDatos().ElementAt(i).Job.Equals("self-employed"))
                {
                    selfEmployed++;
                }
                else if (list.getDatos().ElementAt(i).Job.Equals("services"))
                {
                    services++;
                }
                else if (list.getDatos().ElementAt(i).Job.Equals("student"))
                {
                    student++;
                }
                else if (list.getDatos().ElementAt(i).Job.Equals("technician"))
                {
                    technician++;
                }
                else if (list.getDatos().ElementAt(i).Job.Equals("unemoloyed"))
                {
                    unemployed++;
                }
               
                else
                {
                    unknown++;
                }

              
            }
          jobChart.Series["Series1"].Points.AddXY("Admin", admin);
          jobChart.Series["Series1"].Points.AddXY("Blue-collar", blueCollar);
           jobChart.Series["Series1"].Points.AddXY("Entrepreneur", entrepreneur);
            jobChart.Series["Series1"].Points.AddXY("Housemaid", housemaid);
            jobChart.Series["Series1"].Points.AddXY("Management", blueCollar);
            jobChart.Series["Series1"].Points.AddXY("Retired", retired);
            jobChart.Series["Series1"].Points.AddXY("self-employed", selfEmployed);
            jobChart.Series["Series1"].Points.AddXY("Services", services);
            jobChart.Series["Series1"].Points.AddXY("Student", student);
            jobChart.Series["Series1"].Points.AddXY("Technician", technician);
            jobChart.Series["Series1"].Points.AddXY("Unemployed", unemployed);
            jobChart.Series["Series1"].Points.AddXY("Unknown", unknown);
        }

        public void prediction()
        {
            DatoList predictions = new DatoList();
            string name = predictionName.Text;
            string age = predictionAge.Text;
            string job = PredictionJob.Text;
            string marital = predictionMarital.Text;
            string education = PredictionEducation.Text;
            string debt = predictionDebt.Checked ? "yes" : "no";
            string balance = predictionBalance.Text;
            string housing = predictionHousing.Checked ? "yes" : "no";
            string loan = PredictionLoan.Checked ? "yes" : "no";

            Random random = new Random();
            string y = random.Next(0, 1) == 1 ? "yes" : "no";

            Dato predicted = new Dato(age, job, marital, education, debt, balance, housing, loan, y);

            if (predictions.getDatos() == null)
            {
                predictions.addDato(predicted);
                resultado.Text = $"Based on our information \n{name} will say {y} to the subscription into the bank plan";
            }
            else if (predictions.getDatos().Contains(predicted))
            {
                resultado.Text = $"Based on our information \n{name} will say {y} to the subscription into the bank plan";
            }
            else
            {
                predictions.addDato(predicted);
                resultado.Text = $"Based on our information \n{name} will say {y} to the subscription \ninto the bank plan";
            }
        }

        private void MakePrediction_Click(object sender, EventArgs e)
        {
            prediction();
        }
    }
}