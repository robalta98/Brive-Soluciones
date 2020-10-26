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
    public partial class AltasInventario : Form
    {
        public AltasInventario()
        {
            InitializeComponent();
        }

        private void AltasInventario_Load(object sender, EventArgs e)
        {
            SelectSucursal();
            SelectProducto();
        }
        private void Limpiar()
        {
            box_ventas.Visible = false;
            combo_empresa.Enabled = false;
            combo_nombreProducto.Enabled = false;
            numeric_cantidadProduc.Enabled = false;
        }
        private bool ValidaCampos()
        {
            bool bandera = true;
            String Message = "Error: \n";

            if (combo_empresa.Text == "")
            {
                Message = Message + "* Falta el nombre de la sucursal  \n";
                bandera = false;
            }
            if (combo_nombreProducto.Text == "")
            {
                Message = Message + "* Falta el nombre del producto  \n";
                bandera = false;
            }
            if (numeric_cantidadProduc.Text == "")
            {
                Message = Message + "* Falta la cantidad \n";
                bandera = false;
            }

            if (bandera == false)
            {
                MessageBox.Show(Message, "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return bandera;
        }
        private void SelectSucursal()
        {
            
            String queryq = "SELECT RazonSocial FROM Sucursales";
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

        private void SelectProducto()
        {
            string Sucursal = combo_empresa.Text;
            SqlConnection cnn = new SqlConnection("server= localhost ; database=MVCBrivé ; integrated security = true");
            string query = "select Nombre from Inventario where RazonSocial= '" + Sucursal + "'";
            SqlCommand commandq = new SqlCommand(query, cnn);
            SqlDataAdapter data = new SqlDataAdapter(commandq);
            DataTable ta = new DataTable();
            SqlDataAdapter sqlD;
            cnn.Open();
            commandq.ExecuteNonQuery();
            sqlD = new SqlDataAdapter(commandq);
            sqlD.Fill(ta);
            cnn.Close();
            combo_nombreProducto.DataSource = ta;
            combo_nombreProducto.ValueMember = "Nombre";
            combo_nombreProducto.DisplayMember = "Nombre";

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string Cantidad = numeric_cantidadProduc.Value.ToString();
            String Producto = combo_nombreProducto.Text;
            MessageBox.Show(Producto);

            if (ValidaCampos())
            {
                String query = "UPDATE Inventario SET Cantidad= Cantidad + '" + Cantidad + "' where Nombre= '" + Producto + "'";
                SqlConnection cnn = new SqlConnection("server= localhost ; database=MVCBrivé ; integrated security = true");
                SqlCommand command = new SqlCommand(query, cnn);
                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();

                Limpiar();
                MessageBox.Show("Se ha Guardado correctamente", "Sistema ROA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void combo_empresa_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
