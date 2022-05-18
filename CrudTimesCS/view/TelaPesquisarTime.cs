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
    }
}
