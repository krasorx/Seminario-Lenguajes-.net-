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

namespace TamañoLabel
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            ActualizarTextoLbl();
        }


        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lblEst.Left > 0)
            {
                if (lblEst.Left - int.Parse(txbPaso.Text.ToString()) < 0)
                {
                    lblEst.Width += lblEst.Left;
                    lblEst.Left = 0;
                }
                else
                {
                    lblEst.Left -= int.Parse(txbPaso.Text.ToString());
                    lblEst.Width += int.Parse(txbPaso.Text.ToString());
                }
            }
            else
                btnLeft.Enabled = false;
            
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lblEst.Bottom < lblEst.MaximumSize.Height)
            {
                if (lblEst.Bottom + int.Parse(txbPaso.Text.ToString()) > lblEst.MaximumSize.Height)
                {
                    lblEst.Height += (lblEst.MaximumSize.Height - lblEst.Bottom);
                }
                else
                {
                    lblEst.Height += int.Parse(txbPaso.Text.ToString());
                }
            }
            else
                btnDown.Enabled = false;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {

            if (lblEst.Top > 0)
            {
                if (lblEst.Top + int.Parse(txbPaso.Text.ToString()) < 0 )
                {
                    lblEst.Height += lblEst.Top;
                    lblEst.Top = 0;
                }
                else
                {
                    lblEst.Top -= int.Parse(txbPaso.Text.ToString());
                    lblEst.Height += int.Parse(txbPaso.Text.ToString());
                }
            }
            else
                btnUp.Enabled = false;

            //lblEst.Top -= int.Parse(txbPaso.Text.ToString());
            //lblEst.Height += int.Parse(txbPaso.Text.ToString());
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lblEst.Right < lblEst.MaximumSize.Width)
            {
                if (lblEst.Right + int.Parse(txbPaso.Text.ToString()) > lblEst.MaximumSize.Width)
                {
                    lblEst.Width += lblEst.MaximumSize.Width - lblEst.Right;  
                }
                else
                {
                    lblEst.Width += int.Parse(txbPaso.Text.ToString());
                }
            }
            else
                btnRight.Enabled = false;
        }

        private void lblEst_SizeChanged(object sender, EventArgs e)
        {
            ActualizarTextoLbl();
        }

        private void ActualizarTextoLbl()
        {
            lblEst.Text = "Label de " + lblEst.Size.Width +
                          " pixeles de ancho y " + lblEst.Size.Height + " pixeles de alto";
        }

    }
}
