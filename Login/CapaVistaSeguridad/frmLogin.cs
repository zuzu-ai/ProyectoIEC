using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorSeguridad;
using static CapaControladorSeguridad.PideDato;

namespace CapaVistaSeguridad
{
    public partial class frmLogin : Form
    {
        private Controlador ctr = new Controlador();
        
        public frmLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text== "Nombre usuario")
            {
                txtUsuario.Text = "";
            }
        }
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Nombre usuario")
            {
                txtContraseña.Text = "";
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text.Trim();
            string Contraseña = txtContraseña.Text.Trim();
            int contador = 0;
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            if (contador <= 3)
            {
                Encriptar encriptar = new Encriptar();
                string password = encriptar.metodoEncryptString(key, txtContraseña.Text);
                Console.WriteLine(password);
                if (ctr.funIniciarSesion(txtUsuario.Text, password) == 1)
                {                    
                    DialogResult = DialogResult.OK;                   
                    MessageBox.Show(" Bienvenido " + txtUsuario.Text);                   
                }
                else
                {
                    contador++;
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    funLimpiar();
                }
            }
            if (contador > 3)
            {
                ctr.funcBloquearUsuario(txtUsuario.Text);
                MessageBox.Show("El usuario a sido Bloqueado por seguridad.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                funLimpiar();
            }
        }
        public void funLimpiar()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            lblClave.Text = "";
            lblUsuario.Text = "";
            adClave.Visible = false;
            adUser.Visible = false;
        }       
        private void btnPassword_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            btnPassword.Visible = false;
            btnPasswordn.Visible = true;
        }        
        private void btnPasswordn_Click(object sender, EventArgs e)
        {
            txtContraseña .UseSystemPasswordChar = true;
            btnPassword.Visible = true;
            btnPasswordn.Visible = false;
        }
        public void funValidarUsuario()
        {
            if (txtUsuario.Text.Trim() != "")
            {
                lblUsuario.Text = "";
                adUser.Visible = false;
            }
            else
            {
                lblUsuario.Text = "Debe ingresar usuario.";
                adUser.Visible = true;
            }
        }        
        public void funValidarClave()
        {
            if (txtContraseña.Text.Trim() != "")
            {
                lblClave.Text = "";
                adClave.Visible = false;
            }
            else
            {
                lblClave.Text = "Debe ingresar contraseña.";
                adClave.Visible = true;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            funValidarUsuario();
        }
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            funValidarClave();
        }        
        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;//elimina el sonido
                funValidarClave();
                btnLogin.Focus();//llama al evento click del boton
            }
        }        
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;//elimina el sonido
                txtContraseña.Focus();
                funValidarUsuario();
            }
        }
    }
}

