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
    public partial class FormMetrosEmQuilometros : Form
    {
        public FormMetrosEmQuilometros()
        {
            InitializeComponent();
        }

        private void converterBtn_Click(object sender, EventArgs e)
        {
            double metros = Convert.ToDouble(metrosTxt.Text);
            double mepqui = metros / 1000;
            quilometrosTxt.Text = mepqui.ToString();

        }

        private void novobtn_Click(object sender, EventArgs e)
        {
            metrosTxt.Clear(); quilometrosTxt.Clear();
            metrosTxt.Select();
        }
    }
}
