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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //conferir os dados okay...
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();



            if ((txtUsuCad.Text == "") || (txtSenCad.Text == "")||(cmbTimeCad.Text == ""))
                MessageBox.Show("Preencher todos os campos");

            else
            {
                try
                {

                    // cria conexao ao banco de dados
                    SqlConnection con = new SqlConnection();
                    cs = cs.Substring(cs.IndexOf("Data Source"));
                    con.ConnectionString = cs;




                    // cria comando de consulta ao SQL 
                    string cmd_s = "declare @ret bit;" +
                    "" +
                    "select @ret"; //"exec @ret = VerificaUsuario @senha=@sen,@nomeUsuario=@usu";

                    SqlCommand cmd = new SqlCommand(cmd_s, con);
                    cmd.Parameters.AddWithValue("@sen", txtSenha.Text);
                    cmd.Parameters.AddWithValue("@usu", txtUsuario.Text);

              
                    



                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    string str;
                    str = "Source:" + ex.Source;
                    str += "\n" + "Message:" + ex.Message;
                    MessageBox.Show(str, "Database Exception");
                }
            }

        }


    }
}
