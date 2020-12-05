using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class ResultClasification : Form
    {
        public ResultClasification(List<String> result)
        {
            InitializeComponent();

            foreach (String clas in result)
            {
                this.classificationList.Items.Add(clas);
            }
        }
    }
}