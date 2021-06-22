using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class FormEnvioImagemLocal : Form
    {
        public FormEnvioImagemLocal()
        {
            InitializeComponent();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private Stream ToStream(Image imagem, ImageFormat formato)
        {
            var stream = new MemoryStream();
            imagem.Save(stream, formato);
            stream.Position = 0;
            return stream;
        } 
            
        private async void button1_Click(object sender, EventArgs e)
        {
            if (txtCaminhoImagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve selecionar a imagem para envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegramBot = new TelegramBotClient("1750215557:AAHpZ7e-XzidrF8JJ8B6_p1qGFBq5jr0GXA");
                

                using (var imgEnvio = Image.FromFile(txtCaminhoImagem.Text.Trim()))
                {
                    var stream = ToStream(imgEnvio, ImageFormat.Png);
                    await telegramBot.SendPhotoAsync(chatId: "1000122498", photo: stream, caption: txtMensagem3.Text.Trim(), parseMode: ParseMode.Markdown);
                }



                MessageBox.Show("Mensagem enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar mensagem! " +  ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                txtMensagem3.Text = string.Empty;
                txtCaminhoImagem.Text = string.Empty;
            }
        }

        private void btnBscImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = @"C:\Imagens\";
                ofd.Filter = "Imagens (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtCaminhoImagem.Text = ofd.FileName;
                }
            }
        }
    }
}
