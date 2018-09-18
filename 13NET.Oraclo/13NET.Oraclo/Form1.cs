using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace _13NET.Oraclo
{
    public partial class fmMain : Form
    {
        const string CHANNEL_PERGUNTAS = "perguntas";
        const string connectionString = "localhost";

        private IDatabase _db;
        private ISubscriber _sub;

        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            var client = ConnectionMultiplexer.Connect(connectionString);
            _db = client.GetDatabase();
            _sub = client.GetSubscriber();

            bwEsperaPerguntas.RunWorkerAsync();
        }

        private void bwEsperaPerguntas_DoWork(object sender, DoWorkEventArgs e)
        {
            _sub.Subscribe(CHANNEL_PERGUNTAS, (channel, message) => {

                pnStatusResposta.Invoke((MethodInvoker)delegate
                {
                    pnStatusResposta.BackColor = Color.Green;
                });

                var perguntaSplit = message.ToString().Split(':');

                Pergunta pergunta = new Pergunta { ID = perguntaSplit[0], Texto = perguntaSplit[1] };

                PrintPergunta(pergunta);
            });
        }

        private void PrintPergunta(Pergunta pergunta)
        {
            lbPerguntaID.Invoke((MethodInvoker)delegate
            {
                lbPerguntaID.Text = pergunta.ID;
            });

            lbPerguntaTexto.Invoke((MethodInvoker)delegate
            {
                lbPerguntaTexto.Text = pergunta.Texto;
            });

            TimerPergunta();
        }

        private void Responder(Resposta resposta)
        {
            _db.HashSet(resposta.IDPergunta, resposta.NomeGrupo, resposta.Texto, When.NotExists);
        }

        private async void TimerPergunta()
        {
            await Task.Delay(9000);

            LimpaUI(false);
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            var resposta = new Resposta
            {
                IDPergunta = lbPerguntaID.Text,
                NomeGrupo = "GrupoGUI",
                Texto = rtbResposta.Text
            };

            Responder(resposta);

            LimpaUI(true);
        }

        private void LimpaUI(bool texts)
        {
            if (texts)
            {
                lbPerguntaID.Invoke((MethodInvoker)delegate
                {
                    lbPerguntaID.Text = "-";
                });

                lbPerguntaTexto.Invoke((MethodInvoker)delegate
                {
                    lbPerguntaTexto.Text = "-";
                });

                rtbResposta.Invoke((MethodInvoker)delegate
                {
                    rtbResposta.Text = "";
                });
            }

            pnStatusResposta.Invoke((MethodInvoker)delegate
            {
                pnStatusResposta.BackColor = Color.Red;
            });
        }
    }
}
