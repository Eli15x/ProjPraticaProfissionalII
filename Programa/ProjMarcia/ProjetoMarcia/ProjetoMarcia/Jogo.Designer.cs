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
            this.btnAzul = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVermelho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmrInstrucoes
            // 
            this.tmrInstrucoes.Enabled = true;
            this.tmrInstrucoes.Interval = 10;
            this.tmrInstrucoes.Tick += new System.EventHandler(this.tmrInstrucoes_Tick);
            // 
            // btnAzul
            // 
            this.btnAzul.Enabled = false;
            this.btnAzul.Location = new System.Drawing.Point(158, 297);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(354, 341);
            this.btnAzul.TabIndex = 0;
            this.btnAzul.UseVisualStyleBackColor = true;
            this.btnAzul.Visible = false;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
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
            // btnVermelho
            // 
            this.btnVermelho.Enabled = false;
            this.btnVermelho.Location = new System.Drawing.Point(759, 297);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(354, 341);
            this.btnVermelho.TabIndex = 2;
            this.btnVermelho.UseVisualStyleBackColor = true;
            this.btnVermelho.Visible = false;
            this.btnVermelho.Click += new System.EventHandler(this.btnVermelho_Click);
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProjetoMarcia.Properties.Resources.fundoObscuro;
            this.ClientSize = new System.Drawing.Size(1264, 770);
            this.Controls.Add(this.btnVermelho);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAzul);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJogo";
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrInstrucoes;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVermelho;
    }
}