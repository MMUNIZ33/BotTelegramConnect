
namespace BotTelegramConnect
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensagemSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensagemComImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensagemComEmojiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.envioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // envioToolStripMenuItem
            // 
            this.envioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mensagemSimplesToolStripMenuItem,
            this.mensagemComImagemToolStripMenuItem,
            this.mensagemComEmojiToolStripMenuItem,
            this.mensagemToolStripMenuItem});
            this.envioToolStripMenuItem.Name = "envioToolStripMenuItem";
            this.envioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.envioToolStripMenuItem.Text = "Envio";
            // 
            // mensagemSimplesToolStripMenuItem
            // 
            this.mensagemSimplesToolStripMenuItem.Name = "mensagemSimplesToolStripMenuItem";
            this.mensagemSimplesToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.mensagemSimplesToolStripMenuItem.Text = "Mensagem Simples";
            this.mensagemSimplesToolStripMenuItem.Click += new System.EventHandler(this.mensagemSimplesToolStripMenuItem_Click);
            // 
            // mensagemComImagemToolStripMenuItem
            // 
            this.mensagemComImagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagemWebToolStripMenuItem,
            this.imagemLocalToolStripMenuItem});
            this.mensagemComImagemToolStripMenuItem.Name = "mensagemComImagemToolStripMenuItem";
            this.mensagemComImagemToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.mensagemComImagemToolStripMenuItem.Text = "Mensagem com Imagem";
            // 
            // imagemWebToolStripMenuItem
            // 
            this.imagemWebToolStripMenuItem.Name = "imagemWebToolStripMenuItem";
            this.imagemWebToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imagemWebToolStripMenuItem.Text = "Imagem Web";
            this.imagemWebToolStripMenuItem.Click += new System.EventHandler(this.imagemWebToolStripMenuItem_Click);
            // 
            // imagemLocalToolStripMenuItem
            // 
            this.imagemLocalToolStripMenuItem.Name = "imagemLocalToolStripMenuItem";
            this.imagemLocalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imagemLocalToolStripMenuItem.Text = "Imagem Local";
            this.imagemLocalToolStripMenuItem.Click += new System.EventHandler(this.imagemLocalToolStripMenuItem_Click);
            // 
            // mensagemComEmojiToolStripMenuItem
            // 
            this.mensagemComEmojiToolStripMenuItem.Name = "mensagemComEmojiToolStripMenuItem";
            this.mensagemComEmojiToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.mensagemComEmojiToolStripMenuItem.Text = "Mensagem com Emoji";
            // 
            // mensagemToolStripMenuItem
            // 
            this.mensagemToolStripMenuItem.Name = "mensagemToolStripMenuItem";
            this.mensagemToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.mensagemToolStripMenuItem.Text = "Mensagem com Temporizador";
            this.mensagemToolStripMenuItem.Click += new System.EventHandler(this.mensagemToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 657);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensagemSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensagemComImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensagemComEmojiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensagemToolStripMenuItem;
    }
}

