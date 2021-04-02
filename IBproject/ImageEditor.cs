using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace IBproject
{
    public class ImageEditor
    {
        Bitmap image = null;
        Color brushColor = Color.White;
        int brushRadius;

        public Bitmap Image { get => image; }
        public int BrushRadius { get => brushRadius; }
        public Color BrushColor { get => brushColor; }
        public ImageEditor()
        {
            image = new Bitmap(1024, 1024);
            for(int i = 0; i<1024; i++)
            {
                for (int j = 0; j < 1024; j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(255, 255, 255, 255));
                }
            }
            brushRadius = 15;
        }
        public ImageEditor(int width, int height)
        {
            image = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(255, 255, 255, 255));
                }
            }
            brushRadius = 15;
        }
        
    }
}
