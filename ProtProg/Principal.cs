using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ProtProg
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        // Variáveis Globais
        CfgBluetooth btcfg = new CfgBluetooth();
        public static SerialPort ProtBT = new SerialPort();
        String Comandos = null;
        String Cmd_loop = null;

        // Ao abrir a janela principal realiza as configurações. 
        private void Principal_Load(object sender, EventArgs e)
        {
            // Habilita recebimento de dados por meio de drop.
            HabilitaDrops();
            // Configura ações do drag and drop.
            ConfiguraDragsnDrop();
        }

        // Habilita drops nos blocos de comando e de loop
        private void HabilitaDrops()
        {
            HabilitaDrops_BlocoCmds();
            HabilitaDrops_BlocoLoop();
        }

        // Habilita drops no bloco de comando
        private void HabilitaDrops_BlocoCmds()
        {
            cmd1.AllowDrop = true;
            cmd2.AllowDrop = true;
            cmd3.AllowDrop = true;
            cmd4.AllowDrop = true;
            cmd5.AllowDrop = true;
        }

        // Habilita drops no bloco de loop
        private void HabilitaDrops_BlocoLoop()
        {
            LoopPcBox1.AllowDrop = true;
            LoopPcBox2.AllowDrop = true;
            LoopPcBox3.AllowDrop = true;
            LoopPcBox4.AllowDrop = true;
            LoopPcBox5.AllowDrop = true;
        }


        private void ConfiguraDragsnDrop()
        {
            MoveCmd(); // Configura Giro Horario, Giro Anti-horario e Frente para o bloco de comandos e loop.
            MoveLoop(); // Configura Loop box para box de comandos. Impede o drag and drop para o bloco de loop.
        }
        
        // Permite que Figuras sejam movidas para blocos do Comando Principal e Loop
        private void MoveCmd()
        {
            cmd1.MouseDown += new MouseEventHandler(MoveCmd_MouseDown);
            cmd1.DragEnter += new DragEventHandler(MoveCmd_DragEnter);
            cmd1.DragDrop += new DragEventHandler(MoveCmd_DragDrop);

            cmd2.MouseDown += new MouseEventHandler(MoveCmd_MouseDown);
            cmd2.DragEnter += new DragEventHandler(MoveCmd_DragEnter);
            cmd2.DragDrop += new DragEventHandler(MoveCmd_DragDrop);

            cmd3.MouseDown += new MouseEventHandler(MoveCmd_MouseDown);
            cmd3.DragEnter += new DragEventHandler(MoveCmd_DragEnter);
            cmd3.DragDrop += new DragEventHandler(MoveCmd_DragDrop);

            cmd4.MouseDown += new MouseEventHandler(MoveCmd_MouseDown);
            cmd4.DragEnter += new DragEventHandler(MoveCmd_DragEnter);
            cmd4.DragDrop += new DragEventHandler(MoveCmd_DragDrop);

            cmd5.MouseDown += new MouseEventHandler(MoveCmd_MouseDown);
            cmd5.DragEnter += new DragEventHandler(MoveCmd_DragEnter);
            cmd5.DragDrop += new DragEventHandler(MoveCmd_DragDrop);
        }

        // Permite que Figura seja movida para APENAS para blocos do Comando Principal
        private void MoveLoop()
        {
            LoopPcBox1.MouseDown += new MouseEventHandler(MoveLoop_MouseDown);
            LoopPcBox1.DragEnter += new DragEventHandler(MoveLoop_DragEnter);
            LoopPcBox1.DragDrop += new DragEventHandler(MoveLoop_DragDrop);

            LoopPcBox2.MouseDown += new MouseEventHandler(MoveLoop_MouseDown);
            LoopPcBox2.DragEnter += new DragEventHandler(MoveLoop_DragEnter);
            LoopPcBox2.DragDrop += new DragEventHandler(MoveLoop_DragDrop);

            LoopPcBox3.MouseDown += new MouseEventHandler(MoveLoop_MouseDown);
            LoopPcBox3.DragEnter += new DragEventHandler(MoveLoop_DragEnter);
            LoopPcBox3.DragDrop += new DragEventHandler(MoveLoop_DragDrop);

            LoopPcBox4.MouseDown += new MouseEventHandler(MoveLoop_MouseDown);
            LoopPcBox4.DragEnter += new DragEventHandler(MoveLoop_DragEnter);
            LoopPcBox4.DragDrop += new DragEventHandler(MoveLoop_DragDrop);

            LoopPcBox5.MouseDown += new MouseEventHandler(MoveLoop_MouseDown);
            LoopPcBox5.DragEnter += new DragEventHandler(MoveLoop_DragEnter);
            LoopPcBox5.DragDrop += new DragEventHandler(MoveLoop_DragDrop);
        }

        // Drag and Drop dos movimentos de giro e ir pra frente.
        private void MoveCmd_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                PictureBox pb = (PictureBox)sender;
                pb.Select();
                pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
            }
            catch
            {
            }
        }

        private void MoveCmd_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MoveCmd_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        // Drag and Drop do Loop box
        private void MoveLoop_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                PictureBox pb = (PictureBox)sender;
                pb.Select();
                pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
            }
            catch(Exception e5)
            {
                Console.Write(e5);
            }
        }

        private void MoveLoop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                if ((Bitmap)e.Data.GetData(DataFormats.Bitmap) != LoopPb.Image)
                {
                    e.Effect = DragDropEffects.Copy;
                }

                else
                {
                   // MessageBox.Show("Infelizmente não é possível utilizar a Loop box dentro do loop.\n(Pressione ENTER para continuar)");
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MoveLoop_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if ((Bitmap)e.Data.GetData(DataFormats.Bitmap) != LoopPb.Image)
            {
                pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            }
            else
            {
                pb.Image = null;
            }
        }
        // Fim da Configuração do Drag and Drop

       // Botão que promove a tradução literal dos simbolos do bloco de comandos.
        private void Bt_Literal_Click(object sender, EventArgs e)
        {
            String LCmd = "";
               LCmd = PegaSeq();
            TB_lit.Text = "Ok! Vamos ver se eu entendi...\n";
            for (int i = 0; i<LCmd.Length; i++)
            {
                if (LCmd[i] == 'F')
                {
                    TB_lit.Text += "Movo para FRENTE\n";
                }
                if (LCmd[i] == 'H')
                {
                    TB_lit.Text += "Giro 90 graus para DIREITA\n";
                }
                if (LCmd[i] == 'A')
                {
                    TB_lit.Text += "Giro 90 graus para ESQUERDA\n";
                }
                if (LCmd[i] == 'O')
                {
                    TB_lit.Text += "Executo o loop que vc montou\n";
                }
            }
            TB_lit.Text += "... e Fim!";
        }

        // Monta o comando do bloco de comando
        private String PegaSeq()
        {
            String temp = null;
            if (cmd1.Image == moveF.Image)
            {
                temp += "F";
            }
            else if (cmd1.Image == moveH.Image)
            {
                temp += "H";
            }
            else if (cmd1.Image == moveAH.Image)
            {
                temp += "A";
            }
            else if (cmd1.Image == LoopPb.Image)
            {
                temp += "O";
            }
            /////////////
            if (cmd2.Image == moveF.Image)
            {
                temp += "F";
            }
            else if (cmd2.Image == moveH.Image)
            {
                temp += "H";
            }
            else if (cmd2.Image == moveAH.Image)
            {
                temp += "A";
            }
            else if (cmd2.Image == LoopPb.Image)
            {
                temp += "O";
            }
            /////////////
            if (cmd3.Image == moveF.Image)
            {
                temp += "F";
            }
            else if (cmd3.Image == moveH.Image)
            {
                temp += "H";
            }
            else if (cmd3.Image == moveAH.Image)
            {
                temp += "A";
            }
            else if (cmd3.Image == LoopPb.Image)
            {
                temp += "O";
            }
            /////////////
            if (cmd4.Image == moveF.Image)
            {
                temp += "F";
            }
            else if (cmd4.Image == moveH.Image)
            {
                temp += "H";
            }
            else if (cmd4.Image == moveAH.Image)
            {
                temp += "A";
            }
            else if (cmd4.Image == LoopPb.Image)
            {
                temp += "O";
            }
            ////////////
            if (cmd5.Image == moveF.Image)
            {
                temp += "F";
            }
            else if (cmd5.Image == moveH.Image)
            {
                temp += "H";
            }
            else if (cmd5.Image == moveAH.Image)
            {
                temp += "A";
            }
            else if (cmd5.Image == LoopPb.Image)
            {
                temp += "O";
            }
            ////////////
            return (temp);
        }


        // Monta o comando do bloco de Loop
        private String PegaSeqLoop()
        {
            String temp = null;
            if (LoopPcBox1.Image == moveF.Image)
            {
                temp += "F";
            }
            else if (LoopPcBox1.Image == moveH.Image)
            {
                temp += "H";
            }
            else if (LoopPcBox1.Image == moveAH.Image)
            {
                temp += "A";
            }
            /////////////
            if (LoopPcBox2.Image == moveF.Image)
            {
                temp += "F";
            }
            else if (LoopPcBox2.Image == moveH.Image)
            {
                temp += "H";
            }
            else if (LoopPcBox2.Image == moveAH.Image)
            {
                temp += "A";
            }
            /////////////
            if (LoopPcBox3.Image == moveF.Image)
            {
                temp += "F";
            }
            else if (LoopPcBox3.Image == moveH.Image)
            {
                temp += "H";
            }
            else if (LoopPcBox3.Image == moveAH.Image)
            {
                temp += "A";
            }
            /////////////
            if (LoopPcBox4.Image == moveF.Image)
            {
                temp += "F";
            }
            else if (LoopPcBox4.Image == moveH.Image)
            {
                temp += "H";
            }
            else if (LoopPcBox4.Image == moveAH.Image)
            {
                temp += "A";
            }
            ////////////
            if (LoopPcBox5.Image == moveF.Image)
            {
                temp += "F";
            }
            else if (LoopPcBox5.Image == moveH.Image)
            {
                temp += "H";
            }
            else if (LoopPcBox5.Image == moveAH.Image)
            {
                temp += "A";
            }
            ////////////
            // Trecho faz as repetições solicitadas pelo usuário pelo numericUpDown. Se limiteloop
            // for igual 1, então o loop funcionará como um conteiner do bloco de repetição
            // que o usuário montou.
            // Ex: Para limiteloop = 1 e Bloco de Repetição = "FFHA", então loop = "FFHA".
            //  Para limiteloop = 2 e Bloco de Repetição = "FFHA", então loop = "FFHAFFHA".
            int limiteloop = Decimal.ToInt16(numericUpDown1.Value);
            for (int k = 0; k < (limiteloop-1); k++) temp += temp;
            ////////////
            return (temp);
        }

        // Botão que limpa a caixa de texto, bloco de comando e loop.
        private void Bt_Limpar_Click(object sender, EventArgs e)
        {
            LimparTxt();    //limpa caixa de texto
            LimparCmds();   //limpa bloco de comandos
            LimparLoop();   //limpa bloco de loop
        }

        //Limpa bloco de loop
        private void LimparLoop()
        {
            LoopPcBox1.Image = null;
            LoopPcBox2.Image = null;
            LoopPcBox3.Image = null;
            LoopPcBox4.Image = null;
            LoopPcBox5.Image = null;
            Cmd_loop = null;
        }

        //Limpa bloco de comandos
        private void LimparCmds()
        {
            cmd1.Image = null;
            cmd2.Image = null;
            cmd3.Image = null;
            cmd4.Image = null;
            cmd5.Image = null;
            Comandos = null;
        }

        //Limpa caixa de texto
        private void LimparTxt()
        {
            TB_lit.Text = "";
        }

        // Botão para "gerar"(salvar) comando do bloco de loop. Assim a Loop box passa a representar
        // o comando "gerado"(salvo).
        private void Bt_Gerar_Click(object sender, EventArgs e)
        {
            Cmd_loop = PegaSeqLoop(); // Armazena em Cmd_loop o comando montado no bloco de loop
            MessageBox.Show("Loop salvo!");
        }

        // Botão que abre dialog para configurar o pareamento de bluetooth e serial
        private void Bt_Conexao_Click(object sender, EventArgs e)
        {
            btcfg.ShowDialog(); // Mostra janela de configuração da conexão.
            Bt_Enviar.Enabled = btcfg.Conectar_Principal;
        }

        // Monta o comando para ser enviado pela serial
        private string ComandoMontado()
        {
            Comandos = PegaSeq(); // Pega os comandos do bloco de comando
            Comandos = Comandos.Replace("O", Cmd_loop); // Substitui O pelo comando "gerado"(salvo) do bloco de loop
            //Ex.: Cmd = FFOF CmdLoop = HHA, logo Cmd ficará FFHHAF
            Comandos = (Comandos + "$"); // Adiciona caractere de fim de comando.
            return (Comandos);
        }

        // Botão que envia comando para o Protótipo
        private void Bt_Enviar_Click(object sender, EventArgs e)
        {
            // Se comunicação serial estiver aberta...
            if (ProtBT.IsOpen)
            {
                try
                {
                    // Se o Background worker não foi disparado, então dispara.
                    if (!Bg_Worker.IsBusy)  Bg_Worker.RunWorkerAsync();
                    ProtBT.WriteLine(ComandoMontado()); //Envia comando para Prototipo
                    Bt_Enviar.Enabled = false; // Desabilita botão e só volta a habilitar quando confirmar fim da execução
                    Bt_Enviar.Text = "Ocupado"; // Altera texto do botão Enviar
                }
                // Caso haja alguma falha...
                catch(Exception e3)
                {
                    TB_lit.Text += TB_lit + "Comando não enviado.";
                    Console.WriteLine(e3);
                }
            }
            // Senão estiver aberta então...
            else
            {
                MessageBox.Show("Protótipo ainda não conectado.");
            }
        }

        // Background worker necessário para não congelar tela enquanto lê serial.
        private void Bg_Worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Executa rotina de leitura da serial continuamente e para quando background worker for cancelado.
            while (!Bg_Worker.CancellationPending)
            {
                try
                {
                    //se estiver ele lê o que está vindo dela e guarda em X.
                    string x = ProtBT.ReadLine();
                    //Se o conteúdo lido for igual a "$$", então ele reporta evento "ProgressChanged" para atualizar a textbox.
                    if (x == "$$")
                    {
                        Bg_Worker.ReportProgress(100, x); // Reporta evento "ProgressChanged" com progresso 100% e a string com "$$".
                    }
                }
                catch (Exception e6)
                {
                    Console.Write(e6);
                }
            }
        }

        // Faz o report da tarefa do background worker.
        private void Bg_Worker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            Bg_Worker.CancelAsync(); // Encerra o background worker
            TB_lit.AppendText("\nComando concluído!"); //Escreve na RichTextBox "Comando concluído!"
            Bt_Enviar.Enabled = true; // Reabilita o botão Enviar.
            Bt_Enviar.Text = "Enviar"; // Altera texto do botão Enviar
        }

        // Captura o evento de fechamento da janela e encerra comunicação serial se ela estiver aberta
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ProtBT.IsOpen) ProtBT.Close(); // Encerra conexão serial.
            if (Bg_Worker.IsBusy) Bg_Worker.CancelAsync(); //Se estiver em execução, cancela.
        }
    }
}
