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
        SqlConnection con = null;

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if ((txtUsuCad.Text == "") || (txtSenCad.Text == "") || (cmbTimeCad.Text == ""))
                MessageBox.Show("Preencher todos os campos");


            else
            {
                int fezCadastro = 0;
                try
                {
                    if (con == null)
                    {
                        con = new SqlConnection();
                        cs = cs.Substring(cs.IndexOf("Data Source"));
                        con.ConnectionString = cs;
                    }

                    if (VerificaNome())
                    {
                        InsereUsuario();
                        fezCadastro = 1;
                    }
                    else
                        fezCadastro = 0;

                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    string str;
                    str = "Source:" + ex.Source;
                    str += "\n" + "Message:" + ex.Message;
                    MessageBox.Show(str, "Database Exception");
                }

                if (fezCadastro == 1)
                { 
                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nome de Usuario ja existe");
                }
            }

        }

        private Boolean VerificaNome()
        {
            Boolean ret = false;
            try
            {
                if (con == null)
                {
                    con = new SqlConnection();
                    cs = cs.Substring(cs.IndexOf("Data Source"));
                    con.ConnectionString = cs;
                }

                // cria comando de consulta ao SQL 
                string cmd_s = "select * from Usuario where nomeUsuario=@nUsu";
                SqlCommand cmd = new SqlCommand(cmd_s, con);

                cmd.Parameters.AddWithValue("@nUsu", txtUsuCad.Text);


                con.Open();


                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adapt.Fill(ds);
                con.Close();

                if (ds.Tables[0].Rows.Count >= 1)
                    ret = false;
                else
                    ret = true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string str;
                str = "Source:" + ex.Source;
                str += "\n" + "Message:" + ex.Message;
                MessageBox.Show(str, "Database Exception");
            }

            return ret;
        }

        private void InsereUsuario()
        {
            try
            {

                if (con == null)
                {
                    con = new SqlConnection();
                    cs = cs.Substring(cs.IndexOf("Data Source"));
                    con.ConnectionString = cs;
                }
                // cria comando de consulta ao SQL 

                string cmd_s = "Insert into Usuario values(@usu, @sen,0,@time)";
                SqlCommand cmd = new SqlCommand(cmd_s, con);
                cmd.Parameters.AddWithValue("@usu", txtUsuCad.Text);
                cmd.Parameters.AddWithValue("@sen", txtSenCad.Text);

                //nao irmeos mais utilizar codTime
                //mas ainda precisamos inserir algum
                //valor, pois o campo não é null
                cmd.Parameters.AddWithValue("@time", 4);
               

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
                                                                                               