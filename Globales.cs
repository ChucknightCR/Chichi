using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chichi
{
    public static  class Globales
    {

        public static Form MiFormPrincipal = new Formularios.FrmPrincipalMDI();
        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

    }
}
