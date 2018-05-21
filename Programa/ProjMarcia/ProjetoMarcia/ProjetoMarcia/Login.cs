using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace ProjetoMarcia
{
    public partial class frmLogin : Form
    {

        string cs = Properties.Settings.Default.BDPRII17171ConnectionString;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "") || (txtSenha.Text == ""))
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
                    "exec @ret = VerificaUsuario @senha = @sen, @NomeUsuario= @usu;" +
                    "select @ret"; //"exec @ret = VerificaUsuario @senha=@sen,@nomeUsuario=@usu";

                    SqlCommand cmd = new SqlCommand(cmd_s, con);
                   cmd.Parameters.AddWithValue("@sen", txtSenha.Text);
                   cmd.Parameters.AddWithValue("@usu", txtUsuario.Text);

                    con.Open();


                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    adapt.Fill(ds);
                    con.Close();

                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        DataRow dr = ds.Tables[0].Rows[0];
                        int ret = Convert.ToInt16(dr.ItemArray[0]);

                        if (ret == 1)
                        {
                            frmJogo Jogo = new frmJogo();
                            Jogo.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario e senha não condizem");
                        }
                    }



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

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.Show();
            this.Hide(); 
        }
    }
}
