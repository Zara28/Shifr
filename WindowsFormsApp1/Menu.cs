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
    public partial class Menu : Form
    {
        public Menu()
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

        private void Menu_Load(object sender, EventArgs e)
        {
            Shifr.raskl();
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
        }
    }
}
