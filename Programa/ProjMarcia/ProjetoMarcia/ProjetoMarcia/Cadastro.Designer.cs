namespace ProjetoMarcia
{
    partial class frmCadastro
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtUsuCad = new System.Windows.Forms.TextBox();
            this.txtSenCad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTimeCad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCadastrar.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(94, 446);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(309, 78);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtUsuCad
            // 
            this.txtUsuCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtUsuCad.Location = new System.Drawing.Point(490, 101);
            this.txtUsuCad.Name = "txtUsuCad";
            this.txtUsuCad.Size = new System.Drawing.Size(278, 44);
            this.txtUsuCad.TabIndex = 7;
            // 
            // txtSenCad
            // 
            this.txtSenCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtSenCad.Location = new System.Drawing.Point(490, 206);
            this.txtSenCad.Name = "txtSenCad";
            this.txtSenCad.Size = new System.Drawing.Size(278, 44);
            this.txtSenCad.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(84, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(85, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 59);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(85, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 59);
            this.label3.TabIndex = 11;
            this.label3.Text = "Escolha de time";
            // 
            // cmbTimeCad
            // 
            this.cmbTimeCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.cmbTimeCad.FormattingEnabled = true;
            this.cmbTimeCad.Items.AddRange(new object[] {
            "Vermelho",
            "Azul"});
            this.cmbTimeCad.Location = new System.Drawing.Point(490, 305);
            this.cmbTimeCad.Name = "cmbTimeCad";
            this.cmbTimeCad.Size = new System.Drawing.Size(278, 45);
            this.cmbTimeCad.TabIndex = 12;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProjetoMarcia.Properties.Resources.fundoObscuro;
            this.ClientSize = new System.Drawing.Size(914, 548);
            this.Controls.Add(this.cmbTimeCad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenCad);
            this.Controls.Add(this.txtUsuCad);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtUsuCad;
        private System.Windows.Forms.TextBox txtSenCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTimeCad;
    }
}