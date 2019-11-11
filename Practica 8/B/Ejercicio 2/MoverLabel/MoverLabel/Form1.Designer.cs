namespace MoverLabel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.gpbMain = new System.Windows.Forms.GroupBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.gpbTiempo = new System.Windows.Forms.GroupBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.gpbControles = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDial = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.FontSizeSelector = new System.Windows.Forms.NumericUpDown();
            this.lblInfLeftTop = new System.Windows.Forms.Label();
            this.lblInfoWidthHeight = new System.Windows.Forms.Label();
            this.cmbSteps = new System.Windows.Forms.ComboBox();
            this.lblPasoMov = new System.Windows.Forms.Label();
            this.chbLimitMov = new System.Windows.Forms.CheckBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.gpbMain.SuspendLayout();
            this.gpbTiempo.SuspendLayout();
            this.gpbControles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbMain
            // 
            this.gpbMain.BackColor = System.Drawing.SystemColors.Control;
            this.gpbMain.Controls.Add(this.lblPlayer);
            this.gpbMain.Location = new System.Drawing.Point(12, 12);
            this.gpbMain.Name = "gpbMain";
            this.gpbMain.Size = new System.Drawing.Size(350, 189);
            this.gpbMain.TabIndex = 2;
            this.gpbMain.TabStop = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayer.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblPlayer.Location = new System.Drawing.Point(147, 85);
            this.lblPlayer.MaximumSize = new System.Drawing.Size(350, 175);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(31, 15);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Start";
            this.lblPlayer.LocationChanged += new System.EventHandler(this.lblPlayer_LocationChanged);
            this.lblPlayer.SizeChanged += new System.EventHandler(this.lblPlayer_SizeChanged);
            this.lblPlayer.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpbTiempo
            // 
            this.gpbTiempo.Controls.Add(this.lblTiempo);
            this.gpbTiempo.Location = new System.Drawing.Point(12, 414);
            this.gpbTiempo.Name = "gpbTiempo";
            this.gpbTiempo.Size = new System.Drawing.Size(350, 35);
            this.gpbTiempo.TabIndex = 3;
            this.gpbTiempo.TabStop = false;
            this.gpbTiempo.Text = "Tiempo";
            // 
            // lblTiempo
            // 
            this.lblTiempo.Font = new System.Drawing.Font("Liberation Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.Blue;
            this.lblTiempo.Location = new System.Drawing.Point(0, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(350, 34);
            this.lblTiempo.TabIndex = 0;
            this.lblTiempo.Text = "0:0:0";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbControles
            // 
            this.gpbControles.Controls.Add(this.btnDown);
            this.gpbControles.Controls.Add(this.btnUp);
            this.gpbControles.Controls.Add(this.btnRight);
            this.gpbControles.Controls.Add(this.btnLeft);
            this.gpbControles.Controls.Add(this.chbLimitMov);
            this.gpbControles.Controls.Add(this.lblPasoMov);
            this.gpbControles.Controls.Add(this.cmbSteps);
            this.gpbControles.Location = new System.Drawing.Point(12, 226);
            this.gpbControles.Name = "gpbControles";
            this.gpbControles.Size = new System.Drawing.Size(160, 182);
            this.gpbControles.TabIndex = 4;
            this.gpbControles.TabStop = false;
            this.gpbControles.Text = "controles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FontSizeSelector);
            this.groupBox1.Location = new System.Drawing.Point(202, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 85);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tamaño de letra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInfoWidthHeight);
            this.groupBox2.Controls.Add(this.lblInfLeftTop);
            this.groupBox2.Location = new System.Drawing.Point(202, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 85);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // colorDial
            // 
            this.colorDial.Color = System.Drawing.Color.ForestGreen;
            // 
            // FontSizeSelector
            // 
            this.FontSizeSelector.Location = new System.Drawing.Point(20, 38);
            this.FontSizeSelector.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.FontSizeSelector.Name = "FontSizeSelector";
            this.FontSizeSelector.Size = new System.Drawing.Size(120, 20);
            this.FontSizeSelector.TabIndex = 0;
            this.FontSizeSelector.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.FontSizeSelector.ValueChanged += new System.EventHandler(this.FontSizeSelector_ValueChanged);
            // 
            // lblInfLeftTop
            // 
            this.lblInfLeftTop.Location = new System.Drawing.Point(6, 16);
            this.lblInfLeftTop.Name = "lblInfLeftTop";
            this.lblInfLeftTop.Size = new System.Drawing.Size(148, 32);
            this.lblInfLeftTop.TabIndex = 0;
            this.lblInfLeftTop.Text = "Left=100,Top=50";
            // 
            // lblInfoWidthHeight
            // 
            this.lblInfoWidthHeight.Location = new System.Drawing.Point(6, 48);
            this.lblInfoWidthHeight.Name = "lblInfoWidthHeight";
            this.lblInfoWidthHeight.Size = new System.Drawing.Size(148, 34);
            this.lblInfoWidthHeight.TabIndex = 1;
            this.lblInfoWidthHeight.Text = "Width=124,Height=99";
            this.lblInfoWidthHeight.Click += new System.EventHandler(this.lblInfoWidthHeight_Click);
            // 
            // cmbSteps
            // 
            this.cmbSteps.FormattingEnabled = true;
            this.cmbSteps.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cmbSteps.Location = new System.Drawing.Point(15, 145);
            this.cmbSteps.Name = "cmbSteps";
            this.cmbSteps.Size = new System.Drawing.Size(130, 21);
            this.cmbSteps.TabIndex = 0;
            this.cmbSteps.Text = "10";
            // 
            // lblPasoMov
            // 
            this.lblPasoMov.Location = new System.Drawing.Point(15, 129);
            this.lblPasoMov.Name = "lblPasoMov";
            this.lblPasoMov.Size = new System.Drawing.Size(130, 16);
            this.lblPasoMov.TabIndex = 1;
            this.lblPasoMov.Text = "Paso del movimiento";
            this.lblPasoMov.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chbLimitMov
            // 
            this.chbLimitMov.AutoSize = true;
            this.chbLimitMov.Location = new System.Drawing.Point(15, 19);
            this.chbLimitMov.Name = "chbLimitMov";
            this.chbLimitMov.Size = new System.Drawing.Size(112, 17);
            this.chbLimitMov.TabIndex = 2;
            this.chbLimitMov.Text = "Limitar movimiento";
            this.chbLimitMov.UseVisualStyleBackColor = true;
            this.chbLimitMov.CheckedChanged += new System.EventHandler(this.chbLimitMov_CheckedChanged);
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(26, 71);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(32, 32);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.Location = new System.Drawing.Point(102, 71);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(32, 32);
            this.btnRight.TabIndex = 4;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(64, 42);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(32, 32);
            this.btnUp.TabIndex = 5;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(64, 71);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(32, 32);
            this.btnDown.TabIndex = 6;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(374, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbControles);
            this.Controls.Add(this.gpbTiempo);
            this.Controls.Add(this.gpbMain);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Ejercicio2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.gpbMain.ResumeLayout(false);
            this.gpbMain.PerformLayout();
            this.gpbTiempo.ResumeLayout(false);
            this.gpbControles.ResumeLayout(false);
            this.gpbControles.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbMain;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.GroupBox gpbTiempo;
        private System.Windows.Forms.GroupBox gpbControles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.ColorDialog colorDial;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.NumericUpDown FontSizeSelector;
        private System.Windows.Forms.Label lblInfoWidthHeight;
        private System.Windows.Forms.Label lblInfLeftTop;
        private System.Windows.Forms.ComboBox cmbSteps;
        private System.Windows.Forms.Label lblPasoMov;
        private System.Windows.Forms.CheckBox chbLimitMov;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
    }
}

