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
<<<<<<< HEAD
=======

>>>>>>> a2ecaf69c4592e99d6271fca6bb143ad8a67dfe1
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
<<<<<<< HEAD
            if ((cmbTimeCad.Text == "VErmelho") || (cmbTimeCad.Text=="Azul"))
                MessageBox.Show("Cor de time inválida");
=======
>>>>>>> a2ecaf69c4592e99d6271fca6bb143ad8a67dfe1

            else
            {
                try
                {

                    // cria conexao ao banco de dados
                    SqlConnection con = new SqlConnection();
                    cs = cs.Substring(cs.IndexOf("Data Source"));
                    con.ConnectionString = cs;




                    // cria comando de consulta ao SQL 
<<<<<<< HEAD
                    string cmd_s = "Insert into Usuario values(@usu, @sen,0,@time)";
=======
                    string cmd_s = "insert into Usuario values(@usu,@sen,0,@time)";
>>>>>>> a2ecaf69c4592e99d6271fca6bb143ad8a67dfe1

                    SqlCommand cmd = new SqlCommand(cmd_s, con);
                    cmd.Parameters.AddWithValue("@usu", txtUsuCad.Text);
                    cmd.Parameters.AddWithValue("@sen", txtSenCad.Text);
<<<<<<< HEAD
                    if (cmbTimeCad.Text == "Azul")
                        cmd.Parameters.AddWithValue("@time", 4);
                    else
                        cmd.Parameters.AddWithValue("@time", 1);

=======
                    if(cmbTimeCad.Text=="Azul")
                        cmd.Parameters.AddWithValue("@time", 4);
                    else
                        if(cmbTimeCad.Text == "Vermelho")
                            cmd.Parameters.AddWithValue("@time", 1);
                        else
                            MessageBox.Show("Valor Invalido para time");
>>>>>>> a2ecaf69c4592e99d6271fca6bb143ad8a67dfe1

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();

<<<<<<< HEAD



=======
>>>>>>> a2ecaf69c4592e99d6271fca6bb143ad8a67dfe1
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    string str;
                    str = "Source:" + ex.Source;
                    str += "\n" + "Message:" + ex.Message;
                    MessageBox.Show(str, "Database Exception");
                }
            }
<<<<<<< HEAD
            
=======

>>>>>>> a2ecaf69c4592e99d6271fca6bb143ad8a67dfe1
        }


    }
}
                                                                                               