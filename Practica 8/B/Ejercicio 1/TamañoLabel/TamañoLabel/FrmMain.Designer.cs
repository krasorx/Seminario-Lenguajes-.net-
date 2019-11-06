namespace TamañoLabel
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpb1 = new System.Windows.Forms.GroupBox();
            this.lblEst = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.txbPaso = new System.Windows.Forms.TextBox();
            this.lblPaso = new System.Windows.Forms.Label();
            this.gpb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb1
            // 
            this.gpb1.BackColor = System.Drawing.Color.DarkGreen;
            this.gpb1.Controls.Add(this.lblEst);
            this.gpb1.Location = new System.Drawing.Point(3, 0);
            this.gpb1.Name = "gpb1";
            this.gpb1.Padding = new System.Windows.Forms.Padding(0);
            this.gpb1.Size = new System.Drawing.Size(500, 400);
            this.gpb1.TabIndex = 0;
            this.gpb1.TabStop = false;
            // 
            // lblEst
            // 
            this.lblEst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEst.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblEst.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblEst.Location = new System.Drawing.Point(175, 170);
            this.lblEst.Margin = new System.Windows.Forms.Padding(3);
            this.lblEst.MaximumSize = new System.Drawing.Size(500, 400);
            this.lblEst.Name = "lblEst";
            this.lblEst.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEst.Size = new System.Drawing.Size(150, 50);
            this.lblEst.TabIndex = 0;
            this.lblEst.Text = "label1";
            this.lblEst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEst.SizeChanged += new System.EventHandler(this.lblEst_SizeChanged);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(3, 406);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(32, 32);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "<--";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(79, 406);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(32, 32);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "^\r\n |";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(41, 406);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(32, 32);
            this.btnDown.TabIndex = 3;
            this.btnDown.Text = "|";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(117, 406);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(32, 32);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "-->";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // txbPaso
            // 
            this.txbPaso.BackColor = System.Drawing.SystemColors.Control;
            this.txbPaso.Location = new System.Drawing.Point(392, 409);
            this.txbPaso.Name = "txbPaso";
            this.txbPaso.Size = new System.Drawing.Size(100, 20);
            this.txbPaso.TabIndex = 5;
            this.txbPaso.Text = "10";
            // 
            // lblPaso
            // 
            this.lblPaso.AutoSize = true;
            this.lblPaso.Location = new System.Drawing.Point(355, 412);
            this.lblPaso.Name = "lblPaso";
            this.lblPaso.Size = new System.Drawing.Size(31, 13);
            this.lblPaso.TabIndex = 6;
            this.lblPaso.Text = "Paso";
            // 
            // FrmMain
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(504, 441);
            this.Controls.Add(this.lblPaso);
            this.Controls.Add(this.txbPaso);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.gpb1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.gpb1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.TextBox txbPaso;
        private System.Windows.Forms.Label lblPaso;
        private System.Windows.Forms.Label lblEst;
    }
}

