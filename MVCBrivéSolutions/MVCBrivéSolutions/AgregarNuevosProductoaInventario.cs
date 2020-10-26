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
    public partial class AgregarNuevosProductoaInventario : Form
    {
        public AgregarNuevosProductoaInventario()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            box_agregarInventario.Visible = false;
            combo_empresa.Enabled = false;
            txt_nombreProducto.Enabled = false;
            txt_codigoBarras.Enabled = false;
            txt_cantidad.Enabled = false;
            txt_precioUnitario.Enabled = false;
            
            combo_empresa.Text = "";
            txt_nombreProducto.Text = "";
            txt_codigoBarras.Text = "";
            txt_precioUnitario.Text = "";
        }
        

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string Sucursal = combo_empresa.Text;
            String Producto = txt_nombreProducto.Text;
            string CodigoBarras = txt_codigoBarras.Text;
            string Cantidad = txt_cantidad.Text;
            string Precio = txt_precioUnitario.Text;


            if (ValidaCampos())
            {
                    string query = "insert into Inventario (RazonSocial, Nombre, CodigoBarra, Cantidad, PrecioUnitario)" +
                                             "values('" + Sucursal + "', '" + Producto + "','" + CodigoBarras + "','" + Cantidad + "', '" + Precio + "')";
                    SqlConnection cnn = new SqlConnection("server= localhost ; database=MVCBrivé ; integrated security = true");
                    SqlCommand command = new SqlCommand(query, cnn);
                    cnn.Open();
                    command.ExecuteNonQuery();
                    cnn.Close();

                    Limpiar();
                    MessageBox.Show("Se ha Guardado en el inventario correctamente", "Sistema ROA", MessageBoxButtons.OK, MessageBoxIcon.Information);         

            }

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

            if (txt_nombreProducto.Text == "")
            {
                Message = Message + "* Falta el nombre del producto  \n";
                bandera = false;
            }

            if (txt_codigoBarras.Text == "")
            {
                Message = Message + "* Falta el codigo barras  \n";
                bandera = false;
            }

            if (txt_precioUnitario.Text == "")
            {
                Message = Message + "* Falta el precio  \n";
                bandera = false;
            }

            if (bandera == false)
            {
                MessageBox.Show(Message, "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return bandera;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AgregarInventario_Load(object sender, EventArgs e)
        {

            combo_empresa.Text = "";
            txt_nombreProducto.Text = "";
            txt_codigoBarras.Text = "";
            txt_precioUnitario.Text = "";
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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
