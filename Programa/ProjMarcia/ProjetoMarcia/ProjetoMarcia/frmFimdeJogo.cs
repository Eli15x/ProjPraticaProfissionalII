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
        private static String usuario;

        public frmFimDeJogo(String usu,String msg, int pontuacao)
        {
            InitializeComponent();
            usuario = usu;
            lblMsg.Text = msg;
            lblPontuacao.Text = pontuacao.ToString();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            frmFase1e2 fase1 = new frmFase1e2(usuario);
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
            frmJogo fFases= new frmJogo(usuario);
            fFases.Show();
            this.Close();
        }
    }
}
