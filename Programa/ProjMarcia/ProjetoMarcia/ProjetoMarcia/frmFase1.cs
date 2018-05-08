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
        Bitmap vilao1 = new Bitmap(@"vilao1.png");

        public frmFase1()
        {
            InitializeComponent();
        }

        private void frmFase1_Load(object sender, EventArgs e)
        {
            //pictureBox2.BackColor = Color.Transparent;
            //pictureBox2.BringToFront();
            pictureBox1.Invalidate();



            try
            {
                // cria conexao ao banco de dados
                SqlConnection con = new SqlConnection();
                cs = cs.Substring(cs.IndexOf("Data Source"));
                con.ConnectionString = cs;

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

                    // cria comando de consulta ao SQL da resposta
                    string cmd_sR = "select resposta from Resposta where codPergunta=@codPergunta";
                    SqlCommand cmdR = new SqlCommand(cmd_sR, con);

                    String codPergunta = dr.ItemArray[0].ToString();
                    cmd.Parameters.AddWithValue("@codPergunta", codPergunta);

                    con.Open();

                    SqlDataAdapter adaptResp = new SqlDataAdapter(cmdR);
                    DataSet dsResp = new DataSet();

                    adaptResp.Fill(dsResp);
                    con.Close();


                    if (dsResp.Tables[0].Rows.Count >= 1)
                    {

                        DataRow drResp = dsResp.Tables[0].Rows[0];


                        btnRes1.Text = drResp.ItemArray[0].ToString();

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmFase1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(vilao1, 0, 0, 273, 274);
        }
    }
}
