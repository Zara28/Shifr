using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Encryption
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.ShowDialog();
        }

        private void Get_Click(object sender, EventArgs e)
        {
            Get gt = new Get();
            gt.ShowDialog();
        }
        
        public void Menu_Load(object sender, EventArgs e)
        {
            Shifr.raskl();
            Shifr.read();

            for (int i = 0; i < Config.names.Length; i++)
            {
                if (Config.names[i] == button_settings.Name)
                {
                    button_settings.Text = Config.names[i + 1];
                }
                if (Config.names[i] == Create.Name)
                {
                    Create.Text = Config.names[i + 1];
                }
                if (Config.names[i] == Get.Name)
                {
                    Get.Text = Config.names[i + 1];
                }
                if (Config.names[i] == Help.Name)
                {
                    Help.Text = Config.names[i + 1];
                }
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.ShowDialog();
            Menu_Load(sender, e);
        }

        private void Main_Deactivate(object sender, EventArgs e)
        {
        }
        public static void newform1(object sender, EventArgs e)
         {
            Main m = new Main();
            m.Menu_Load(sender, e);
        }
    }
}
