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
     


        int timer = 0;
        int vida  = 3;


        string cs = Properties.Settings.Default.BDPRII17171ConnectionString;
        SqlConnection con = null;

        public frmFase1()
        {
            InitializeComponent();
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
                    passaRespostas(codPergunta);                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            pictureBox1.Invalidate();
            
        }

        private void passaRespostas (String codP)
        {
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
            e.Graphics.DrawImage(vilao1,    0, 0, 273, 274);
            if(vida>=3)
                e.Graphics.DrawImage(coracao, 650, 10, 50, 50);
                        
            if (vida>=2)
                e.Graphics.DrawImage(coracao, 700, 10, 50, 50);
         
            if (vida>=1)
                e.Graphics.DrawImage(coracao, 750, 10, 50, 50);
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer++;

            if(timer==10)
            {
                vida--;
                atualizarTela();
                timer = 0;
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
                string cmd_s = "select status from Resposta where resposta=@resposta and codPergunta"+
                                "in (select codPergunta from Pergunta where pergunta = @pergunta)";
                SqlCommand cmd = new SqlCommand(cmd_s, con);
                cmd.Parameters.AddWithValue("@resposta", resposta);
                cmd.Parameters.AddWithValue("@pergunta", pergunta);

                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adapt.Fill(ds);
                con.Close();

               

                if (ds.Tables[0].Rows.Count >= 1)
                {
                    DataRow dr = ds.Tables[0].Rows[0];

                    status = Convert.ToInt16(dr.ItemArray[1]);

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
            if (VerficaResposta(btnRes1.Text, lblPergunta.Text))
            {
                MessageBox.Show("C*U*A Mundo");
            }
            else
            {
                MessageBox.Show("Errou");
            }
        }

        private void btnRes2_Click(object sender, EventArgs e)
        {
            if (VerficaResposta(btnRes2.Text, lblPergunta.Text))
            {
                MessageBox.Show("C*U*A Mundo");
            }
            else
            {
                MessageBox.Show("Errou");
            }
        }

        private void btnRes3_Click(object sender, EventArgs e)
        {
            if (VerficaResposta(btnRes3.Text, lblPergunta.Text))
            {
                MessageBox.Show("C*U*A Mundo");
            }
            else
            {
                MessageBox.Show("Errou");
            }
        }

        private void btnRes4_Click(object sender, EventArgs e)
        {
            if (VerficaResposta(btnRes4.Text, lblPergunta.Text))
            {
                MessageBox.Show("C*U*A Mundo");
            }
            else
            {
                MessageBox.Show("Errou");
            }
        }
    }
   
}
