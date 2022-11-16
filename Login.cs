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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Usuarios(); 
        }
        Dictionary<string, string> usuarios = new Dictionary<string, string>();
        MenuDeOpciones menu = new MenuDeOpciones();
        public void Usuarios()
        {
            usuarios.Add("Nsoto26007", "N2601");
            usuarios.Add("Cpalaios26007", "C2601");
            usuarios.Add("Dchavarria26007", "D2601");
            usuarios.Add("abc1", "add2");
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtContraseña.Text;


            txtContraseña.Clear();
            txtUsuario.Clear();
            this.Hide();
            menu.Show();
            //if (usuarios.ContainsKey(user) && usuarios.ContainsValue(pass))
            //{
            //    txtContraseña.Clear();
            //    txtUsuario.Clear();
            //    this.Hide();
            //    menu.Show();

            //}
            //else
            //{

            //    txtContraseña.Clear();
            //    txtUsuario.Clear();
            //    MessageBox.Show("El usuario ingresado o la contraseña son incorretos vuelva a ingresarlos",
            //        "Intente ingresarlos nuevamente ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //}
          
        }

        private void btoSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir?", "Login",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
          
        }
      
    }
}
