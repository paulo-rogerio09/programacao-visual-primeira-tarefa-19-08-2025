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
    public partial class FormMinutosEmHoras : Form
    {
        public FormMinutosEmHoras()
        {
            InitializeComponent();
        }

        private void converterBtn_Click(object sender, EventArgs e)
        {
            double minutos = Convert.ToDouble(minutosTxt.Text);
            double resultado = minutos / 60;
            horasTxt.Text = resultado.ToString();
        }

        private void novobtn_Click(object sender, EventArgs e)
        {
            minutosTxt.Clear(); horasTxt.Clear();
            minutosTxt.Select();
        }
    }
}
