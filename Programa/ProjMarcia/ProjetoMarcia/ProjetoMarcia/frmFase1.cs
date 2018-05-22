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
    public partial class frmFase1 : Form
    {
        Bitmap vilao1  = new Bitmap(@"vilao1.png");
        Bitmap coracao = new Bitmap(@"coracao.png");
        Bitmap usuario = new Bitmap(@"UsuarioAzul.png");
        private static String nomeUsuario;




        int timer     = 0;
        int vida      = 3;
        int mortos    = 0;
        int pontuacao = 0;


        string cs = Properties.Settings.Default.BDPRII17171ConnectionString;
        SqlConnection con = null;

        public frmFase1(String nUsu)
        {
            InitializeComponent();
            nomeUsuario = nUsu;
        }

        private void frmFase1_Load(object sender, EventArgs e)
        {
            //pictureBox2.BackColor = Color.Transparent;
            //pictureBox2.BringToFront();
            pictureBox1.Invalidate();

            atualizarTela();
        }

        private void atualizarTela()
        {

            try
            {
                // cria conexao ao banco de dados
                if (con == null)
                {
                    con = new SqlConnection();
                    cs = cs.Substring(cs.IndexOf("Data Source"));
                    con.ConnectionString = cs;
                }

                //ja chama o pegar respostas
                pegarPerguntas();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            pictureBox1.Invalidate();
            

        }


        private void pegarPerguntas()
        {//esse metod ja chama o pegar respostas

            if (con == null)
            {
                con = new SqlConnection();
                cs = cs.Substring(cs.IndexOf("Data Source"));
                con.ConnectionString = cs;
            }

            // cria comando de consulta ao SQL da pergunta
            string cmd_s = "select * from Pergunta where dificultade between 1 and 2";
            SqlCommand cmd = new SqlCommand(cmd_s, con);

            con.Open();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapt.Fill(ds);
            con.Close();


            Random rd = new Random();
            int i = rd.Next(20);

            if (ds.Tables[0].Rows.Count >= 1)
            {
                DataRow dr = ds.Tables[0].Rows[i];

                lblPergunta.Text = dr.ItemArray[1].ToString();

                //Pegar as respostas
                String codPergunta = dr.ItemArray[0].ToString();
                pegarRespostas(codPergunta);
            }
        }

        private void pegarRespostas(String codP)
        {

            if (con == null)
            {
                con = new SqlConnection();
                cs = cs.Substring(cs.IndexOf("Data Source"));
                con.ConnectionString = cs;
            }

            // cria comando de consulta ao SQL da resposta
            string cmd_sR = "select resposta from Resposta where codPergunta=@codPergunta";
            SqlCommand cmdR = new SqlCommand(cmd_sR, con);

            cmdR.Parameters.AddWithValue("@codPergunta", codP);

            con.Open();

            SqlDataAdapter adaptResp = new SqlDataAdapter(cmdR);
            DataSet dsResp = new DataSet();

            adaptResp.Fill(dsResp);
            con.Close();


            if (dsResp.Tables[0].Rows.Count >= 1)
            {

                DataRow drResp1 = dsResp.Tables[0].Rows[0];
                btnRes1.Text = drResp1.ItemArray[0].ToString();

                DataRow drResp2 = dsResp.Tables[0].Rows[1];
                btnRes2.Text = drResp2.ItemArray[0].ToString();

                DataRow drResp3 = dsResp.Tables[0].Rows[2];
                btnRes3.Text = drResp3.ItemArray[0].ToString();

                DataRow drResp4 = dsResp.Tables[0].Rows[3];
                btnRes4.Text = drResp4.ItemArray[0].ToString();
            }
        }

        

        private void frmFase1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (!(mortos % 6 >= 1) || (mortos % 5 == 0))
                e.Graphics.DrawImage(vilao1, 0, 0, 100, 100);

            if (!(mortos % 6 >= 2) || (mortos % 5 == 0))
                e.Graphics.DrawImage(vilao1, 65, 50, 100, 100);

            if (!(mortos % 6 >= 3) || (mortos % 5 == 0))
                e.Graphics.DrawImage(vilao1, 120, 100, 100, 100);

            if (!(mortos % 6 >= 4) || (mortos % 5 == 0))
                e.Graphics.DrawImage(vilao1, 65, 150, 100, 100);

            if (!(mortos % 6 >= 5) || (mortos % 5 == 0))
                e.Graphics.DrawImage(vilao1, 0, 200, 100, 100);
            
            e.Graphics.DrawImage(usuario, 700, 100, 100, 100);

            if (vida>=3)
                e.Graphics.DrawImage(coracao, 650, 10, 50, 50);
                        
            if (vida>=2)
                e.Graphics.DrawImage(coracao, 700, 10, 50, 50);
         
            if (vida>=1)
                e.Graphics.DrawImage(coracao, 750, 10, 50, 50);
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer++;

            if(timer==20)
            {
                errou();
            }
        }
        private Boolean VerficaResposta(String resposta, String pergunta)
        {
            int status = 0;
            try
            {
                // cria conexao ao banco de dados
                if (con == null)
                {
                    con = new SqlConnection();
                    cs = cs.Substring(cs.IndexOf("Data Source"));
                    con.ConnectionString = cs;
                }

                // cria comando de consulta ao SQL da pergunta
                string cmd_s = "select status from Resposta where resposta=@resposta and codPergunta "+
                                "in (select codPergunta from Pergunta where pergunta = @pergunta)";
                SqlCommand cmd = new SqlCommand(cmd_s, con);
                cmd.Parameters.AddWithValue("@resposta", resposta);
                cmd.Parameters.AddWithValue("@pergunta", pergunta);

                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adapt.Fill(ds);
                con.Close();

               

                if (ds.Tables[0].Rows.Count == 1)
                {
                    DataRow dr = ds.Tables[0].Rows[0];

                    status = Convert.ToInt16(dr.ItemArray[0]);

                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (status == 0)
                return false;

            return true;
        }

        private void btnRes1_Click(object sender, EventArgs e)
        {
            if (VerficaResposta(((Button)sender).Text, lblPergunta.Text))
            {
                acertou();
            }
            else
            {
                errou();
            }
        }

        private void acertou()
        {
            MessageBox.Show("Acertou");
            mortos++;
            if(mortos==5)
            {
                MessageBox.Show("Voce acabou com a primeira onda, continue assim");
            }
            if(mortos ==10)
            {
                //acabou a fase 1
                pontuacao = pontuacao * vida;
                //Verificar sua maior pontação no banco e se for
                //menor do a atual, substituila

              
                if (compararPontuacao())
                {
                    inserePontuacao();
                    frmFimDeJogo fimJogo = new frmFimDeJogo(nomeUsuario, "Novo Recorde", pontuacao);
                    fimJogo.Show();
                }
                else
                {
                    frmFimDeJogo fimJogo = new frmFimDeJogo(nomeUsuario, "Essa nao foi sua mellhor batalha, porem foi um bom trabalho", pontuacao);
                    fimJogo.Show();
                }

               
                this.Close();

            }
            atualizarTela();            
            timer = 0;
            pontuacao += 10 *(10-timer);
            
        }
        private void errou()
        {
            MessageBox.Show("Errou");
            vida--;
            
            atualizarTela();
            timer = 0;
           
            if (vida == 0)
            {
                frmFimDeJogo fimJogo = new frmFimDeJogo(nomeUsuario," Ah que pena, voce perdeu. Mas não desista...", pontuacao);
                fimJogo.Show();
                this.Close();
            }            
        }

        private Boolean compararPontuacao()
        {
            int pontuacaoAnterior =0;
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
                    pontuacaoAnterior = Convert.ToInt16(dr.ItemArray[0]);                   
                }

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string str;
                str = "Source:" + ex.Source;
                str += "\n" + "Message:" + ex.Message;
                MessageBox.Show(str, "Database Exception");
            }

            if (pontuacao > pontuacaoAnterior)
                return true;
            else
                return false;
            

        }

        public void inserePontuacao()
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

                string cmd_s = "update Usuario set maiorPontuacao=@pontuacao where nomeUsuario =@nUsu";
                SqlCommand cmd = new SqlCommand(cmd_s, con);
                cmd.Parameters.AddWithValue("@nUsu", nomeUsuario);
                cmd.Parameters.AddWithValue("@pontuacao", pontuacao);


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
