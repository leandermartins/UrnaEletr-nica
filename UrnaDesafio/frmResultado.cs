using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaDesafio
{
    public partial class frmResultado : Form
    {
        public frmResultado(int galo,int kiko, int gretchen, int betina, int branco)
        {
            InitializeComponent();
            lblGalo.Text = galo.ToString();
            lblKiko.Text = kiko.ToString();
            lblGretchen.Text = gretchen.ToString();
            lblBetina.Text = betina.ToString();
            lblBranco.Text = branco.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmResultado_Load(object sender, EventArgs e)
        {

        }
    }
}
