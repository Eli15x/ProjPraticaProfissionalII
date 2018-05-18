using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMarcia
{
    public partial class frmFimDeJogo : Form
    {
        public frmFimDeJogo()
        {
            InitializeComponent();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            frmFase1 fase1 = new frmFase1();
            fase1.Show();
            this.Close();

        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            frmLogin fLogin = new frmLogin();
            fLogin.Show();
            this.Close();
        }

        private void btnFase_Click(object sender, EventArgs e)
        {
            frmJogo fFases= new frmJogo();
            fFases.Show();
            this.Close();
        }
    }
}
