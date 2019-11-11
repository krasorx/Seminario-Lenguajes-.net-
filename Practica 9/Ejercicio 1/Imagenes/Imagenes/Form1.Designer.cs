namespace Imagenes
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustarALaVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.verListaDeImagenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.presentaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstbFiles = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.intervaloDePresentaciónToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.visualizacionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Archivo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirCarpetaToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // abrirCarpetaToolStripMenuItem
            // 
            this.abrirCarpetaToolStripMenuItem.Name = "abrirCarpetaToolStripMenuItem";
            this.abrirCarpetaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.abrirCarpetaToolStripMenuItem.Text = "Abrir Carpeta";
            this.abrirCarpetaToolStripMenuItem.Click += new System.EventHandler(this.abrirCarpetaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // visualizacionToolStripMenuItem
            // 
            this.visualizacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustarALaVentanaToolStripMenuItem,
            this.toolStripSeparator2,
            this.verListaDeImagenesToolStripMenuItem,
            this.toolStripSeparator3,
            this.presentaciónToolStripMenuItem,
            this.intervaloDePresentaciónToolStripMenuItem});
            this.visualizacionToolStripMenuItem.Name = "visualizacionToolStripMenuItem";
            this.visualizacionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.visualizacionToolStripMenuItem.Text = "Visualización";
            // 
            // ajustarALaVentanaToolStripMenuItem
            // 
            this.ajustarALaVentanaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ajustarALaVentanaToolStripMenuItem.Name = "ajustarALaVentanaToolStripMenuItem";
            this.ajustarALaVentanaToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.ajustarALaVentanaToolStripMenuItem.Text = "Ajustar a la ventana";
            this.ajustarALaVentanaToolStripMenuItem.Click += new System.EventHandler(this.ajustarALaVentanaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(291, 6);
            // 
            // verListaDeImagenesToolStripMenuItem
            // 
            this.verListaDeImagenesToolStripMenuItem.Checked = true;
            this.verListaDeImagenesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.verListaDeImagenesToolStripMenuItem.Name = "verListaDeImagenesToolStripMenuItem";
            this.verListaDeImagenesToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.verListaDeImagenesToolStripMenuItem.Text = "Ver lista de imágenes";
            this.verListaDeImagenesToolStripMenuItem.Click += new System.EventHandler(this.verListaDeImagenesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(291, 6);
            // 
            // presentaciónToolStripMenuItem
            // 
            this.presentaciónToolStripMenuItem.Name = "presentaciónToolStripMenuItem";
            this.presentaciónToolStripMenuItem.Size = new System.Drawing.Size(294, 22);
            this.presentaciónToolStripMenuItem.Text = "Presentación";
            this.presentaciónToolStripMenuItem.Click += new System.EventHandler(this.presentaciónToolStripMenuItem_Click);
            // 
            // pcbImage
            // 
            this.pcbImage.BackColor = System.Drawing.Color.DimGray;
            this.pcbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbImage.Location = new System.Drawing.Point(3, 3);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(379, 245);
            this.pcbImage.TabIndex = 2;
            this.pcbImage.TabStop = false;
            this.pcbImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstbFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.pcbImage);
            this.splitContainer1.Size = new System.Drawing.Size(784, 508);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 3;
            // 
            // lstbFiles
            // 
            this.lstbFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lstbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbFiles.ForeColor = System.Drawing.Color.Yellow;
            this.lstbFiles.FormattingEnabled = true;
            this.lstbFiles.Location = new System.Drawing.Point(0, 0);
            this.lstbFiles.Name = "lstbFiles";
            this.lstbFiles.Size = new System.Drawing.Size(261, 508);
            this.lstbFiles.TabIndex = 0;
            this.lstbFiles.SelectedIndexChanged += new System.EventHandler(this.lstbFiles_SelectedIndexChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 535);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 26);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "/home/documentos";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel.ForeColor = System.Drawing.Color.Lime;
            this.toolStripStatusLabel.LinkColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(204, 21);
            this.toolStripStatusLabel.Text = "/home/documentos/images";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // intervaloDePresentaciónToolStripMenuItem
            // 
            this.intervaloDePresentaciónToolStripMenuItem.Items.AddRange(new object[] {
            "Intervalo de presentación : 2 seg.",
            "Intervalo de presentación : 4 seg.",
            "Intervalo de presentación : 6 seg.",
            "Intervalo de presentación : 8 seg.",
            "Intervalo de presentación : 10 seg."});
            this.intervaloDePresentaciónToolStripMenuItem.Name = "intervaloDePresentaciónToolStripMenuItem";
            this.intervaloDePresentaciónToolStripMenuItem.Size = new System.Drawing.Size(234, 23);
            this.intervaloDePresentaciónToolStripMenuItem.Text = "Intervalo de presentación:2seg";
            this.intervaloDePresentaciónToolStripMenuItem.ToolTipText = "Seleccionar el intervalo en el que las imagenes van a pasar en el modo presentaci" +
    "on";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "Visualizador de imagenes";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirCarpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustarALaVentanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem verListaDeImagenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem presentaciónToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstbFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripComboBox intervaloDePresentaciónToolStripMenuItem;
    }
}

