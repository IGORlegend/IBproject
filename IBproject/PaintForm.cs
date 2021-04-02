using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBproject
{
    public partial class PaintForm : Form
    {
        public PaintForm()
        {
            InitializeComponent();
        }

        private void PaintForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.imageFieldOpened = false;
        }

        private void PaintForm_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void PaintForm_Paint(object sender, PaintEventArgs e)
        {
            pictureBox.Image = Form1.imageEditor.Image;
        }
    }
}
