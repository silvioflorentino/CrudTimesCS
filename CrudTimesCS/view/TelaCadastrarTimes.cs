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

namespace CrudTimesCS.view
{
    public partial class TelaCadastrarTimes : Form
    {
        public TelaCadastrarTimes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fecharCadastro();
        }

        private void btnCadastrarTimes_Click(object sender, EventArgs e)
        {

            if (tbxNomeTimes.Text == "" || tbxFraseTimes.Text == "")
            {
                MessageBox.Show("Digite Todas as informações","Atenção",
                    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            Times.NomeTimes = tbxNomeTimes.Text;
            Times.FraseTimes = tbxFraseTimes.Text;
            Times.LogoTimes = "c:/"; // aqui vai existir alterações.

            ManipulaTimes manipulaTimes = new ManipulaTimes();
            manipulaTimes.cadastroTimes();

            if (Times.Retorno == "Sim")
            {
                limparTela();
                return;
            }
            else
            {
                fecharCadastro();
                return;
            }

        }
        public void abrirCadastro()
        {
            this.ShowDialog();
        }
        public void fecharCadastro()
        {
            this.Close();
        }

        public void limparTela()
        {
            foreach(Control ctl in this.Controls)
            {
                if(ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }
         
        }

        private void TelaCadastrarTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
               fecharCadastro();
            }
            
        }
    }
}
