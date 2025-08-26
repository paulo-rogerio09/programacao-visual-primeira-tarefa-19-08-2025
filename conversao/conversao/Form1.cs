using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conversao.Formularios;//digitei essa linha para ter acesso ao conteudo da pasta formulario                 

namespace conversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btHecParaAlqu_Click(object sender, EventArgs e)
        {
            //chamada do formulario
            FormHecParaAlq form = new FormHecParaAlq();
            form.ShowDialog();
        }

        private void btAlquParaHec_Click(object sender, EventArgs e)
        {
            FormAlqParaHec form = new FormAlqParaHec();
            form.ShowDialog();
        }

        private void metpquiTxt_Click(object sender, EventArgs e)
        {
            FormMetrosEmQuilometros form = new FormMetrosEmQuilometros();
            form.ShowDialog(); 
        }

        private void horpminTxt_Click(object sender, EventArgs e)
        {
            FormHorasEmMinutos form = new FormHorasEmMinutos();
            form.ShowDialog();
        }

        private void quipmet_Click(object sender, EventArgs e)
        {
            FormQuilometrosEmMetros form = new FormQuilometrosEmMetros();
            form.ShowDialog();
        }

        private void minphor_Click(object sender, EventArgs e)
        {
            FormMinutosEmHoras form = new FormMinutosEmHoras();
            form.ShowDialog();
        }

        private void hecpkm_Click(object sender, EventArgs e)
        {
            FormHecEmKm form = new FormHecEmKm();
            form.ShowDialog();
        }
    }
}
