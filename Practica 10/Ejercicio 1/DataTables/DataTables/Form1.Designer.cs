namespace DataTables
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
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.gpbNewRow = new System.Windows.Forms.GroupBox();
            this.txbEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEliminarFila = new System.Windows.Forms.Button();
            this.btnEliminarFilas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.gpbNewRow.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(313, 12);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(347, 246);
            this.dgvPersonas.TabIndex = 0;
            this.dgvPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gpbNewRow
            // 
            this.gpbNewRow.Controls.Add(this.txbEdad);
            this.gpbNewRow.Controls.Add(this.label3);
            this.gpbNewRow.Controls.Add(this.txbApellido);
            this.gpbNewRow.Controls.Add(this.label2);
            this.gpbNewRow.Controls.Add(this.txbNombre);
            this.gpbNewRow.Controls.Add(this.label1);
            this.gpbNewRow.ForeColor = System.Drawing.Color.FloralWhite;
            this.gpbNewRow.Location = new System.Drawing.Point(12, 40);
            this.gpbNewRow.Name = "gpbNewRow";
            this.gpbNewRow.Size = new System.Drawing.Size(200, 118);
            this.gpbNewRow.TabIndex = 1;
            this.gpbNewRow.TabStop = false;
            this.gpbNewRow.Text = "Nueva fila";
            // 
            // txbEdad
            // 
            this.txbEdad.BackColor = System.Drawing.Color.DarkGray;
            this.txbEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEdad.Location = new System.Drawing.Point(47, 76);
            this.txbEdad.Name = "txbEdad";
            this.txbEdad.Size = new System.Drawing.Size(55, 20);
            this.txbEdad.TabIndex = 8;
            this.txbEdad.TextChanged += new System.EventHandler(this.txbEdad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Edad";
            // 
            // txbApellido
            // 
            this.txbApellido.BackColor = System.Drawing.Color.DarkGray;
            this.txbApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbApellido.Location = new System.Drawing.Point(47, 50);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(147, 20);
            this.txbApellido.TabIndex = 6;
            this.txbApellido.TextChanged += new System.EventHandler(this.txbApellido_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // txbNombre
            // 
            this.txbNombre.BackColor = System.Drawing.Color.DarkGray;
            this.txbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNombre.Location = new System.Drawing.Point(47, 23);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(147, 20);
            this.txbNombre.TabIndex = 4;
            this.txbNombre.TextChanged += new System.EventHandler(this.txbNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Aqua;
            this.btnAdd.Location = new System.Drawing.Point(218, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar a -->";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEliminarFila
            // 
            this.btnEliminarFila.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarFila.Enabled = false;
            this.btnEliminarFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFila.ForeColor = System.Drawing.Color.Aqua;
            this.btnEliminarFila.Location = new System.Drawing.Point(313, 264);
            this.btnEliminarFila.Name = "btnEliminarFila";
            this.btnEliminarFila.Size = new System.Drawing.Size(97, 23);
            this.btnEliminarFila.TabIndex = 3;
            this.btnEliminarFila.Text = "Borrar fila...";
            this.btnEliminarFila.UseVisualStyleBackColor = false;
            this.btnEliminarFila.Click += new System.EventHandler(this.btnEliminarFila_Click_1);
            // 
            // btnEliminarFilas
            // 
            this.btnEliminarFilas.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarFilas.Enabled = false;
            this.btnEliminarFilas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFilas.ForeColor = System.Drawing.Color.Aqua;
            this.btnEliminarFilas.Location = new System.Drawing.Point(522, 264);
            this.btnEliminarFilas.Name = "btnEliminarFilas";
            this.btnEliminarFilas.Size = new System.Drawing.Size(138, 23);
            this.btnEliminarFilas.TabIndex = 4;
            this.btnEliminarFilas.Text = "Borrar todas las filas";
            this.btnEliminarFilas.UseVisualStyleBackColor = false;
            this.btnEliminarFilas.Click += new System.EventHandler(this.btnEliminarFilas_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(672, 323);
            this.Controls.Add(this.btnEliminarFilas);
            this.Controls.Add(this.btnEliminarFila);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gpbNewRow);
            this.Controls.Add(this.dgvPersonas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "DataTable";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.gpbNewRow.ResumeLayout(false);
            this.gpbNewRow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.GroupBox gpbNewRow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarFila;
        private System.Windows.Forms.Button btnEliminarFilas;
    }
}

