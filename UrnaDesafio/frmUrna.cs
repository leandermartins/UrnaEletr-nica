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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int galo, kiko, gretchen, betina,branco=0;
        void NovoDigitp(string digito)
        {
            if (txtUm.Text == "")
            {
                txtUm.Text = digito;

            }
            else
            {
                txtDois.Text = digito;
                validarVoto();
            }
        }
        void validarVoto()
        {
           switch(txtUm.Text + txtDois.Text)
            {
                case "11":
                    pcbCandidato.BackgroundImage = Image.FromFile("kqqdap2_sm.jpg");
                    lblNomeCandidato.Text = "Galo cego";
                    lblNomeCandidato.Visible = true;
                    break;
                case "21":
                    pcbCandidato.BackgroundImage = Image.FromFile("gretchen_347963_36.jpg");
                    lblNomeCandidato.Text = "Gretchen";
                    lblNomeCandidato.Visible = true;
                    break;
                case "31":
                    pcbCandidato.BackgroundImage = Image.FromFile("CNcScjmL_400x400.jpg");
                    lblNomeCandidato.Text = "kiko";
                    lblNomeCandidato.Visible = true;
                    break;
                case "41":
                    pcbCandidato.BackgroundImage = Image.FromFile("propaganda-amplamente-divulgada-youtube-e-em-redes-sociais-virou-meme-1552674285649_v2_900x506.jpg");
                    lblNomeCandidato.Text = "Betina";
                    lblNomeCandidato.Visible = true;
                    break;
                default:
                    MessageBox.Show("Candidato Inválido");
                    txtUm.Clear();
                    txtDois.Clear();
                    break;
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NovoDigitp("3");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(lblNomeCandidato.Text=="Voto em branco")
            {
                branco++;
                lblNomeCandidato.Text = "";
                tocarSom();
                limpar();
            }
            switch (txtUm.Text + txtDois.Text)
            {
                case "11":
                    galo++;
                    tocarSom();
                    limpar();
                    break;
                case "21":
                    gretchen++;
                    tocarSom();
                    limpar();
                    break;
                  
                case "31":
                    kiko++;
                    tocarSom();
                    limpar();
                    break;
                case "41":
                    betina++;
                    tocarSom();
                    limpar();
                    break;
                default:
                    MessageBox.Show("Você precisa informar um voto válido");
                   break;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lblNomeCandidato.Visible = true;
            lblNomeCandidato.Text = "Voto em branco";
            pcbCandidato.BackgroundImage = null;
            txtUm.Clear();
            txtDois.Clear();
        }

        private void txtUm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            NovoDigitp("1");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            NovoDigitp("2");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            NovoDigitp("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            NovoDigitp("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            NovoDigitp("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            NovoDigitp("7");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            limpar();
            

        }
        void limpar()
        {
            txtDois.Clear();
            txtUm.Clear();
            pcbCandidato.BackgroundImage = null;
            lblNomeCandidato.Visible = false;
            lblNomeCandidato.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmResultado frmResultado = new frmResultado(galo, kiko, gretchen, betina, branco);
            frmResultado.ShowDialog();
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            NovoDigitp("8");
        }
        void tocarSom()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("som_urna.wav");
        }
        private void btnNove_Click(object sender, EventArgs e)
        {
            NovoDigitp("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            NovoDigitp("0");
        }
    }
}
