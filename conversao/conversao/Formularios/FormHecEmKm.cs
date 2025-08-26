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
    public partial class FormHecEmKm : Form
    {
        public FormHecEmKm()
        {
            InitializeComponent();
        }

        private void converterBtn_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(hecTxt.Text);
            double resultado = valor * 0.01;
            kmTxt.Text = resultado.ToString();
        }

        private void novobtn_Click(object sender, EventArgs e)
        {
            kmTxt.Clear(); hecTxt.Clear();
            hecTxt.Select();
        }
    }
}
