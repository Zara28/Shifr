using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Encryption
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            if(Config.rus_lang)
            {
                pictureBox4.Image = new Bitmap("Resours\\Mainrus.jpg");
                pictureBox1.Image = new Bitmap("Resours\\Create_rus.jpg");
                pictureBox2.Image = new Bitmap("Resours\\Get_rus.jpg");
                pictureBox3.Image = new Bitmap("Resours\\Editing_rus.jpg");
                pictureBox5.Image = new Bitmap("Resours\\Add_rus.jpg");
            }
            else
            {
                pictureBox4.Image = new Bitmap("Resours\\Maineng.jpg");
                pictureBox1.Image = new Bitmap("Resours\\Create.jpg");
                pictureBox2.Image = new Bitmap("Resours\\Get.jpg");
                pictureBox3.Image = new Bitmap("Resours\\Editing.jpg");
                pictureBox5.Image = new Bitmap("Resours\\Add.jpg");
            }
            Shifr.read();

            for (int i = 0; i < Config.names.Length; i++)
            {
                if (Config.names[i] == textBox_about.Name)
                {
                    textBox_about.Text = Config.names[i + 1];
                }
                if (Config.names[i] == textBox_add.Name)
                {
                    textBox_add.Text = Config.names[i + 1];
                }
                if (Config.names[i] == textBox_ed.Name)
                {
                    textBox_ed.Text = Config.names[i + 1];
                }
                if (Config.names[i] == textBox_create.Name)
                {
                    textBox_create.Text = Config.names[i + 1];
                }
                if (Config.names[i] == textBox_get.Name)
                {
                    textBox_get.Text = Config.names[i + 1];
                }
                if (Config.names[i] == tabControl.TabPages[0].Name)
                {
                    tabControl.TabPages[0].Text = Config.names[i + 1];
                }
                if (Config.names[i] == tabControl.TabPages[1].Name)
                {
                    tabControl.TabPages[1].Text = Config.names[i + 1];
                }
                if (Config.names[i] == tabControl.TabPages[2].Name)
                {
                    tabControl.TabPages[2].Text = Config.names[i + 1];
                }
                if (Config.names[i] == tabControl.TabPages[3].Name)
                {
                    tabControl.TabPages[3].Text = Config.names[i + 1];
                }
                if (Config.names[i] == tabControl.TabPages[4].Name)
                {
                    tabControl.TabPages[4].Text = Config.names[i + 1];
                }
            }
           
        }
    }
}
