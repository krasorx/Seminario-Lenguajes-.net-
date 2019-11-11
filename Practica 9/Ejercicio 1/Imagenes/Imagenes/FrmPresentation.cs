using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagenes
{
    public partial class FrmPresentation : Form
    {
        private Queue imagesQ;
        private string path;
        private int index;
        private int interval;

        public FrmPresentation(string path,Queue images,int index,int intervalo)
        {
            this.imagesQ = images;
            this.path = path;
            this.index = index;
            this.interval = 2000 * (intervalo + 1);
            InitializeComponent();
            timer1.Interval = interval;
            timer1.Enabled = true;
            PrepareQ();
            pcbImage.SizeMode = PictureBoxSizeMode.Zoom;
        }


        private void PrepareQ()
        {
            for (int i = 0; i < index; i++)
            {
                imagesQ.Enqueue(imagesQ.Dequeue());
            }
        }




        private void FrmPresentation_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var q = imagesQ.Dequeue();
            
            string pathRel = path + @"\" + q.ToString();
            FileStream fs = new System.IO.FileStream(pathRel, FileMode.Open, FileAccess.Read);
            pcbImage.Image = Image.FromStream(fs);
            imagesQ.Enqueue(q);
        }
    }
}
