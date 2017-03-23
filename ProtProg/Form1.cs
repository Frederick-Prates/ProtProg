using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Ports;
using InTheHand.Net.Sockets;
using System.IO;
using System.Threading;


namespace ProtProg
{
    public partial class Form1 : Form
    {
        String loop;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            HabilitaDrops();
            // Habilita icone "Move Reto" para outra PicBoxes
            MoveF();
            // Habilita icone "Move 45 Horario" para outra PicBoxes
            Move45H();
            // Habilita icone "Mov 45 Anti-Horario" para outra PicBoxes
            Move45AH();

        }

        private void MoveF()
        {
            cmd1.MouseDown += new MouseEventHandler(moveF_MouseDown);
            cmd1.DragEnter += new DragEventHandler(moveF_DragEnter);
            cmd1.DragDrop += new DragEventHandler(moveF_DragDrop);

            cmd2.MouseDown += new MouseEventHandler(moveF_MouseDown);
            cmd2.DragEnter += new DragEventHandler(moveF_DragEnter);
            cmd2.DragDrop += new DragEventHandler(moveF_DragDrop);

            cmd3.MouseDown += new MouseEventHandler(moveF_MouseDown);
            cmd3.DragEnter += new DragEventHandler(moveF_DragEnter);
            cmd3.DragDrop += new DragEventHandler(moveF_DragDrop);

            cmd4.MouseDown += new MouseEventHandler(moveF_MouseDown);
            cmd4.DragEnter += new DragEventHandler(moveF_DragEnter);
            cmd4.DragDrop += new DragEventHandler(moveF_DragDrop);

            cmd5.MouseDown += new MouseEventHandler(moveF_MouseDown);
            cmd5.DragEnter += new DragEventHandler(moveF_DragEnter);
            cmd5.DragDrop += new DragEventHandler(moveF_DragDrop);

            LoopPcBox1.MouseDown += new MouseEventHandler(moveF_MouseDown);
            LoopPcBox1.DragEnter += new DragEventHandler(moveF_DragEnter);
            LoopPcBox1.DragDrop += new DragEventHandler(moveF_DragDrop);

            LoopPcBox2.MouseDown += new MouseEventHandler(moveF_MouseDown);
            LoopPcBox2.DragEnter += new DragEventHandler(moveF_DragEnter);
            LoopPcBox2.DragDrop += new DragEventHandler(moveF_DragDrop);

            LoopPcBox3.MouseDown += new MouseEventHandler(moveF_MouseDown);
            LoopPcBox3.DragEnter += new DragEventHandler(moveF_DragEnter);
            LoopPcBox3.DragDrop += new DragEventHandler(moveF_DragDrop);

            LoopPcBox4.MouseDown += new MouseEventHandler(moveF_MouseDown);
            LoopPcBox4.DragEnter += new DragEventHandler(moveF_DragEnter);
            LoopPcBox4.DragDrop += new DragEventHandler(moveF_DragDrop);

            LoopPcBox5.MouseDown += new MouseEventHandler(moveF_MouseDown);
            LoopPcBox5.DragEnter += new DragEventHandler(moveF_DragEnter);
            LoopPcBox5.DragDrop += new DragEventHandler(moveF_DragDrop);
        }

        private void Move45H()
        {
            cmd1.MouseDown += new MouseEventHandler(moveH_MouseDown);
            cmd1.DragEnter += new DragEventHandler(moveH_DragEnter);
            cmd1.DragDrop += new DragEventHandler(moveH_DragDrop);

            cmd2.MouseDown += new MouseEventHandler(moveH_MouseDown);
            cmd2.DragEnter += new DragEventHandler(moveH_DragEnter);
            cmd2.DragDrop += new DragEventHandler(moveH_DragDrop);

            cmd3.MouseDown += new MouseEventHandler(moveH_MouseDown);
            cmd3.DragEnter += new DragEventHandler(moveH_DragEnter);
            cmd3.DragDrop += new DragEventHandler(moveH_DragDrop);

            cmd4.MouseDown += new MouseEventHandler(moveH_MouseDown);
            cmd4.DragEnter += new DragEventHandler(moveH_DragEnter);
            cmd4.DragDrop += new DragEventHandler(moveH_DragDrop);

            cmd5.MouseDown += new MouseEventHandler(moveH_MouseDown);
            cmd5.DragEnter += new DragEventHandler(moveH_DragEnter);
            cmd5.DragDrop += new DragEventHandler(moveH_DragDrop);

            LoopPcBox1.MouseDown += new MouseEventHandler(moveH_MouseDown);
            LoopPcBox1.DragEnter += new DragEventHandler(moveH_DragEnter);
            LoopPcBox1.DragDrop += new DragEventHandler(moveH_DragDrop);

            LoopPcBox2.MouseDown += new MouseEventHandler(moveH_MouseDown);
            LoopPcBox2.DragEnter += new DragEventHandler(moveH_DragEnter);
            LoopPcBox2.DragDrop += new DragEventHandler(moveH_DragDrop);

            LoopPcBox3.MouseDown += new MouseEventHandler(moveH_MouseDown);
            LoopPcBox3.DragEnter += new DragEventHandler(moveH_DragEnter);
            LoopPcBox3.DragDrop += new DragEventHandler(moveH_DragDrop);

            LoopPcBox4.MouseDown += new MouseEventHandler(moveH_MouseDown);
            LoopPcBox4.DragEnter += new DragEventHandler(moveH_DragEnter);
            LoopPcBox4.DragDrop += new DragEventHandler(moveH_DragDrop);

            LoopPcBox5.MouseDown += new MouseEventHandler(moveH_MouseDown);
            LoopPcBox5.DragEnter += new DragEventHandler(moveH_DragEnter);
            LoopPcBox5.DragDrop += new DragEventHandler(moveH_DragDrop);
        }

