using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotTelegramConnect
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if(controle is MdiClient)
                {
                    controle.BackgroundImage = Properties.Resources.thumb_1920_1136049;
                    break;
                }
            }
        }

        private void mensagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormEnviarTemporizador();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mensagemSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormEnvioTexto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void imagemWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new EnvioImagemWeb();
            frm.MdiParent = this;
            frm.Show();
        }

        private void imagemLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormEnvioImagemLocal();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
