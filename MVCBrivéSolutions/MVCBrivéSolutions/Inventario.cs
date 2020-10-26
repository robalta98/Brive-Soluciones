using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MVCBrivéSolutions
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            SelectSucursal();
        }

        private void SelectSucursal()
        {
            String queryq = "SELECT RazonSocial FROM Sucursales;";
            SqlConnection cnn = new SqlConnection("server= localhost ; database=MVCBrivé ; integrated security = true");
            SqlCommand commandq = new SqlCommand(queryq, cnn);
            DataTable ta = new DataTable();
            SqlDataAdapter sqlD;
            cnn.Open();
            commandq.ExecuteNonQuery();
            sqlD = new SqlDataAdapter(commandq);
            sqlD.Fill(ta);
            cnn.Close();
            combo_empresa.DataSource = ta;
            combo_empresa.ValueMember = "RazonSocial";
            combo_empresa.DisplayMember = "RazonSocial";
        }

        private void combo_empresa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private bool ValidaCampos()
        {
            bool bandera = true;
            String Message = "Error: \n";


            if (combo_empresa.Text == "")
            {
                Message = Message + "* Falta seleccionar la sucursal  \n";
                bandera = false;
            }
            if (bandera == false)
            {
                MessageBox.Show(Message, "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return bandera;
        }

        private void box_inventario_Enter(object sender, EventArgs e)
        {
            
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            string Sucursal = combo_empresa.Text;
            if (ValidaCampos())
            {
                SqlConnection cnn = new SqlConnection("server= localhost ; database=MVCBrivé ; integrated security = true");
                string query = "select * from Inventario where RazonSocial= '" + Sucursal + "'";
                SqlCommand command = new SqlCommand(query, cnn);
                SqlDataAdapter data = new SqlDataAdapter(command);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView_Inventario.DataSource = tabla;

            }
        }
    }
}