        private void Move45AH()
        {
            cmd1.MouseDown += new MouseEventHandler(moveAH_MouseDown);
            cmd1.DragEnter += new DragEventHandler(moveAH_DragEnter);
            cmd1.DragDrop += new DragEventHandler(moveAH_DragDrop);

            cmd2.MouseDown += new MouseEventHandler(moveAH_MouseDown);
            cmd2.DragEnter += new DragEventHandler(moveAH_DragEnter);
            cmd2.DragDrop += new DragEventHandler(moveAH_DragDrop);

            cmd3.MouseDown += new MouseEventHandler(moveAH_MouseDown);
            cmd3.DragEnter += new DragEventHandler(moveAH_DragEnter);
            cmd3.DragDrop += new DragEventHandler(moveAH_DragDrop);

            cmd4.MouseDown += new MouseEventHandler(moveAH_MouseDown);
            cmd4.DragEnter += new DragEventHandler(moveAH_DragEnter);
            cmd4.DragDrop += new DragEventHandler(moveAH_DragDrop);

            cmd5.MouseDown += new MouseEventHandler(moveAH_MouseDown);
            cmd5.DragEnter += new DragEventHandler(moveAH_DragEnter);
            cmd5.DragDrop += new DragEventHandler(moveAH_DragDrop);

            LoopPcBox1.MouseDown += new MouseEventHandler(moveAH_MouseDown);
            LoopPcBox1.DragEnter += new DragEventHandler(moveAH_DragEnter);
            LoopPcBox1.DragDrop += new DragEventHandler(moveAH_DragDrop);

            LoopPcBox2.MouseDown += new MouseEventHandler(moveAH_MouseDown);
            LoopPcBox2.DragEnter += new DragEventHandler(moveAH_DragEnter);
            LoopPcBox2.DragDrop += new DragEventHandler(moveAH_DragDrop);

            LoopPcBox3.MouseDown += new MouseEventHandler(moveAH_MouseDown);
            LoopPcBox3.DragEnter += new DragEventHandler(moveAH_DragEnter);
            LoopPcBox3.DragDrop += new DragEventHandler(moveAH_DragDrop);

            LoopPcBox4.MouseDown += new MouseEventHandler(moveAH_MouseDown);
            LoopPcBox4.DragEnter += new DragEventHandler(moveAH_DragEnter);
            LoopPcBox4.DragDrop += new DragEventHandler(moveAH_DragDrop);

            LoopPcBox5.MouseDown += new MouseEventHandler(moveAH_MouseDown);
            LoopPcBox5.DragEnter += new DragEventHandler(moveAH_DragEnter);
            LoopPcBox5.DragDrop += new DragEventHandler(moveAH_DragDrop);
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

        // Movimento Reto
        private void moveF_MouseDown(object sender, MouseEventArgs e)
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

        private void moveF_DragEnter(object sender, DragEventArgs e)
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

        private void moveF_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }


        // Movimento giro 45 Horario

        private void moveH_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                PictureBox pb = (PictureBox)sender;
                pb.Select();
                pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
                pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
                pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
            }
            catch
            {
            }
        }

        private void moveH_DragEnter(object sender, DragEventArgs e)
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

        private void moveH_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        // Movimento giro 45 Anti-Horario

        private void moveAH_MouseDown(object sender, MouseEventArgs e)
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

        private void moveAH_DragEnter(object sender, DragEventArgs e)
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

        private void moveAH_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }


        private void Button1_Click(object sender, EventArgs e)
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
                temp += "A";
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
            for (int k = 0; k < limiteloop; k++) temp += temp;
            ////////////
            return (temp);
        }

        private void BtBloco_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
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
        }

        private void LimparTxt()
        {
            TB_lit.Text = "";
        }

        private void BtGerar_Click(object sender, EventArgs e)
        {
            
        }

        private void ConnectAsServer()
        {
            Thread blutoothServerThread = new Thread(new ThreadStart(ServerConnectThread));
            blutoothServerThread.Start();
        }

        Guid mUUID = new Guid("00001101-0000-1000-8000-00805F9B34FB");

        public void ServerConnectThread()
        {
            updateUI("Server iniciado, aguardando cliente.");
            BluetoothListener blueListener = new BluetoothListener(mUUID);
            blueListener.Start();
            BluetoothClient conn = blueListener.AcceptBluetoothClient();
            updateUI("Cliente conectado");

            Stream mStream = conn.GetStream();
            while (true)
            {
                try
                {
                    // mantem conectado.
                    byte[] received = new byte[1024];
                    mStream.Read(received, 0, received.Length);
                    updateUI("Recebido: " + Encoding.ASCII.GetString(received));
                    byte[] sent = Encoding.ASCII.GetBytes("Hello");
                    mStream.Write(sent, 0, sent.Length);
                }catch(IOException exception)
                {
                    updateUI("Cliente desconectado...");
                }

            }
        }

        private void updateUI(string message)
        {
            Func<int> del = delegate ()
            {
                return 0;
            };
            Invoke(del);
        }

    }
}
