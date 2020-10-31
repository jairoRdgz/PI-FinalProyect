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
            jobList = new List<string>();
            maritalList = new List<string>();
            educationList = new List<string>();
            debtList = new List<string>();
            housingList = new List<string>();
            loanList = new List<string>();
            yList = new List<string>();
        }

        public void addDato(Dato a)
        {
            datos.Add(a);
            initYList(a);
            initLoanList(a);
            initHousingList(a);
            initDebtList(a);
            initJobsList(a);
            initEducationList(a);
            initMaritalList(a);
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

        public void initYList(Dato a)
        {
            if (!yList.Contains(a.Y))
            {
                yList.Add(a.Y);
            }
        }

        public void initLoanList(Dato a)
        {
            if (!loanList.Contains(a.Loan))
            {
                loanList.Add(a.Loan);
            }
        }
        public void initHousingList(Dato a)
        {
            if (!housingList.Contains(a.Housing))
            {
                housingList.Add(a.Housing);
            }
        }

        public void initDebtList(Dato a)
        {
            if (!debtList.Contains(a.Debt))
            {
                debtList.Add(a.Debt);
            }
        }

        public void initJobsList(Dato a)
        {
            if (!jobList.Contains(a.Job))
            {
                jobList.Add(a.Job);
            }
        }

        public void initEducationList(Dato a)
        {
            if (!educationList.Contains(a.Education))
            {
                educationList.Add(a.Education);
            }
        }

        public void initMaritalList(Dato a)
        {
            if (!maritalList.Contains(a.Marital))
            {
                maritalList.Add(a.Marital);
            }
        }
    }
}
