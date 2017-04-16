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

        private void Principal_Load(object sender, EventArgs e)
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
            cmd1.MouseDown += new MouseEventHandler(MoveF_MouseDown);
            cmd1.DragEnter += new DragEventHandler(MoveF_DragEnter);
            cmd1.DragDrop += new DragEventHandler(MoveF_DragDrop);

            cmd2.MouseDown += new MouseEventHandler(MoveF_MouseDown);
            cmd2.DragEnter += new DragEventHandler(MoveF_DragEnter);
            cmd2.DragDrop += new DragEventHandler(MoveF_DragDrop);

            cmd3.MouseDown += new MouseEventHandler(MoveF_MouseDown);
            cmd3.DragEnter += new DragEventHandler(MoveF_DragEnter);
            cmd3.DragDrop += new DragEventHandler(MoveF_DragDrop);

            cmd4.MouseDown += new MouseEventHandler(MoveF_MouseDown);
            cmd4.DragEnter += new DragEventHandler(MoveF_DragEnter);
            cmd4.DragDrop += new DragEventHandler(MoveF_DragDrop);

            cmd5.MouseDown += new MouseEventHandler(MoveF_MouseDown);
            cmd5.DragEnter += new DragEventHandler(MoveF_DragEnter);
            cmd5.DragDrop += new DragEventHandler(MoveF_DragDrop);

            LoopPcBox1.MouseDown += new MouseEventHandler(MoveF_MouseDown);
            LoopPcBox1.DragEnter += new DragEventHandler(MoveF_DragEnter);
            LoopPcBox1.DragDrop += new DragEventHandler(MoveF_DragDrop);

            LoopPcBox2.MouseDown += new MouseEventHandler(MoveF_MouseDown);
            LoopPcBox2.DragEnter += new DragEventHandler(MoveF_DragEnter);
            LoopPcBox2.DragDrop += new DragEventHandler(MoveF_DragDrop);

            LoopPcBox3.MouseDown += new MouseEventHandler(MoveF_MouseDown);
            LoopPcBox3.DragEnter += new DragEventHandler(MoveF_DragEnter);
            LoopPcBox3.DragDrop += new DragEventHandler(MoveF_DragDrop);

            LoopPcBox4.MouseDown += new MouseEventHandler(MoveF_MouseDown);
            LoopPcBox4.DragEnter += new DragEventHandler(MoveF_DragEnter);
            LoopPcBox4.DragDrop += new DragEventHandler(MoveF_DragDrop);

            LoopPcBox5.MouseDown += new MouseEventHandler(MoveF_MouseDown);
            LoopPcBox5.DragEnter += new DragEventHandler(MoveF_DragEnter);
            LoopPcBox5.DragDrop += new DragEventHandler(MoveF_DragDrop);
        }

        private void Move45H()
        {
            cmd1.MouseDown += new MouseEventHandler(MoveH_MouseDown);
            cmd1.DragEnter += new DragEventHandler(MoveH_DragEnter);
            cmd1.DragDrop += new DragEventHandler(MoveH_DragDrop);

            cmd2.MouseDown += new MouseEventHandler(MoveH_MouseDown);
            cmd2.DragEnter += new DragEventHandler(MoveH_DragEnter);
            cmd2.DragDrop += new DragEventHandler(MoveH_DragDrop);

            cmd3.MouseDown += new MouseEventHandler(MoveH_MouseDown);
            cmd3.DragEnter += new DragEventHandler(MoveH_DragEnter);
            cmd3.DragDrop += new DragEventHandler(MoveH_DragDrop);

            cmd4.MouseDown += new MouseEventHandler(MoveH_MouseDown);
            cmd4.DragEnter += new DragEventHandler(MoveH_DragEnter);
            cmd4.DragDrop += new DragEventHandler(MoveH_DragDrop);

            cmd5.MouseDown += new MouseEventHandler(MoveH_MouseDown);
            cmd5.DragEnter += new DragEventHandler(MoveH_DragEnter);
            cmd5.DragDrop += new DragEventHandler(MoveH_DragDrop);

            LoopPcBox1.MouseDown += new MouseEventHandler(MoveH_MouseDown);
            LoopPcBox1.DragEnter += new DragEventHandler(MoveH_DragEnter);
            LoopPcBox1.DragDrop += new DragEventHandler(MoveH_DragDrop);

            LoopPcBox2.MouseDown += new MouseEventHandler(MoveH_MouseDown);
            LoopPcBox2.DragEnter += new DragEventHandler(MoveH_DragEnter);
            LoopPcBox2.DragDrop += new DragEventHandler(MoveH_DragDrop);

            LoopPcBox3.MouseDown += new MouseEventHandler(MoveH_MouseDown);
            LoopPcBox3.DragEnter += new DragEventHandler(MoveH_DragEnter);
            LoopPcBox3.DragDrop += new DragEventHandler(MoveH_DragDrop);

            LoopPcBox4.MouseDown += new MouseEventHandler(MoveH_MouseDown);
            LoopPcBox4.DragEnter += new DragEventHandler(MoveH_DragEnter);
            LoopPcBox4.DragDrop += new DragEventHandler(MoveH_DragDrop);

            LoopPcBox5.MouseDown += new MouseEventHandler(MoveH_MouseDown);
            LoopPcBox5.DragEnter += new DragEventHandler(MoveH_DragEnter);
            LoopPcBox5.DragDrop += new DragEventHandler(MoveH_DragDrop);
        }

        private void Move45AH()
        {
            cmd1.MouseDown += new MouseEventHandler(MoveAH_MouseDown);
            cmd1.DragEnter += new DragEventHandler(MoveAH_DragEnter);
            cmd1.DragDrop += new DragEventHandler(MoveAH_DragDrop);

            cmd2.MouseDown += new MouseEventHandler(MoveAH_MouseDown);
            cmd2.DragEnter += new DragEventHandler(MoveAH_DragEnter);
            cmd2.DragDrop += new DragEventHandler(MoveAH_DragDrop);

            cmd3.MouseDown += new MouseEventHandler(MoveAH_MouseDown);
            cmd3.DragEnter += new DragEventHandler(MoveAH_DragEnter);
            cmd3.DragDrop += new DragEventHandler(MoveAH_DragDrop);

            cmd4.MouseDown += new MouseEventHandler(MoveAH_MouseDown);
            cmd4.DragEnter += new DragEventHandler(MoveAH_DragEnter);
            cmd4.DragDrop += new DragEventHandler(MoveAH_DragDrop);

            cmd5.MouseDown += new MouseEventHandler(MoveAH_MouseDown);
            cmd5.DragEnter += new DragEventHandler(MoveAH_DragEnter);
            cmd5.DragDrop += new DragEventHandler(MoveAH_DragDrop);

            LoopPcBox1.MouseDown += new MouseEventHandler(MoveAH_MouseDown);
            LoopPcBox1.DragEnter += new DragEventHandler(MoveAH_DragEnter);
            LoopPcBox1.DragDrop += new DragEventHandler(MoveAH_DragDrop);

            LoopPcBox2.MouseDown += new MouseEventHandler(MoveAH_MouseDown);
            LoopPcBox2.DragEnter += new DragEventHandler(MoveAH_DragEnter);
            LoopPcBox2.DragDrop += new DragEventHandler(MoveAH_DragDrop);

            LoopPcBox3.MouseDown += new MouseEventHandler(MoveAH_MouseDown);
            LoopPcBox3.DragEnter += new DragEventHandler(MoveAH_DragEnter);
            LoopPcBox3.DragDrop += new DragEventHandler(MoveAH_DragDrop);

            LoopPcBox4.MouseDown += new MouseEventHandler(MoveAH_MouseDown);
            LoopPcBox4.DragEnter += new DragEventHandler(MoveAH_DragEnter);
            LoopPcBox4.DragDrop += new DragEventHandler(MoveAH_DragDrop);

            LoopPcBox5.MouseDown += new MouseEventHandler(MoveAH_MouseDown);
            LoopPcBox5.DragEnter += new DragEventHandler(MoveAH_DragEnter);
            LoopPcBox5.DragDrop += new DragEventHandler(MoveAH_DragDrop);
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
        private void MoveF_MouseDown(object sender, MouseEventArgs e)
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

        private void MoveF_DragEnter(object sender, DragEventArgs e)
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

        private void MoveF_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }


        // Movimento giro 45 Horario

        private void MoveH_MouseDown(object sender, MouseEventArgs e)
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

        private void MoveH_DragEnter(object sender, DragEventArgs e)
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

        private void MoveH_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        // Movimento giro 45 Anti-Horario

        private void MoveAH_MouseDown(object sender, MouseEventArgs e)
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

        private void MoveAH_DragEnter(object sender, DragEventArgs e)
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

        private void MoveAH_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }


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
        }

        private void LimparTxt()
        {
            TB_lit.Text = "";
        }

        private void Bt_Gerar_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Conexao_Click(object sender, EventArgs e)
        {
            btcfg.ShowDialog();
        }

        private void Bt_Enviar_Click(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ProtBT.IsOpen) ProtBT.Close();
        }
    }
}
