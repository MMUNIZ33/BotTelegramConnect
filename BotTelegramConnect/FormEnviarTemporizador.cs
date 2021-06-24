using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class FormEnviarTemporizador : Form
    {
        private List<string> lstMensagens;
        private int posicaoEnvio;
        public FormEnviarTemporizador()
        {
            InitializeComponent();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

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

        private void PararTimerControle()
        {
            timerControle.Enabled = false;
            timerControle.Tick -= new EventHandler(timerControle_Tick);
            this.BackColor = SystemColors.Control;
            btnEnviar.Enabled = true;
        }

        private void AtualizarProgressoEnvio()
        {
            probarStatusEnvio.Value++;
            lblStatusEnvio.Text = string.Format("Enviando {0} de {1}...", posicaoEnvio, lstMensagens.Count);
        }

        private async void timerControle_Tick(object sender, EventArgs e)
        {
            try
            {
                var telegramBot = new TelegramBotClient("1750215557:AAHpZ7e-XzidrF8JJ8B6_p1qGFBq5jr0GXA");
                var mensagemAtual = lstMensagens[posicaoEnvio];

                await telegramBot.SendTextMessageAsync(chatId: "1000122498", text: mensagemAtual, parseMode: ParseMode.Markdown);

                posicaoEnvio++;

                // Atualizar progresso de envio
                AtualizarProgressoEnvio();
                if (posicaoEnvio == lstMensagens.Count)
                {
                    PararTimerControle();
                }

            }
            catch (Exception ex)
            {
                PararTimerControle();
                MessageBox.Show("Erro ao enviar mensagem! " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
