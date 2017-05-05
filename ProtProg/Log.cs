using System;
using System.IO;
using System.Windows.Forms;

namespace ProtProg
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
            CriaDir();
        }

        // Variaveis de log
        public FileStream Arq;
        public StreamWriter sw;
        private bool ativo;


        public bool EstadoLog { get => ativo; set => ativo = value; }

        private void CriaDir()
        {
            try
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"LogAcoes\");
            }
            catch(Exception l1)
            {
                Console.WriteLine(l1);
            }
        }

        private void Bt_ComecarLog_Click(object sender, EventArgs e)
        {
            if (Bt_ComecarLog.Text == "Novo")
            {
                string NomeArquivo = @"LogAcoes\log_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".txt";
                string Caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, NomeArquivo);
                Arq = File.Create(Caminho);
                sw = new StreamWriter(Arq);
                Tb_Arquivos.Text = Tb_Arquivos.Text + NomeArquivo;
                Lb_LogAtual.Text = NomeArquivo;
                EstadoLog = true;
                Bt_ComecarLog.Text = "Parar";
            }
            else
            {
                sw.Close();
                EstadoLog = false;
                Tb_Arquivos.Text = Tb_Arquivos.Text + " - Log salvo.\n";
                Bt_ComecarLog.Text = "Novo";
            }
        }

        private void Bt_Dir_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + @"LogAcoes\");
            }
            catch(Exception l2)
            {
                Console.WriteLine(l2);
            }
        }

        private void Bt_CancelarLog_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
