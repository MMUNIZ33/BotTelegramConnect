using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class EnvioImagemWeb : Form
    {
        public EnvioImagemWeb()
        {
            InitializeComponent();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnEnviar1_Click(object sender, EventArgs e)
        {
            if (txtUrlImagem1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe a URL da imagem para envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                var telegramBot = new TelegramBotClient("1750215557:AAHpZ7e-XzidrF8JJ8B6_p1qGFBq5jr0GXA");
                var imagemRequest = WebRequest.Create(txtUrlImagem1.Text.Trim());

                using (var imagemResponse = imagemRequest.GetResponse())
                {
                    var stream = imagemResponse.GetResponseStream();
                    await telegramBot.SendPhotoAsync(chatId: "1000122498", photo: stream, caption: txtMensagem1.Text.Trim(), parseMode: ParseMode.Markdown);
                } 

                
                
                MessageBox.Show("Mensagem enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar mensagem!" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                txtMensagem1.Text = string.Empty;
                txtUrlImagem1.Text = string.Empty;
            }
        }
    }
}
