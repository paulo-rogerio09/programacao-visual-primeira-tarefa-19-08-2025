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
    }
}
