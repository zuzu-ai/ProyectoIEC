using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloSeguridad;

namespace CapaControladorSeguridad
{
    
    public class Controlador
    {
        private Sentencias sn = new Sentencias();
        public int funIniciarSesion(string Usuario, string Contrasena)
        {
            int estado = sn.funInicio(Usuario, Contrasena);
            return estado;
        }
        public void funcBloquearUsuario(string Usuario)
        {
            string Consulta = "UPDATE usuario set estado= 0 where usuario= '" + Usuario + "';";
            sn.funcModificar(Consulta);
        }

        public string BuscaDato(string tabla, string campo, string campobuscado, string datoreferencia)
        {
            string dato = sn.BuscaDato(tabla, campo, campobuscado, datoreferencia);

            return dato;
        }

        }
}
