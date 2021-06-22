
namespace BotTelegramConnect
{
    partial class FormEnvioImagemLocal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensagem3 = new System.Windows.Forms.TextBox();
            this.txtCaminhoImagem = new System.Windows.Forms.TextBox();
            this.btnEnviar3 = new System.Windows.Forms.Button();
            this.btnBscImagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensagem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Caminho da Imagem:";
            // 
            // txtMensagem3
            // 
            this.txtMensagem3.Location = new System.Drawing.Point(12, 25);
            this.txtMensagem3.Multiline = true;
            this.txtMensagem3.Name = "txtMensagem3";
            this.txtMensagem3.Size = new System.Drawing.Size(482, 94);
            this.txtMensagem3.TabIndex = 2;
            // 
            // txtCaminhoImagem
            // 
            this.txtCaminhoImagem.Enabled = false;
            this.txtCaminhoImagem.Location = new System.Drawing.Point(12, 147);
            this.txtCaminhoImagem.Name = "txtCaminhoImagem";
            this.txtCaminhoImagem.Size = new System.Drawing.Size(422, 20);
            this.txtCaminhoImagem.TabIndex = 3;
            // 
            // btnEnviar3
            // 
            this.btnEnviar3.Location = new System.Drawing.Point(308, 192);
            this.btnEnviar3.Name = "btnEnviar3";
            this.btnEnviar3.Size = new System.Drawing.Size(186, 45);
            this.btnEnviar3.TabIndex = 4;
            this.btnEnviar3.Text = "Enviar Mensagem";
            this.btnEnviar3.UseVisualStyleBackColor = true;
            this.btnEnviar3.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBscImagem
            // 
            this.btnBscImagem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBscImagem.Location = new System.Drawing.Point(440, 147);
            this.btnBscImagem.Name = "btnBscImagem";
            this.btnBscImagem.Size = new System.Drawing.Size(54, 20);
            this.btnBscImagem.TabIndex = 5;
            this.btnBscImagem.Text = "...";
            this.btnBscImagem.UseVisualStyleBackColor = true;
            this.btnBscImagem.Click += new System.EventHandler(this.btnBscImagem_Click);
            // 
            // FormEnvioImagemLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 249);
            this.Controls.Add(this.btnBscImagem);
            this.Controls.Add(this.btnEnviar3);
            this.Controls.Add(this.txtCaminhoImagem);
            this.Controls.Add(this.txtMensagem3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEnvioImagemLocal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagem Imagem Local";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMensagem3;
        private System.Windows.Forms.TextBox txtCaminhoImagem;
        private System.Windows.Forms.Button btnEnviar3;
        private System.Windows.Forms.Button btnBscImagem;
    }
}