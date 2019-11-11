using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace MoverLabel
{
    public partial class FrmMain : Form
    {
        DateTime t_inicial = DateTime.Now;
        
        public FrmMain()
        {
            InitializeComponent();
            timer1.Start();
            RefreshInfoLbls();
            lblPlayer.Font = new Font(Font.FontFamily, Convert.ToInt32(FontSizeSelector.Value), FontStyle.Regular);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDial.ShowDialog() == DialogResult.OK)
            {
                lblPlayer.BackColor = colorDial.Color;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = (DateTime.Now.Subtract(t_inicial)).ToString(@"hh\:mm\:ss");
        }
              private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void FontSizeSelector_ValueChanged(object sender, EventArgs e)
        {
            lblPlayer.Font = new Font(Font.FontFamily,Convert.ToInt32(FontSizeSelector.Value),FontStyle.Regular);
        }

        private void lblInfoWidthHeight_Click(object sender, EventArgs e)
        {

        }

        private void RefreshInfoLbls()
        {

            lblInfLeftTop.Text = "Left=" + lblPlayer.Left + ",Top=" + lblPlayer.Top;
            lblInfoWidthHeight.Text = "Width=" + lblPlayer.Width + ",Height=" + lblPlayer.Height;
        }

        private void MoveUpNormal()
        {
            lblPlayer.Top -= int.Parse(cmbSteps.Text.ToString());
        }
        private void MoveUpLimited()
        {
            if (lblPlayer.Top > 0)
            {
                if ((lblPlayer.Top - int.Parse(cmbSteps.Text.ToString())) > 0)
                    lblPlayer.Top -= int.Parse(cmbSteps.Text.ToString());
                else
                    lblPlayer.Top = 0;
            }
        }
        private void MoveLeftNormal()
        {
            lblPlayer.Left -= int.Parse(cmbSteps.Text.ToString());
        }
        private void MoveLeftLimited()
        {
            if (lblPlayer.Left > 0)
            {
                if (lblPlayer.Left - int.Parse(cmbSteps.Text.ToString()) > 0)
                    lblPlayer.Left -= int.Parse(cmbSteps.Text.ToString());
                else
                    lblPlayer.Left = 0;
            }
        }
        private void MoveDownNormal()
        {
            lblPlayer.Top += int.Parse(cmbSteps.Text.ToString());
        }
        private void MoveDownLimited()
        {
            if (lblPlayer.Bottom < lblPlayer.MaximumSize.Height)
            {
                if (lblPlayer.Bottom + int.Parse(cmbSteps.Text.ToString()) + lblPlayer.Height < lblPlayer.MaximumSize.Height)
                    lblPlayer.Top += int.Parse(cmbSteps.Text.ToString());
                else
                    lblPlayer.Top = lblPlayer.MaximumSize.Height - (lblPlayer.Height/2);
            }
        }
        private void MoveRightNormal()
        {
            lblPlayer.Left += int.Parse(cmbSteps.Text.ToString());
        }
        private void MoveRightLimited()
        {
            if (lblPlayer.Right < lblPlayer.MaximumSize.Width)
            {
                if (lblPlayer.Right + int.Parse(cmbSteps.Text.ToString()) < lblPlayer.MaximumSize.Width)
                    lblPlayer.Left += int.Parse(cmbSteps.Text.ToString());
                else
                    lblPlayer.Left = lblPlayer.MaximumSize.Width - lblPlayer.Width;
            }
            else
                lblPlayer.Left = lblPlayer.MaximumSize.Width - lblPlayer.Width;
        }

        private void lblPlayer_SizeChanged(object sender, EventArgs e)
        {
            RefreshInfoLbls();
        }

        private void lblPlayer_LocationChanged(object sender, EventArgs e)
        {
            RefreshInfoLbls();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            lblPlayer.Text = "Izquierda";
            //Deberia usar un delegado
            if (chbLimitMov.Checked)
            {
                MoveLeftLimited();
            }
            else
                MoveLeftNormal();

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            lblPlayer.Text = "Arriba";
            if (chbLimitMov.Checked)
            {
                MoveUpLimited();
            }
            else
                MoveUpNormal();
            
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            lblPlayer.Text = "Abajo";
            if (chbLimitMov.Checked)
            {
                MoveDownLimited();
            }
            else
                MoveDownNormal();
            
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            lblPlayer.Text = "Derecha";
            if (chbLimitMov.Checked)
            {
                MoveRightLimited();
            }
            else
                MoveRightNormal();
            
        }

        private void chbLimitMov_CheckedChanged(object sender, EventArgs e)
        {
            if (chbLimitMov.Checked)
            {
                // Actualiza la posicion si se paso de largo
                   

            }
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
