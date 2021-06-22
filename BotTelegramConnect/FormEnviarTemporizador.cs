using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotTelegramConnect
{
    public partial class FormEnviarTemporizador : Form
    {
        private List<string> lstMensagens;
        private int posicaoEnvio;
        public FormEnviarTemporizador()
        {
            InitializeComponent();

            lstMensagens = new List<string>();
            btnEnviar.Enabled = false;

        }

        private void PrepararEnvio()
        {
            posicaoEnvio = 0;
            IncializarProgessBar();
            InicializarTimerControle();
        }

        private void IncializarProgessBar()
        {
            probarStatusEnvio.Value = 0;
            probarStatusEnvio.Maximum = lstMensagens.Count;
        }

        private void InicializarTimerControle()
        {
            var minutos = Convert.ToInt32(txtTempo.Text.Trim());

            timerControle.Interval = minutos * 60 * 1000;
            timerControle.Enabled = true;

            this.timerControle.Tick += new EventHandler(timerControle_Tick);
            this.BackColor = Color.Red;
        }

        private void timerControle_Tick(object sender, EventArgs e)
        {

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                btnCarregar.Enabled = false;
                var arquivoMensagens = "Mensagens.txt";

                lstMensagens.Clear();
                listMensagens.Items.Clear();

                using (StreamReader sr = new StreamReader(arquivoMensagens))
                {
                    var strLinha = string.Empty;

                    while ((strLinha = sr.ReadLine()) != null)
                    {
                        if (!strLinha.Trim().Equals(string.Empty))
                        {
                            lstMensagens.Add(strLinha.Trim());
                            listMensagens.Items.Add(strLinha.Trim());
                        }
                    }
                }

                if (lstMensagens.Count > 0)
                {
                    btnEnviar.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                btnCarregar.Enabled = true;
                btnEnviar.Enabled = false;
                lstMensagens.Clear();
                listMensagens.Items.Clear();
                MessageBox.Show("Erro ao carregar o arquivo. " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtTempo.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar o tempo. ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnEnviar.Enabled = false;

            //Verificar se encontrou alguma linha no arquivo
            if (lstMensagens.Count == 0)
            {
                MessageBox.Show("Nenhuma mensagem carregada no arquivo. ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PrepararEnvio();
            }
        }
    }
}
