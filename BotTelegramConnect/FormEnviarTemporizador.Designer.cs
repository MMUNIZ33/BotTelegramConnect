
namespace BotTelegramConnect
{
    partial class FormEnviarTemporizador
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
            this.components = new System.ComponentModel.Container();
            this.probarStatusEnvio = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listMensagens = new System.Windows.Forms.ListBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblStatusEnvio = new System.Windows.Forms.Label();
            this.timerControle = new System.Windows.Forms.Timer(this.components);
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // probarStatusEnvio
            // 
            this.probarStatusEnvio.Location = new System.Drawing.Point(25, 361);
            this.probarStatusEnvio.Name = "probarStatusEnvio";
            this.probarStatusEnvio.Size = new System.Drawing.Size(746, 36);
            this.probarStatusEnvio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mensagens:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status de Envio:";
            // 
            // listMensagens
            // 
            this.listMensagens.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMensagens.FormattingEnabled = true;
            this.listMensagens.ItemHeight = 15;
            this.listMensagens.Location = new System.Drawing.Point(25, 39);
            this.listMensagens.Name = "listMensagens";
            this.listMensagens.Size = new System.Drawing.Size(746, 259);
            this.listMensagens.TabIndex = 3;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(427, 309);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(169, 46);
            this.btnCarregar.TabIndex = 4;
            this.btnCarregar.Text = "Carregar Mensagens";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(602, 309);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(169, 46);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar Mensagens";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblStatusEnvio
            // 
            this.lblStatusEnvio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusEnvio.Location = new System.Drawing.Point(25, 407);
            this.lblStatusEnvio.Name = "lblStatusEnvio";
            this.lblStatusEnvio.Size = new System.Drawing.Size(746, 27);
            this.lblStatusEnvio.TabIndex = 6;
            this.lblStatusEnvio.Text = "Aguardando envio...";
            this.lblStatusEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(671, 13);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(100, 20);
            this.txtTempo.TabIndex = 7;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tempo:";
            // 
            // FormEnviarTemporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.lblStatusEnvio);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.listMensagens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.probarStatusEnvio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEnviarTemporizador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagem com Temporizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar probarStatusEnvio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listMensagens;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblStatusEnvio;
        private System.Windows.Forms.Timer timerControle;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label3;
    }
}