﻿using System;
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
    public partial class frmJogo : Form
    {
        private static String usuario;

        // private int imagensInicio;
        //private int CodTime;
        // private String Nome;
        public frmJogo(String usu)
        {
            InitializeComponent();
            picFase1.Visible = false;
            picFase2.Visible = false;
            picFase1.Enabled = false;
            picFase2.Enabled = false;
            // btnProximo.Enabled = false;
            //btnProximo.Visible = false;
            // tmrInstrucoes.Interval = 3000;
            // tmrInstrucoes.Tick += new EventHandler(tmrInstrucoes_Tick);
            // imagensInicio = 1;

            usuario = usu;
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
            lblInfo.Top  = 200; 
            picFase1.Visible = true;
            picFase1.Enabled = true;
            picFase2.Enabled = true;
            picFase2.Visible = true;
        }

        private void picFase1_Click(object sender, EventArgs e)
        {
            frmFase1 fase1 = new frmFase1(usuario);
            fase1.Show();
            this.Close();
        }

        private void picFase2_Click(object sender, EventArgs e)
        {

        }

        /* private void tmrInstrucoes_Tick(object sender, EventArgs e)
         {

            if (imagensInicio == 1)
             {
                 this.BackgroundImage = Image.FromFile("imagensJogo/primeira2.png");
                 AtivaBotoes();
                 tmrInstrucoes.Enabled = false;
                 this.Time
                 imagensInicio = 2;

             }

             if(imagensInicio == 2)
             {
                 CancelaBotoes();
                 this.BackgroundImage = Image.FromFile("C:/Users/u17171/Desktop/ProjMarcia/imagensJogo/fundoObscuro.png");
                 imagensInicio = 3;

                 tmrInstrucoes.Enabled = false;
                 MessageBox.Show(this.CodTime.ToString());
             }



         }

         private void btnAzul_Click(object sender, EventArgs e)
         {
             MessageBox.Show("entrou azul");
             this.CodTime = 1;
             imagensInicio = 2;
             tmrInstrucoes.Interval = 100;
             tmrInstrucoes.Enabled = true;
         }

         private void btnVermelho_Click(object sender, EventArgs e)
         {
             MessageBox.Show("entrou vermelho");
             this.CodTime = 2;
             imagensInicio = 2;
             tmrInstrucoes.Interval = 100;
             tmrInstrucoes.Enabled = true;

         }


        private void CancelaBotoes()
         {
             btnAzul.Visible = false;
             btnVermelho.Visible = false;
             btnVermelho.Enabled = false;
             btnAzul.Enabled = false;

         }

         private void AtivaBotoes()
         {
             btnAzul.Visible = true;
             btnVermelho.Visible = true;
             btnVermelho.Enabled = true;
             btnAzul.Enabled = true;

        }*/


    }
}
