using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
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

        CfgBluetooth btcfg = new CfgBluetooth();
        public static SerialPort ProtBT = new SerialPort();
        String Comandos = null;
        String Cmd_loop = null;

        // Inicio Drag and Drop

        private void Principal_Load(object sender, EventArgs e)
        {
            HabilitaDrops();
            // Habilita icone "Move Reto","Move 45 Horario" e "Mov 45 Anti-Horario" para PicBoxes
            // de comando e loop.
            MoveCmd();
            // Habilita icone "Mov Loop" para PicBoxes de comando. 
            MoveLoop();
            /*
            ProtBT.DtrEnable = true;
            ProtBT.RtsEnable = true;
            */
        }


        private void HabilitaDrops()
        {
            cmd1.AllowDrop = true;
            cmd2.AllowDrop = true;
            cmd3.AllowDrop = true;
            cmd4.AllowDrop = true;
            cmd5.AllowDrop = true;
            LoopPcBox1.AllowDrop = true;
            LoopPcBox2.AllowDrop = true;
            LoopPcBox3.AllowDrop = true;
            LoopPcBox4.AllowDrop = true;
            LoopPcBox5.AllowDrop = true;
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

            LoopPcBox1.MouseDown += new MouseEventHandler(MoveCmd_MouseDown);
            LoopPcBox1.DragEnter += new DragEventHandler(MoveCmd_DragEnter);
            LoopPcBox1.DragDrop += new DragEventHandler(MoveCmd_DragDrop);

            LoopPcBox2.MouseDown += new MouseEventHandler(MoveCmd_MouseDown);
            LoopPcBox2.DragEnter += new DragEventHandler(MoveCmd_DragEnter);
            LoopPcBox2.DragDrop += new DragEventHandler(MoveCmd_DragDrop);

            LoopPcBox3.MouseDown += new MouseEventHandler(MoveCmd_MouseDown);
            LoopPcBox3.DragEnter += new DragEventHandler(MoveCmd_DragEnter);
            LoopPcBox3.DragDrop += new DragEventHandler(MoveCmd_DragDrop);

            LoopPcBox4.MouseDown += new MouseEventHandler(MoveCmd_MouseDown);
            LoopPcBox4.DragEnter += new DragEventHandler(MoveCmd_DragEnter);
            LoopPcBox4.DragDrop += new DragEventHandler(MoveCmd_DragDrop);

            LoopPcBox5.MouseDown += new MouseEventHandler(MoveCmd_MouseDown);
            LoopPcBox5.DragEnter += new DragEventHandler(MoveCmd_DragEnter);
            LoopPcBox5.DragDrop += new DragEventHandler(MoveCmd_DragDrop);
        }

        // Permite que Figura seja movida para APENAS para blocos do Comando Principal
        private void MoveLoop()
        {
            cmd1.MouseDown += new MouseEventHandler(MoveLoop_MouseDown);
            cmd1.DragEnter += new DragEventHandler(MoveLoop_DragEnter);
            cmd1.DragDrop += new DragEventHandler(MoveLoop_DragDrop);

            cmd2.MouseDown += new MouseEventHandler(MoveLoop_MouseDown);
            cmd2.DragEnter += new DragEventHandler(MoveLoop_DragEnter);
            cmd2.DragDrop += new DragEventHandler(MoveLoop_DragDrop);

            cmd3.MouseDown += new MouseEventHandler(MoveLoop_MouseDown);
            cmd3.DragEnter += new DragEventHandler(MoveLoop_DragEnter);
            cmd3.DragDrop += new DragEventHandler(MoveLoop_DragDrop);

            cmd4.MouseDown += new MouseEventHandler(MoveLoop_MouseDown);
            cmd4.DragEnter += new DragEventHandler(MoveLoop_DragEnter);
            cmd4.DragDrop += new DragEventHandler(MoveLoop_DragDrop);
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

        // Drag and Drop da figura de movimento de Loop

        private void MoveLoop_MouseDown(object sender, MouseEventArgs e)
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

        private void MoveLoop_DragEnter(object sender, DragEventArgs e)
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

        private void MoveLoop_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        // Fim Drag and Drop

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
                    TB_lit.Text += "Giro 45 graus para DIREITA\n";
                }
                if (LCmd[i] == 'A')
                {
                    TB_lit.Text += "Giro 45 graus para ESQUERDA\n";
                }
                if (LCmd[i] == 'O')
                {
                    TB_lit.Text += "Executo o loop que vc montou\n";
                }
            }
            TB_lit.Text += "... e Fim!";
        }

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

        private void Bt_Limpar_Click(object sender, EventArgs e)
        {
            LimparTxt();
            LimparCmds();
        }

        private void LimparCmds()
        {
            cmd1.Image = null;
            cmd2.Image = null;
            cmd3.Image = null;
            cmd4.Image = null;
            cmd5.Image = null;
            LoopPcBox1.Image = null;
            LoopPcBox2.Image = null;
            LoopPcBox3.Image = null;
            LoopPcBox4.Image = null;
            LoopPcBox5.Image = null;
            Comandos = null;
            Cmd_loop = null;
        }

        private void LimparTxt()
        {
            TB_lit.Text = "";
        }

        private void Bt_Gerar_Click(object sender, EventArgs e)
        {
            Cmd_loop = PegaSeqLoop();
        }

        private void Bt_Conexao_Click(object sender, EventArgs e)
        {
            btcfg.ShowDialog();
        }

        private void Bt_Enviar_Click(object sender, EventArgs e)
        {
            if (ProtBT.IsOpen)
            {
                try
                {
                    Comandos = PegaSeq();
                    Comandos = Comandos.Replace("O", Cmd_loop);
                    ProtBT.WriteLine(Comandos);
                }
                catch(Exception e3)
                {
                    TB_lit.Text += TB_lit + "Comando não enviado.";
                    Console.WriteLine(e3);
                }
            }
            else
            {
                MessageBox.Show("Protótipo ainda não conectado.");
            }
        }
       
        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ProtBT.IsOpen) ProtBT.Close();
        }
    }
}
