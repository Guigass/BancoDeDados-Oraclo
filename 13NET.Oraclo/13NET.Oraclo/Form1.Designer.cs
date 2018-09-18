namespace _13NET.Oraclo
{
    partial class fmMain
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
            this.lbPerguntaID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPerguntaTexto = new System.Windows.Forms.Label();
            this.pnStatusResposta = new System.Windows.Forms.Panel();
            this.rtbResposta = new System.Windows.Forms.RichTextBox();
            this.btnResponder = new System.Windows.Forms.Button();
            this.bwEsperaPerguntas = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pergunta:";
            // 
            // lbPerguntaID
            // 
            this.lbPerguntaID.AutoSize = true;
            this.lbPerguntaID.Location = new System.Drawing.Point(13, 30);
            this.lbPerguntaID.Name = "lbPerguntaID";
            this.lbPerguntaID.Size = new System.Drawing.Size(10, 13);
            this.lbPerguntaID.TabIndex = 1;
            this.lbPerguntaID.Text = "-";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(0, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(443, 2);
            this.label12.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "-";
            // 
            // lbPerguntaTexto
            // 
            this.lbPerguntaTexto.AutoSize = true;
            this.lbPerguntaTexto.Location = new System.Drawing.Point(48, 30);
            this.lbPerguntaTexto.Name = "lbPerguntaTexto";
            this.lbPerguntaTexto.Size = new System.Drawing.Size(10, 13);
            this.lbPerguntaTexto.TabIndex = 36;
            this.lbPerguntaTexto.Text = "-";
            // 
            // pnStatusResposta
            // 
            this.pnStatusResposta.BackColor = System.Drawing.Color.Red;
            this.pnStatusResposta.Location = new System.Drawing.Point(370, 7);
            this.pnStatusResposta.Name = "pnStatusResposta";
            this.pnStatusResposta.Size = new System.Drawing.Size(66, 45);
            this.pnStatusResposta.TabIndex = 37;
            // 
            // rtbResposta
            // 
            this.rtbResposta.Location = new System.Drawing.Point(7, 67);
            this.rtbResposta.Name = "rtbResposta";
            this.rtbResposta.Size = new System.Drawing.Size(357, 109);
            this.rtbResposta.TabIndex = 38;
            this.rtbResposta.Text = "";
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(370, 67);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(66, 106);
            this.btnResponder.TabIndex = 39;
            this.btnResponder.Text = "Ok";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // bwEsperaPerguntas
            // 
            this.bwEsperaPerguntas.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwEsperaPerguntas_DoWork);
            // 
            // fmMain
            // 
            this.AcceptButton = this.btnResponder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 185);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.rtbResposta);
            this.Controls.Add(this.pnStatusResposta);
            this.Controls.Add(this.lbPerguntaTexto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbPerguntaID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fmMain";
            this.Text = "13NET - Oraclo Respostas";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPerguntaID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPerguntaTexto;
        private System.Windows.Forms.Panel pnStatusResposta;
        private System.Windows.Forms.RichTextBox rtbResposta;
        private System.Windows.Forms.Button btnResponder;
        private System.ComponentModel.BackgroundWorker bwEsperaPerguntas;
    }
}

