using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjTienda
{
    public partial class frmVentaProductos : Form
    {
        public frmVentaProductos()
        {
            InitializeComponent();
        }
        string[,] productos = new string[200,6];
        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            int f = 0;
            int precio = int.Parse(txtPrecio.Text);
            int c = 0;


            try
            {
                if (txtProducto.Text != "" && txtNombre.Text != "" && txtTipo.Text != "" && txtGenero.Text != "" && txtPrecio.Text != "" && txtTalla.Text != "" && txtCantidad.Text != "")
                {

                    productos[f, 0] = txtProducto.Text;
                    productos[f, 1] = txtNombre.Text;
                    productos[f, 2] = txtTipo.Text;
                    productos[f, 3] = txtGenero.Text;
                    productos[f, 4] = int.Parse(txtTalla.Text).ToString();
                    productos[f, 5] = int.Parse(txtPrecio.Text).ToString();
                    productos[f, 6] = int.Parse(txtCantidad.Text).ToString();


                    for (c = 0; c <= 6; c++)
                    {
                        dgvLista.Rows.Add(productos[f, c]);
                    }
                    f++;
                }
            }
            catch (Exception)
            {
                throw;
                
            }


        }

    }
}
