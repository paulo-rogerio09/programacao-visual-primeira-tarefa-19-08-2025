using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversao.Formularios
{
    public partial class FormHecParaAlq : Form
    {
        public FormHecParaAlq()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void converterBtn_Click(object sender, EventArgs e)
        {
            double hec = Convert.ToDouble(hecTxt.Text);
            double hecpalq = hec / 2.42;
            alqTxt.Text = hecpalq.ToString();
        }

        private void novobtn_Click(object sender, EventArgs e)
        {
            alqTxt.Clear(); hecTxt.Clear();
            hecTxt.Select();
        }
    }
}
