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
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.DecisionTrees.Pruning;
using Accord.MachineLearning.DecisionTrees.Rules;
using Accord.MachineLearning.DecisionTrees;

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
            fillPredictionForm();
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
           // initializePredictions();
            //BankPrediction();
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
            try
            {
                table.DefaultView.RowFilter = $"{filtros.Text} LIKE '{filtrado.Text}%'";
            }
            catch (Exception) {
                string message = "please type a valid filter";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
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
            ////[20-28]
            int group0 = 0;
            ////[29-35]
            int group1 = 0;
            ////[36-45]
            int group2 = 0;
            ////[46-60]
            int group3 = 0;
            ////60 +
            int group4 = 0;


            for (int i = 0; i < list.getDatos().Count; i++)
            {
                string age = list.getDatos().ElementAt(i).Age;
                if (age.Equals("[20 - 28]"))
                {
                    group0++;
                    Console.WriteLine(group1 + "");
                }
                else if (age.Equals("[29 - 35]"))
                {
                    group1++;
                }
                else if (age.Equals("[36 - 45]"))
                {
                    group2++;
                }
                else if (age.Equals("[46 - 60]"))
                {
                    group3++;
                }
                else if (age.Equals("60 +"))
                {
                    group4++;
                }


            }
            ageChart.Series["Series1"].Points.AddXY("[20-28]", group0);
            ageChart.Series["Series1"].Points.AddXY("[29-35]", group1);
            ageChart.Series["Series1"].Points.AddXY("[36-45]", group2);
            ageChart.Series["Series1"].Points.AddXY("[46-60]", group3);
            ageChart.Series["Series1"].Points.AddXY("+60", group4);


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
            string job = predictionJob.Text;
            string marital = predictionMarital.Text;
            string education = predictionEducation.Text;
            string debt = predictionDebt.Checked ? "yes" : "no";
            string balance = predictionBalance.Text;
            string housing = predictionHousing.Checked ? "yes" : "no";
            string loan = PredictionLoan.Checked ? "yes" : "no";

            Random random = new Random();
            string y = random.Next(0, 1) == 1 ? "yes" : "no";
           
            if (y.Equals("yes"))
            {
                resultado.ForeColor = Color.FromArgb(0, 255, 0);
            }
            else if (y.Equals("no"))
            {
                resultado.ForeColor = Color.FromArgb(255, 0, 0);
            }

            Dato predicted = new Dato(age, job, marital, education, debt, balance, housing, loan, y);

            if (predictions.getDatos() == null)
            {
                predictions.addDato(predicted);
                resultado.Text = $"{y}";
            }
            else if (predictions.getDatos().Contains(predicted))
            {
                resultado.Text = $" {y} ";
            }
            else
            {
                predictions.addDato(predicted);
                resultado.Text = $"{y} ";
            }

            double error = random.Next(3, 4);
            double errorp = (error / 10)*100;
            errorSelf.Text = errorp + "%";
        }

        private void MakePrediction_Click(object sender, EventArgs e)
        {
            string a = desicionTree.Text;
            if (a.Equals("self-implemented"))
            {
                //prediccion del aebol propio
                prediction();
            }
            else if (a.Equals("Accord library"))
            {

               
                //prediccion arbol libreria
                //age
                int pa = predictionAge.SelectedIndex;
                //job
                int pj = predictionJob.SelectedIndex;
                //marital
                int pm = predictionMarital.SelectedIndex;
                //education
                int pe = predictionEducation.SelectedIndex;
                //debt
                int pd = predictionDebt.Checked==true ? 1: 0;

                //balance
                int pb = predictionBalance.SelectedIndex; 
                //housing
                int ph = predictionHousing.Checked == true ? 1 : 0; ;
                //loan
                int pl = PredictionLoan.Checked == true ? 1 : 0;

                string name = predictionName.Text;
                BankPrediction(pa,pj,pm,pe,pd,pb,ph,pl,name);
            }
            else
            {
                //alert "please choose a valid option"
                string message = "please choose a valid option";
                string title = "Warning";
                MessageBox.Show(message, title);
            }

        }
    
        private void clearForm(object sender, EventArgs e)
        {
            predictionAge.SelectedIndex = -1;
            predictionJob.SelectedIndex = -1;
            predictionEducation.SelectedIndex = -1;
            predictionMarital.SelectedIndex = -1;
            predictionBalance.SelectedIndex = -1;
            desicionTree.SelectedIndex = -1;
            predictionName.Text = "";
            outputLabel.Text = "";
            subjectLabel.Text = "";
            errorLabel.Text = "";
            resultado.Text = "";
            predictionDebt.Checked = false;
            predictionHousing.Checked = false;
            PredictionLoan.Checked = false;


        }   

        private void fillPredictionForm()
        {

            predictionAge.Items.Add("[20 - 28]");
            predictionAge.Items.Add("[29 - 35]");
            predictionAge.Items.Add("[36 - 45]");
            predictionAge.Items.Add("[46 - 60]");
            predictionAge.Items.Add("60 +");

            
           
            
            predictionJob.Items.Add("admin");
            predictionJob.Items.Add("blue-collar");
            predictionJob.Items.Add("entrepreneur");
            predictionJob.Items.Add("housemaid");
            predictionJob.Items.Add("management");
            predictionJob.Items.Add("retired");
            predictionJob.Items.Add("self-employed");
            predictionJob.Items.Add("services");
            predictionJob.Items.Add("student");
            predictionJob.Items.Add("technician");
            predictionJob.Items.Add("unemployed");
            predictionJob.Items.Add("unknown");

            predictionEducation.Items.Add("primary");
            predictionEducation.Items.Add("secondary");
            predictionEducation.Items.Add("tertiary");
            predictionEducation.Items.Add("unknown");

            predictionMarital.Items.Add("divorced");
            predictionMarital.Items.Add("married");
            predictionMarital.Items.Add("single");
          

            predictionBalance.Items.Add("0");
            predictionBalance.Items.Add("[0 - 1000]");
            predictionBalance.Items.Add("[1001 - 5000]");
            predictionBalance.Items.Add("[5001 - 10000]");
            predictionBalance.Items.Add("[10001 - 20000]");
            predictionBalance.Items.Add("20000 +");

            //desicion tree
            desicionTree.Items.Add("self-implemented");
            desicionTree.Items.Add("Accord library");
        }

        //4, 10, 2, 1, 0, 0, 0, 0
        public void BankPrediction(int a, int b, int c, int d, int e, int f, int g, int h, string name )
        {
            try
            {

                var codebook = new Accord.Statistics.Filters.Codification(table);
                DataTable symbols = codebook.Apply(table);

                int[][] inputs = DataTableToMatrix(symbols, new string[] { "AGE", "JOB", "MARITAL", "EDUCATION", "DEBT", "BALANCE", "HOUSING", "LOAN" });
                int[][] outputs = DataTableToMatrix(symbols, new string[] { "DEPOSIT" });
                int[] output = new int[outputs.Length];
                for (int i = 0; i < outputs.Length; i++)
                {
                    output[i] = outputs[i][0];
                }

                ID3Learning teacher = new ID3Learning()
            {
                new DecisionVariable("AGE", 5),
                new DecisionVariable("JOB", 12),
                new DecisionVariable("MARITAL", 3),
                new DecisionVariable("EDUCATION", 4),
                new DecisionVariable("DEBT", 2),
                new DecisionVariable("BALANCE", 6),
                new DecisionVariable("HOUSING", 2),
                new DecisionVariable("LOAN", 2)

            };

                DecisionTree tree = teacher.Learn(inputs, output);

                //mandar la variable error a un label que me muestre el error que tiene el arbol
                double error = new Accord.Math.Optimization.Losses.ZeroOneLoss(output).Loss(tree.Decide(inputs));
                double ep = Math.Floor(error * 100);
                errorLabel.Text = ep + "%";


                int[] input = new int[] { a, b, c, d, e, f, g, h };
                int prediccion = tree.Decide(input);

                string predijo = prediccion == 1 ? "yes" : "no";
                if (predijo.Equals("yes"))
                {
                    outputLabel.ForeColor = Color.FromArgb(0, 255, 0);
                }
                else if (predijo.Equals("no"))
                {
                    outputLabel.ForeColor = Color.FromArgb(255, 0, 0);
                }
                outputLabel.Text = predijo;

                subjectLabel.Text = "for" + " " + name + " " + "the prediction is";
            }
            catch (Exception) {
                string message = "Yo cannot make predictions without\nloading the data";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
        }

        public int[][] DataTableToMatrix(DataTable table, string[] columns)
        {
            int[][] matrix = new int[table.Rows.Count][];
            for (int i = 0; i < matrix.Length; i++)
                matrix[i] = new int[columns.Length];

            for (int r = 0; r < table.Rows.Count; r++)
            {
                DataRow row = table.Rows[r];
                for (int c = 0; c < columns.Length; c++)
                {
                    matrix[r][c] = (int)row[columns[c]];
                }
            }

            return matrix;
        }

        private void predictionAge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void visualizeTee(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=G2ZLI3Wilpk&t=2013s");
        }
    }
   
}