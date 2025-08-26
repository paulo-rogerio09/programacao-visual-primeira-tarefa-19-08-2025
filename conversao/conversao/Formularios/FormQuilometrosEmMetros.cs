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
    public partial class FormQuilometrosEmMetros : Form
    {
        public FormQuilometrosEmMetros()
        {
            InitializeComponent();
        }

        private void converterBtn_Click(object sender, EventArgs e)
        {
            double quilom = Convert.ToDouble(quilometrosTxt.Text);
            double quipme = quilom * 1000;
            metrosTxt.Text = quipme.ToString();
        }

        private void novobtn_Click(object sender, EventArgs e)
        {
            metrosTxt.Clear(); quilometrosTxt.Clear();
            quilometrosTxt.Select();
        }
    }
}
