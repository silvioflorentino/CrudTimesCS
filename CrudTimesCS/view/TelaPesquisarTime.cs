using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudTimesCS.model;
using CrudTimesCS.controller;
using System.IO;

namespace CrudTimesCS.view
{
    public partial class TelaPesquisarTime : Form
    {
        public TelaPesquisarTime()
        {
            InitializeComponent();
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbxCodigoTime.Text == "")
                {
                    MessageBox.Show("Digite um código válido.");
                    return;
                }
                else
                {
                    Times.CodTimes = Convert.ToInt32(tbxCodigoTime.Text);
                }

                ManipulaTimes manipula = new ManipulaTimes();
                manipula.pesquisarCodigoTimes();

                    lblCodigoTimeAtual.Text = Times.CodTimes.ToString();
                    tbxFraseTimes.Text = Times.FraseTimes;
                    tbxNomeTimes.Text = Times.NomeTimes;
                    MemoryStream ms = new MemoryStream((byte[])Times.LogoTimes);
                    pictureBoxLogo.Image = Image.FromStream(ms);
                   
            }
            catch (Exception)
            {

                
            }
        }

        private void TelaPesquisarTime_Load(object sender, EventArgs e)
        {

        }

        private void btnDeletarTimes_Click(object sender, EventArgs e)
        {
            

            if (tbxCodigoTime.Text == "")
            {
                MessageBox.Show("Digite um número válido!");
                return;
            }

            var resposta = MessageBox.Show("Deseja excluir o Time " + tbxCodigoTime.Text + " ?",
                "Atenção", MessageBoxButtons.YesNo,MessageBoxIcon.Stop);

            if (resposta == DialogResult.Yes)
            {
                Times.CodTimes = Convert.ToInt32(tbxCodigoTime.Text);

                ManipulaTimes manipulaTimes = new ManipulaTimes();
                manipulaTimes.deletarTimes();
            }
     
            lblCodigoTimeAtual.Text = string.Empty;
            tbxNomeTimes.Text = string.Empty;
            tbxFraseTimes.Text = string.Empty;
            tbxCodigoTime.Text = string.Empty;
            pictureBoxLogo.Image = null;

        }

        private void btnAlterarTime_Click(object sender, EventArgs e)
        {
            if(lblCodigoTimeAtual.Text == "")
            {
                MessageBox.Show("Digite um código válido!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                
                lblCodigoTimeAtual.Text = string.Empty;
                tbxNomeTimes.Text = string.Empty;
                tbxFraseTimes.Text = string.Empty;
                tbxCodigoTime.Text = string.Empty;
                pictureBoxLogo.Image = null;
                return;
            }

            var resposta = MessageBox.Show("Deseja Fazer as alterações no time de código " + lblCodigoTimeAtual.Text + " ? ","Atenção!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(resposta == DialogResult.Yes)
            {
                Times.CodTimes = Convert.ToInt32(lblCodigoTimeAtual.Text);
                Times.NomeTimes = tbxNomeTimes.Text;
                Times.FraseTimes = tbxFraseTimes.Text;

                MemoryStream memoriaLogo = new MemoryStream();
                pictureBoxLogo.Image.Save(memoriaLogo, pictureBoxLogo.Image.RawFormat);
                Times.LogoTimes = memoriaLogo.ToArray();

                ManipulaTimes manipulaTimes = new ManipulaTimes();
                manipulaTimes.alterarTimes();

            }
        }

        private void btnAlterarImagem_Click(object sender, EventArgs e)
        {
            openFileDialogLogo.Filter = "Escolha seu logo (*.jpg; *.jpeg; *.png; ) " +
               "| *.jpg; *.jpeg; *.png;";
            if (openFileDialogLogo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxLogo.Image = Image.FromFile(openFileDialogLogo.FileName);
            }
        }
    }
}
