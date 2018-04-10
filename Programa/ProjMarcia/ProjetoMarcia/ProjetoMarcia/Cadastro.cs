using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoMarcia
{
    public partial class frmCadastro : Form
    {

   
        string cs = Properties.Settings.Default.BDPRII17171ConnectionString;

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

            if (!(cmbTimeCad.Text == "Vermelho") || (cmbTimeCad.Text=="Azul"))
                MessageBox.Show("Cor de time inválida");


            else
            {
                try
                {

                    // cria conexao ao banco de dados
                    SqlConnection con = new SqlConnection();
                    cs = cs.Substring(cs.IndexOf("Data Source"));
                    con.ConnectionString = cs;




                    // cria comando de consulta ao SQL 

                    string cmd_s = "Insert into Usuario values(@usu, @sen,0,@time)";
                    SqlCommand cmd = new SqlCommand(cmd_s, con);
                    cmd.Parameters.AddWithValue("@usu", txtUsuCad.Text);
                    cmd.Parameters.AddWithValue("@sen", txtSenCad.Text);

                    if (cmbTimeCad.Text == "Azul")
                        cmd.Parameters.AddWithValue("@time", 4);
                    else
                        cmd.Parameters.AddWithValue("@time", 1);
                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
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
                                                                                               