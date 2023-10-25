using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chichi.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_IngresoDirecto_Click(object sender, EventArgs e)
        {
            //Globales.MiUsuarioGlobal.IdUsuario = 1;
            //Globales.MiUsuarioGlobal = Globales.MiUsuarioGlobal.ConsultarPorID();


            Globales.MiFormPrincipal.Show();
            this.Hide();
        }

        private void btn_VerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            Txt_Contrasenia.UseSystemPasswordChar = false;
        }

        private void btn_VerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            Txt_Contrasenia.UseSystemPasswordChar = true;
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift & e.KeyCode == Keys.A)
            {
                Btn_IngresoDirecto.Visible = true;
            }
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_NombreUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(Txt_Contrasenia.Text.Trim()))
            {
                string u = Txt_NombreUsuario.Text.Trim();
                string p = Txt_Contrasenia.Text.Trim();

                int IdLoginOk = Globales.MiUsuarioGlobal.ValidarLogin(u, p);

                if (IdLoginOk > 0)
                {
                    //Hay permiso de ingresar al sistema

                    Globales.MiUsuarioGlobal.IdUsuario = IdLoginOk;

                    //Globales.MiUsuarioGlobal = Globales.MiUsuarioGlobal.ConsultarPorID();

                    Globales.MiFormPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectas", "Error de Validacion", MessageBoxButtons.OK);
                    Txt_Contrasenia.Focus();
                    Txt_Contrasenia.SelectAll();
                }
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Contrasenia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
