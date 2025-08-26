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
    public partial class FormHorasEmMinutos : Form
    {
        public FormHorasEmMinutos()
        {
            InitializeComponent();
        }

        private void converterBtn_Click(object sender, EventArgs e)
        {
            double horas = Convert.ToDouble(horasTxt.Text);
            double resultado = horas * 60;
            minutosTxt.Text = resultado.ToString();

        }

        private void novobtn_Click(object sender, EventArgs e)
        {
            minutosTxt.Clear(); horasTxt.Clear();
            horasTxt.Select();
        }
    }
}
