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

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Imagenes
{
    public partial class FrmMain : Form
    {
        private DirectoryInfo directory;
        private string path;
        public FrmMain()
        {
           
            InitializeComponent();
            intervaloDePresentaciónToolStripMenuItem.SelectedIndex = 0;
            pcbImage.SizeMode = PictureBoxSizeMode.AutoSize;
            if (verListaDeImagenesToolStripMenuItem.Checked)
                splitContainer1.Panel1Collapsed = false;
            else
                splitContainer1.Panel1Collapsed = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void abrirCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                lstbFiles.Items.Clear();

                path = folderBrowserDialog1.SelectedPath;
                toolStripStatusLabel.Text = path;
                directory = new System.IO.DirectoryInfo(path);
                lstbFiles.Items.AddRange(directory.GetFiles("*.bmp*"));
                lstbFiles.Items.AddRange(directory.GetFiles("*.jpg*"));
                lstbFiles.Items.AddRange(directory.GetFiles("*.gif*"));
                lstbFiles.Items.AddRange(directory.GetFiles("*.png*"));
                lstbFiles.Items.AddRange(directory.GetFiles("*.ico*"));
            }
        }

        private void lstbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathRel = path + @"\" + lstbFiles.SelectedItem.ToString();
            toolStripStatusLabel.Text = pathRel;
            FileStream fs = new System.IO.FileStream(pathRel, FileMode.Open, FileAccess.Read);
            pcbImage.Image = Image.FromStream(fs);

            

            fs.Close();
            //pcbImage.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + lstbFiles.SelectedItem.ToString());
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (ajustarALaVentanaToolStripMenuItem.Checked)
            {
                pcbImage.Dock = DockStyle.Fill;
                pcbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pcbImage.Dock = DockStyle.None;
                pcbImage.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void verListaDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verListaDeImagenesToolStripMenuItem.Checked = !verListaDeImagenesToolStripMenuItem.Checked;
            if (!verListaDeImagenesToolStripMenuItem.Checked)
                splitContainer1.Panel1Collapsed = true;
            else
                splitContainer1.Panel1Collapsed = false;
                
        }

        private void ajustarALaVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajustarALaVentanaToolStripMenuItem.Checked = !ajustarALaVentanaToolStripMenuItem.Checked;
            if (ajustarALaVentanaToolStripMenuItem.Checked)
            {
                pcbImage.Dock = DockStyle.Fill;
                pcbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pcbImage.Dock = DockStyle.None;
                pcbImage.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void LoadQueue(Queue q)
        {
            
            foreach (var item in lstbFiles.Items)
            {
                q.Enqueue(item);
            }

        }

        private void presentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Queue queue = new Queue();
            int i = lstbFiles.SelectedIndex;
            LoadQueue(queue);
            FrmPresentation frmPresentation = new FrmPresentation(path,queue,i,intervaloDePresentaciónToolStripMenuItem.SelectedIndex);
            frmPresentation.Show();
        }
    }
}
