using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTables
{
    public partial class FrmBorrarFila : Form
    {
        private int rowSize;
        private FrmMain main;
        private ArrayList rows = new ArrayList();

        public FrmBorrarFila(ref int size,FrmMain frmMain)
        {
            rowSize = size;
            main = frmMain;
            InitializeComponent();

            LoadRowList();

        }

        private void LoadRowList()
        {
            for (int i = 0; i < rowSize; i++)
            {
                rows.Add("Fila " + i);
            }

            cmbFilas.DataSource = rows;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.SetIndex(-1);
            btnCancelar.DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            main.SetIndex(cmbFilas.SelectedIndex);
            btnAceptar.DialogResult = DialogResult.OK;
        }
    }
}
