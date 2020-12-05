using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Integrador.DecisionTreeClassifier;

namespace Proyecto_Integrador.Model
{
    class Dato : DatasetRow
    {
        private string age;
        private string job;
        private string marital;
        private string education;
        private string debt;
        private string balance;
        private string housing;
        private string loan;
        private string y;

        public Dato(string age, string job, string marital, string education, string debt, string balance, string housing, string loan, string y)
        {
            this.age = age;
            this.job = job;
            this.marital = marital;
            this.education = education;
            this.debt = debt;
            this.balance = balance;
            this.housing = housing;
            this.loan = loan;
            this.y = y;
        }

        public string Age { get => age; set => age = value; }
        public string Job { get => job; set => job = value; }
        public string Marital { get => marital; set => marital = value; }
        public string Education { get => education; set => education = value; }
        public string Debt { get => debt; set => debt = value; }
        public string Balance { get => balance; set => balance = value; }
        public string Housing { get => housing; set => housing = value; }
        public string Loan { get => loan; set => loan = value; }
        public string Y { get => y; set => y = value; }

        public string[] getAttributes()
        {
            string[] attributes = { "" + age, "" + job, "" + marital, "" + education, "" + debt, "" + balance, "" + loan, "" + y };

            return attributes;
        }

        public static string[] getAttributesName()
        {
            string[] attributes = { "age", "job", "marital", "education", "debt", "balnace", "loan", "y" };

            return attributes;
        }
    }
}
