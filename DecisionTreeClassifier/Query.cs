using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.DecisionTreeClassifier
{
    class Query<T> where T:DatasetRow
    {
        private string[] attributes;

        private int attribute;
        private string value;

        public Query(int attribute, string value)
        {
            this.attributes = Model.Dato.getAttributesName();
            this.attribute = attribute;
            this.value = value;
        }

        private bool isNumeric(int at)
        {
            int[] numerics = { 0, 3, 4, 7, 9 };

            foreach (int i in numerics)
            {
                if (i == at)
                {
                    return true; ;
                }
            }
            return false;
        }

        public bool Compare(T example)
        {
            bool response;
            string temp = example.getAttributes()[this.attribute];


            if (this.isNumeric(this.attribute))
            {
                response = Convert.ToDouble(this.value) >= Convert.ToDouble(temp);
            }
            else
            {
                response = this.value.Equals(temp);
            }

            return response;
        }

        public int GetAttribute()
        {
            return this.attribute;
        }

        public string GetValue()
        {
            return this.value;
        }

        public override string ToString()
        {
            string oper = " == ";

            if (this.isNumeric(this.attribute))
                oper = " >= ";

            return "Is "+this.attributes[this.attribute]+oper+this.value+"?";

        }
    }
}
