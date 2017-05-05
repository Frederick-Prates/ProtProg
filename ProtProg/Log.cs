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

        // Instancia para verificar de Log está ativo ou não.
        public bool EstadoLog { get => ativo; set => ativo = value; }

        // Cria diretório se ele não existe
        private void CriaDir()
        {
            try
            {
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"LogAcoes\"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"LogAcoes\");
                }
            }
            catch(Exception l1)
            {
                Console.WriteLine(l1);
            }
        }

        // Ativa/Desativa log do ProtProg
        private void Bt_ComecarLog_Click(object sender, EventArgs e)
        {
            if (Bt_ComecarLog.Text == "Novo")
            {
                // Define nome do arquivo como "log_100220112300.txt" em que os numeros representam a data e a hora
                // em que foi criado.
                string NomeArquivo = @"LogAcoes\log_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".txt";
                // Junta o nome do arquivo com o caminho do diretório atual para gerar o caminho para o arquivo
                string Caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, NomeArquivo);
                // Cria o arquivo no caminho descrito
                Arq = File.Create(Caminho);
                // Cria um tipo de escrita em arquivo para o arquivo de log.
                sw = new StreamWriter(Arq);
                // Adiciona na text box o arquivo de log gerado. 
                Tb_Arquivos.Text = Tb_Arquivos.Text + NomeArquivo;
                // Altera label para mostrar o arquivo atual.
                Lb_LogAtual.Text = NomeArquivo;
                // Muda Estado do log para ativo.
                EstadoLog = true;
                // Altera texto do botão "Novo" para "Parar".
                Bt_ComecarLog.Text = "Parar";
            }
            else
            {
                // Encerra escritor e fecha o arquivo.
                sw.Close();
                // Altera Estado do log para desativado
                EstadoLog = false;
                // Avisa pela text box que o arquivo foi salvo.
                Tb_Arquivos.Text = Tb_Arquivos.Text + " - Log salvo.\n";
                // Altera texto do botão "Parar" para "Novo".
                Bt_ComecarLog.Text = "Novo";
            }
        }

        // Botão que abre diretório dos logs
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

        // Botão que esconde janela de Log de Ações
        private void Bt_CancelarLog_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
