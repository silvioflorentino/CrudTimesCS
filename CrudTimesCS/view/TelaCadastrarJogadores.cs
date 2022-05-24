using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudTimesCS.view
{
    public partial class TelaCadastrarJogadores : Form
    {
        public TelaCadastrarJogadores()
        {
            InitializeComponent();
        }

        private void btnJogadores_Click(object sender, EventArgs e)
        {
            if (tbxNomeJogadores.Text == "" || tbxEmailJogadores.Text == "")
            {
                MessageBox.Show("Digite Todas as informações", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
