using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploEventos.Formulario
{
    public partial class FormMensagem : Form
    {
        public FormMensagem()
        {
            InitializeComponent();
        }

        private void btAlerta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MENSAGEM","ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MENSAGEM", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btErro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MENSAGEM", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btPergunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MENSAGEM", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
