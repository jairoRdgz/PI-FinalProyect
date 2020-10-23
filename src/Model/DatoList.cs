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
        private List<string> jobList;
        private List<string> maritalList;
        private List<string> educationList;
        private List<string> debtList;
        private List<string> housingList;
        private List<string> loanList;
        private List<string> yList;

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

        public List<string> JobList { get => jobList; }
        public List<string> MaritalList { get => maritalList; }
        public List<string> EducationList { get => educationList; }
        public List<string> DebtList { get => debtList; }
        public List<string> HousingList { get => housingList; }
        public List<string> LoanList { get => loanList; }
        public List<string> YList { get => yList; }

        public void initYList()
        {
            foreach (var item in datos)
            {
                if (yList.Contains(item.Y))
                {
                    yList.Add(item.Y);
                }
            }
        }

        public void initLoanList()
        {
            foreach (var item in datos)
            {
                if (loanList.Contains(item.Loan))
                {
                    loanList.Add(item.Loan);
                }
            }
        }
        public void initHousingList()
        {
            foreach (var item in datos)
            {
                if (housingList.Contains(item.Housing))
                {
                    housingList.Add(item.Housing);
                }
            }
        }

        public void initDebtList()
        {
            foreach (var item in datos)
            {
                if (debtList.Contains(item.Debt))
                {
                    debtList.Add(item.Debt);
                }
            }
        }

        public void initJobsList()
        {
            foreach (var item in datos)
            {
                if (jobList.Contains(item.Job))
                {
                    jobList.Add(item.Job);
                }
            }
        }

        public void initEducationList()
        {
            foreach (var item in datos)
            {
                if (educationList.Contains(item.Education))
                {
                    educationList.Add(item.Education);
                }
            }
        }

        public void initMaritalList()
        {
            foreach (var item in datos)
            {
                if (maritalList.Contains(item.Marital))
                {
                    maritalList.Add(item.Marital);
                }
            }
        }
    }
}
