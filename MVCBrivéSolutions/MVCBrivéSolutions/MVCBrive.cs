using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCBrivéSolutions
{
    public partial class MVCBrive : Form
    {
        public MVCBrive()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new Inventario();
            formulario.Show();
        }

        private void btn_altaSucursales_Click(object sender, EventArgs e)
        {
            Form formulario = new AltaSucursales();
            formulario.Show();
        }

        private void btn_agregarInventario_Click(object sender, EventArgs e)
        {
            Form formulario = new AgregarNuevosProductoaInventario();
            formulario.Show();
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            Form formulario = new Ventas();
            formulario.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_altas_Click(object sender, EventArgs e)
        {
            Form formulario = new AltasInventario();
            formulario.Show();
        }
    }
}
