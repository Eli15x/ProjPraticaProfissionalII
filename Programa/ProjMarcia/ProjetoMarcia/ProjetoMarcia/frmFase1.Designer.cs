namespace ProjetoMarcia
{
    partial class frmFase1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRes1 = new System.Windows.Forms.Button();
            this.btnRes3 = new System.Windows.Forms.Button();
            this.btnRes2 = new System.Windows.Forms.Button();
            this.btnRes4 = new System.Windows.Forms.Button();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ProjetoMarcia.Properties.Resources.fase11;
            this.pictureBox1.Location = new System.Drawing.Point(45, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btnRes1
            // 
            this.btnRes1.Font = new System.Drawing.Font("Proxy 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes1.Location = new System.Drawing.Point(71, 350);
            this.btnRes1.Name = "btnRes1";
            this.btnRes1.Size = new System.Drawing.Size(305, 58);
            this.btnRes1.TabIndex = 1;
            this.btnRes1.Text = "teste";
            this.btnRes1.UseVisualStyleBackColor = true;
            // 
            // btnRes3
            // 
            this.btnRes3.Font = new System.Drawing.Font("Proxy 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes3.Location = new System.Drawing.Point(71, 442);
            this.btnRes3.Name = "btnRes3";
            this.btnRes3.Size = new System.Drawing.Size(305, 58);
            this.btnRes3.TabIndex = 2;
            this.btnRes3.Text = "teste";
            this.btnRes3.UseVisualStyleBackColor = true;
            // 
            // btnRes2
            // 
            this.btnRes2.Font = new System.Drawing.Font("Proxy 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes2.Location = new System.Drawing.Point(529, 350);
            this.btnRes2.Name = "btnRes2";
            this.btnRes2.Size = new System.Drawing.Size(305, 58);
            this.btnRes2.TabIndex = 3;
            this.btnRes2.Text = "teste";
            this.btnRes2.UseVisualStyleBackColor = true;
            // 
            // btnRes4
            // 
            this.btnRes4.Font = new System.Drawing.Font("Proxy 1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes4.Location = new System.Drawing.Point(529, 442);
            this.btnRes4.Name = "btnRes4";
            this.btnRes4.Size = new System.Drawing.Size(305, 58);
            this.btnRes4.TabIndex = 4;
            this.btnRes4.Text = "teste";
            this.btnRes4.UseVisualStyleBackColor = true;
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Location = new System.Drawing.Point(376, 279);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(35, 13);
            this.lblPergunta.TabIndex = 5;
            this.lblPergunta.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-23, -45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // frmFase1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoMarcia.Properties.Resources.fundoObscuro1;
            this.ClientSize = new System.Drawing.Size(914, 512);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.btnRes4);
            this.Controls.Add(this.btnRes2);
            this.Controls.Add(this.btnRes3);
            this.Controls.Add(this.btnRes1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmFase1";
            this.Text = "frmFase1";
            this.Load += new System.EventHandler(this.frmFase1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmFase1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRes1;
        private System.Windows.Forms.Button btnRes3;
        private System.Windows.Forms.Button btnRes2;
        private System.Windows.Forms.Button btnRes4;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}