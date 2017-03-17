using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


 // Movimento Reto
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
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

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
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

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
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


        private void Form1_Load(object sender, EventArgs e)
        {
            move1.AllowDrop = true;
            cmd1.AllowDrop = true;
            cmd2.AllowDrop = true;
            cmd3.AllowDrop = true;
            cmd4.AllowDrop = true;
            cmd5.AllowDrop = true;


// Mov Reto
            cmd1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            cmd1.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            cmd1.DragDrop += new DragEventHandler(pictureBox1_DragDrop);

            cmd2.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            cmd2.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            cmd2.DragDrop += new DragEventHandler(pictureBox1_DragDrop);

            cmd3.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            cmd3.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            cmd3.DragDrop += new DragEventHandler(pictureBox1_DragDrop);

            cmd4.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            cmd4.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            cmd4.DragDrop += new DragEventHandler(pictureBox1_DragDrop);

            cmd5.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            cmd5.DragEnter += new DragEventHandler(pictureBox1_DragEnter);
            cmd5.DragDrop += new DragEventHandler(pictureBox1_DragDrop);


//move 45 Horario
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


            // Mov 45 Anti-Horario
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
                if (LCmd[i] == '.')
                {
                    TB_lit.Text += "Descanço...\n";
                }
            }
            TB_lit.Text += "... e Fim!";
        }

        private String PegaSeq()
        {
            String temp = null;
            if (cmd1.Image == move1.Image)
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
            /////////////
            if (cmd2.Image == move1.Image)
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
            if (cmd3.Image == move1.Image)
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
            if (cmd4.Image == move1.Image)
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
            if (cmd5.Image == move1.Image)
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
            return (temp += ".");
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
        }

        private void LimparTxt()
        {
            TB_lit.Text = "";
        }
    }
}
