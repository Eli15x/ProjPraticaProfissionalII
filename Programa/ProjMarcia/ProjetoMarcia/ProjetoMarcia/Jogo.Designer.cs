namespace ProjetoMarcia
{
    partial class frmJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrInstrucoes = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picFase1 = new System.Windows.Forms.PictureBox();
            this.picFase2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFase2)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrInstrucoes
            // 
            this.tmrInstrucoes.Interval = 2000;
            this.tmrInstrucoes.Tick += new System.EventHandler(this.tmrInstrucoes_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1426, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 316);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.Color.Transparent;
            this.picImagem.BackgroundImage = global::ProjetoMarcia.Properties.Resources.computador;
            this.picImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImagem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.picImagem.Location = new System.Drawing.Point(-35, -54);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(1040, 700);
            this.picImagem.TabIndex = 7;
            this.picImagem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(2)))));
            this.lblInfo.Font = new System.Drawing.Font("OCR A Extended", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblInfo.Location = new System.Drawing.Point(225, 214);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(489, 116);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Precisamos de sua ajuda para\r\nvencermos a guerra\r\nUse seus conhecimentos \r\npara v" +
    "ence-los!\r\n";
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProximo.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(380, 407);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(162, 51);
            this.btnProximo.TabIndex = 10;
            this.btnProximo.Text = "Proximo ->";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click_1);
            // 
            // picFase1
            // 
            this.picFase1.BackgroundImage = global::ProjetoMarcia.Properties.Resources.numero1;
            this.picFase1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFase1.Image = global::ProjetoMarcia.Properties.Resources.numero1;
            this.picFase1.Location = new System.Drawing.Point(358, 262);
            this.picFase1.Name = "picFase1";
            this.picFase1.Size = new System.Drawing.Size(77, 50);
            this.picFase1.TabIndex = 11;
            this.picFase1.TabStop = false;
            this.picFase1.Click += new System.EventHandler(this.picFase1_Click);
            // 
            // picFase2
            // 
            this.picFase2.BackgroundImage = global::ProjetoMarcia.Properties.Resources.numero2;
            this.picFase2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFase2.Location = new System.Drawing.Point(520, 262);
            this.picFase2.Name = "picFase2";
            this.picFase2.Size = new System.Drawing.Size(53, 50);
            this.picFase2.TabIndex = 12;
            this.picFase2.TabStop = false;
            this.picFase2.Click += new System.EventHandler(this.picFase2_Click);
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::ProjetoMarcia.Properties.Resources.fundoObscuro;
            this.ClientSize = new System.Drawing.Size(977, 676);
            this.Controls.Add(this.picFase2);
            this.Controls.Add(this.picFase1);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJogo";
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFase2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrInstrucoes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picFase1;
        private System.Windows.Forms.PictureBox picFase2;
    }
}