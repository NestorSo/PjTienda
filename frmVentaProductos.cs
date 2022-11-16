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
            int cantidad = int.Parse(txtCantidad.Text); 


            try
            {
                if (txtProducto.Text != "" && txtNombre.Text != "" && txtTipo.Text != "" && txtGenero.Text != "" && txtPrecio.Text != "" && txtTalla.Text != "" && txtCantidad.Text != "")
                {

                    productos[f, 0] = txtProducto.Text;
                    productos[f, 1] = txtNombre.Text;
                    productos[f, 2] = txtTipo.Text;
                    productos[f, 3] = txtGenero.Text;
                    productos[f, 4] = int.Parse(txtTalla.Text).ToString();
                    productos[f, 5] = precio.ToString();
                    productos[f, 6] = cantidad.ToString();


                    for (c = 0; c <= 6; c++)
                    {
                        dgvLista.Rows.Add(productos[f, c]);
                    }
                    f++;
                }
                txtProducto.Text = txtNombre.Text = txtTipo.Text = txtGenero.Text = txtPrecio.Text = txtTalla.Text = txtCantidad.Text = "";
                txtProducto.Focus();
            }
            catch (Exception)
            {
                throw;
                
            }
            progressBar();

        }
        public void subTotal()
        {
           
            float subtotal = 0;
            for (int f= 0; f<productos.Length; f++)
            {
                for (int i = 0; i < productos.Length;i ++)
                {
                    
                }
            }
        }
        public void Monto()
        {
            float total = 0;
            int contador;
            contador= dgvLista.Rows.Count;
            

            for(int i =0; i < contador; i++)
            {
                total += float.Parse(dgvLista.Rows[i].Cells[7].Value.ToString());
            }
            lblMontoPagar.Text = total.ToString();
        }
        public void progressBar()
        {
            // maximum Indica el valor máxilloo de la barrs
            progressBar1.Maximum = 1000000;
            //minimum indica el valor mínimo de la barra
            progressBar1.Minimum = 0;
            //value indica desde donde se va в comenzar a llenar la parra, la nuestra iniciars desde cero
            progressBar1.Value = 0;
            //step indica el paso de la barra, entre más pequeño sea La barra tardará was en cargar
            progressBar1.Step = 1;
            //el ciclo for cargará la barra
            for (int i = progressBar1.Minimum; i < progressBar1.Maximum; i = i + progressBar1.Step)
            {

                progressBar1.PerformStep();
            }
        }


    }
}
