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
    public struct CNewDialog
    {
        public int width;
        public int height;
        public bool ready;
    }
    public partial class Form1 : Form
    {
        PaintForm imageField = null;
        public static bool imageFieldOpened = false;
        public static ImageEditor imageEditor = new ImageEditor();
        public static CNewDialog dialRes = new CNewDialog();
        public Form1()
        {
            InitializeComponent();

            CreateField();

        }

        private void menuCreateNew_Click(object sender, EventArgs e)
        {
            createNewWindow createNewWindows = new createNewWindow();
            createNewWindows.ShowDialog();
        }

        public void CreateField()
        {
            imageField = new PaintForm();
            imageField.MdiParent = this;
            imageField.Show();
            imageFieldOpened = true;
        }

        private void viewOpen_Click(object sender, EventArgs e)
        {
            if (!imageFieldOpened)
            {
                CreateField();
            }
        }

        private void viewClose_Click(object sender, EventArgs e)
        {
            if (imageFieldOpened)
            {
                imageField.Close();
                imageFieldOpened = false;
            }
        }
    }
}
