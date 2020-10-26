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
    public partial class AltaSucursales : Form
    {
        
        public AltaSucursales()
        {
            InitializeComponent();
        }

        private void AltaSucursales_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            box_altaSucursales.Visible = false;
            txt_sucursal.Enabled = false;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string RazonSocial = txt_sucursal.Text;

            if(ValidaCampos())
            {
                String query = "INSERT INTO Sucursales (RazonSocial) values('" + RazonSocial + "')";
                SqlConnection cnn = new SqlConnection("server= localhost; database=MVCBrivé; integrated security = true");
                SqlCommand command = new SqlCommand(query, cnn);                
                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();

                Limpiar();
                MessageBox.Show("Se ha Guardado correctamente", "Sistema ROA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private bool ValidaCampos()
        {
            bool bandera = true;
            String Message = "Error: \n";

            if (txt_sucursal.Text == "")
            {
                Message = Message + "* Falta el nombre de la sucursal  \n";
                bandera = false;
            }

            if (bandera == false)
            {
                MessageBox.Show(Message, "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return bandera;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
