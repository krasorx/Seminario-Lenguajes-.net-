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

namespace OrdenesClientes
{
    public partial class FrmMain : Form
    {
        private DataSet dataSet = new DataSet("ClientsData");

        public FrmMain()
        {
            DataTable clients = new DataTable("Clients");
            DataTable orders = new DataTable("Orders");


            dataSet.Tables.Add(clients);
            dataSet.Tables.Add(orders);
            LoadTables();

            InitializeComponent();
        }

        private void LoadTables()
        {
            dataSet.Tables["Clients"].Columns.Add("idCliente",typeof(int));
            dataSet.Tables["Clients"].Columns.Add("Apellido", typeof(string));
            dataSet.Tables["Clients"].Columns.Add("Nombre", typeof(string));
            dataSet.Tables["Clients"].Columns.Add("Direccion", typeof(string));
            dataSet.Tables["Clients"].Columns.Add("telefono", typeof(int));

            dataSet.Tables["Orders"].Columns.Add("idCliente", typeof(int));
            dataSet.Tables["Orders"].Columns.Add("idOrder", typeof(int));
            dataSet.Tables["Orders"].Columns.Add("Fecha", typeof(DateTime));
            dataSet.Tables["Orders"].Columns.Add("Detalle", typeof(string));

            dataSet.Tables["Clients"].Rows.Add(10,"Joseph","Joestar","calle 25 333",155482235);
            dataSet.Tables["Clients"].Rows.Add(11, "Jotaro", "Kujo", "calle 2 555", 15548545);
            dataSet.Tables["Clients"].Rows.Add(12, "Giorno", "Giovanna", "calle 4 444", 155412235);
            dataSet.Tables["Clients"].Rows.Add(13, "Joline", "Kujo", "calle 3 666", 155482835);
            dataSet.Tables["Clients"].Rows.Add(14, "Josuke", "Higashigata", "calle 1 234", 155482995);

            dataSet.Tables["Orders"].Rows.Add(10,1,System.DateTime.Today.Subtract(TimeSpan.FromHours(5000)),"Hamon");
            dataSet.Tables["Orders"].Rows.Add(11, 2, System.DateTime.Today.Subtract(TimeSpan.FromHours(6000)), "Dolphin");
            dataSet.Tables["Orders"].Rows.Add(12, 3, System.DateTime.Today.Subtract(TimeSpan.FromHours(10000)), "A dream");
            dataSet.Tables["Orders"].Rows.Add(13, 4, System.DateTime.Today.Subtract(TimeSpan.FromHours(50000)), "String");

            DataColumn colPadre = dataSet.Tables["Clients"].Columns["idCliente"];
            DataColumn colHija = dataSet.Tables["Orders"].Columns["idCliente"];

            DataRelation relation = new DataRelation("relacion",colPadre,colHija);
            dataSet.Relations.Add(relation);

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            bdsClientsOrders.DataSource = dataSet.Tables["Clients"];
            dgvClients.DataSource = bdsClientsOrders.DataSource;
            dgvOrders.DataSource = bdsClientsOrders.DataSource;
            dgvOrders.DataMember = "relacion";
        }
    }
}
