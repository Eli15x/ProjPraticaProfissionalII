using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMarcia
{
    public partial class frmJogo : Form
    {
        private static String nomeUsuario;

        string cs = Properties.Settings.Default.BDPRII17171ConnectionString;
        SqlConnection con = null;


        public frmJogo(String usu)
        {
            InitializeComponent();
            picFase1.Visible = false;
            picFase2.Visible = false;
            picFase1.Enabled = false;
            picFase2.Enabled = false;
           

            nomeUsuario = usu;
        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            //AtivaBotoes();
        }

        private void tmrInstrucoes_Tick(object sender, EventArgs e)
        {
            //btnProximo.Enabled = true;
            // btnProximo.Visible = true;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click_1(object sender, EventArgs e)
        {
            btnProximo.Visible = false;
            lblInfo.Text = "Escolha sua fase:";
            lblInfo.Left = 325;
            lblInfo.Top = 200;
            picFase1.Visible = true;
            picFase1.Enabled = true;
            picFase2.Enabled = true;
            picFase2.Visible = true;
        }

        private void picFase1_Click(object sender, EventArgs e)
        {
            frmFase1e2 fase1 = new frmFase1e2(nomeUsuario, 1);
            fase1.Show();
            this.Close();
        }

        private void picFase2_Click(object sender, EventArgs e)
        {
            if(ExistePontuacao())
            {
                frmFase1e2 fase2 = new frmFase1e2(nomeUsuario, 2);
                fase2.Show();
                this.Close();
            }
        }

        private Boolean ExistePontuacao()
        {
            int pontuacao = 0;
            try
            {

                // cria conexao ao banco de dados
                SqlConnection con = new SqlConnection();
                cs = cs.Substring(cs.IndexOf("Data Source"));
                con.ConnectionString = cs;

                // cria comando de consulta ao SQL 
                string cmd_s = "select maiorPontuacao from Usuario where nomeUsuario=@nomeUsuario";

                SqlCommand cmd = new SqlCommand(cmd_s, con);
                cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);

                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adapt.Fill(ds);
                con.Close();

                if (ds.Tables[0].Rows.Count == 1)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    pontuacao = Convert.ToInt16(dr.ItemArray[0]);
                }

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string str;
                str = "Source:" + ex.Source;
                str += "\n" + "Message:" + ex.Message;
                MessageBox.Show(str, "Database Exception");
            }

            if (pontuacao > 0)
                return true;
            else
                return false;
        }

        

    }
}
