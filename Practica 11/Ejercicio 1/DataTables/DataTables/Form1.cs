using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DataTables
{
    public partial class FrmMain : Form
    {
        DataSet dataSet = new DataSet("MyDataSet");

        BitArray txtStatus = new BitArray(3,false); //true if it has text

        private int indexRow = -1;
       

        public FrmMain()
        {

            DataTable dt = new DataTable("Personas");

            DataColumn col1 = new DataColumn("Nombre",typeof(string));
            DataColumn col2 = new DataColumn("Apellido", typeof(string));
            DataColumn col3 = new DataColumn("Edad", typeof(int));

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);

            dataSet.Tables.Add(dt);

            //Deberia primero comprobar que exista, y si no existe crearla vacia.
            dataSet.ReadXml("dataSet.xml");

            InitializeComponent();

            if (dataSet.Tables["Personas"].Rows.Count > 0)
                ToggleEraseBtns(true);

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isNumber = true;
            foreach (char c in txbEdad.Text)
            {
                if ((c < '0') || (c > '9'))     // deMorgan
                {
                    isNumber = false;
                    break;
                }
            }
            if (isNumber)
            {
                dataSet.Tables["Personas"].Rows.Add(txbNombre.Text, txbApellido.Text, Convert.ToInt32(txbEdad.Text));
                txbEdad.Text = "";
                txbNombre.Text = "";
                txbApellido.Text = "";
                btnAdd.Enabled = false;
                ToggleEraseBtns(true);
            }
            else
            {
                MessageBox.Show("La edad se debe ingresar como un numero entero.");
                txbEdad.Text = "";
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = dataSet.Tables["Personas"];
        }

        private void ChechBtn()
        {
            if (txtStatus[0] == true && txtStatus[1] == true && txtStatus[2] == true)
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
        }

        private void txbNombre_TextChanged(object sender, EventArgs e)
        {
            if (txbNombre.Text.Count() > 0)
            {
                txtStatus[0] = true;
            }
            else
                txtStatus[0] = false;
            ChechBtn();
        }

        private void txbApellido_TextChanged(object sender, EventArgs e)
        {
            if (txbApellido.Text.Count() > 0)
            {
                txtStatus[1] = true;
            }
            else
                txtStatus[1] = false;
            ChechBtn();
        }

        private void txbEdad_TextChanged(object sender, EventArgs e)
        {
            if (txbEdad.Text.Count() > 0)
            {
                txtStatus[2] = true;
            }
            else
                txtStatus[2] = false;
            ChechBtn();
        }

        private void ToggleEraseBtns(bool wha)
        {
            btnEliminarFila.Enabled = wha;
            btnEliminarFilas.Enabled = wha;
        }


        private void btnEliminarFila_Click_1(object sender, EventArgs e)
        {
            int count = dataSet.Tables["Personas"].Rows.Count;
            FrmMain frmMain = this;
            FrmBorrarFila frmBorrarFila = new FrmBorrarFila(ref count, frmMain);
            var result = frmBorrarFila.ShowDialog(); 
            
            if(result == DialogResult.OK)
            {
                if (indexRow != -1)
                {
                    dataSet.Tables["Personas"].Rows.RemoveAt(indexRow);
                    MessageBox.Show("Elemento eliminado");
                }

                if ((dataSet.Tables["Personas"].Rows.Count) == 0)
                    ToggleEraseBtns(false);
            }

            
        }

        private void btnEliminarFilas_Click(object sender, EventArgs e)
        {
            int i = dataSet.Tables["Personas"].Rows.Count;

            for (i -= 1 ; i >= 0; i--)
            {
                dataSet.Tables["Personas"].Rows.RemoveAt(i);
            }
            ToggleEraseBtns(false);
        }

        public void SetIndex(int index)
        {
            indexRow = index;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Guardar los datos de la tabla antes de salir?","Salir",MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                guardarMenuItem_Click(sender,e);
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void guardarMenuItem_Click(object sender, EventArgs e)
        {
            dataSet.WriteXml("dataset.xml");
            MessageBox.Show("Tabla guardada como XML de forma exitosa.");
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
