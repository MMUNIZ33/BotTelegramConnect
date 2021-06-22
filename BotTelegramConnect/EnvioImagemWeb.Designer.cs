
namespace BotTelegramConnect
{
    partial class EnvioImagemWeb
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
            this.txtMensagem1 = new System.Windows.Forms.TextBox();
            this.txtUrlImagem1 = new System.Windows.Forms.TextBox();
            this.btnEnviar1 = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL da Imagem:";
            // 
            // txtMensagem1
            // 
            this.txtMensagem1.Location = new System.Drawing.Point(15, 25);
            this.txtMensagem1.Multiline = true;
            this.txtMensagem1.Name = "txtMensagem1";
            this.txtMensagem1.Size = new System.Drawing.Size(479, 94);
            this.txtMensagem1.TabIndex = 2;
            // 
            // txtUrlImagem1
            // 
            this.txtUrlImagem1.Location = new System.Drawing.Point(15, 162);
            this.txtUrlImagem1.Name = "txtUrlImagem1";
            this.txtUrlImagem1.Size = new System.Drawing.Size(479, 20);
            this.txtUrlImagem1.TabIndex = 3;
            this.txtUrlImagem1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnEnviar1
            // 
            this.btnEnviar1.Location = new System.Drawing.Point(308, 192);
            this.btnEnviar1.Name = "btnEnviar1";
            this.btnEnviar1.Size = new System.Drawing.Size(186, 45);
            this.btnEnviar1.TabIndex = 4;
            this.btnEnviar1.Text = "Enviar Mensagem";
            this.btnEnviar1.UseVisualStyleBackColor = true;
            this.btnEnviar1.Click += new System.EventHandler(this.btnEnviar1_Click);
            // 
            // EnvioImagemWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 249);
            this.Controls.Add(this.btnEnviar1);
            this.Controls.Add(this.txtUrlImagem1);
            this.Controls.Add(this.txtMensagem1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnvioImagemWeb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagem Imagem Web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMensagem1;
        private System.Windows.Forms.TextBox txtUrlImagem1;
        private System.Windows.Forms.Button btnEnviar1;
    }
}