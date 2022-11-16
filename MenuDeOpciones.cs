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
    public partial class MenuDeOpciones : Form
    {
        public MenuDeOpciones()
        {
            InitializeComponent();
        }
      
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
           
           
            registro.Show();
            this.Hide();
            progressBar();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            progressBar();
            frmVentaProductos comprar = new frmVentaProductos();
            
            comprar.Show();
            this.Hide();
           
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
