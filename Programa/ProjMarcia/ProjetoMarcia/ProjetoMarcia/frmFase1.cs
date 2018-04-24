using System;
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
