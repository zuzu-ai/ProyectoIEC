using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CapaControladorSeguridad
{
    public class PideDato
    {
        public string dt;
        public string usuario;
        public string id;
        public string DtUsuario 
        {
            get { return dt; }
            set { dt = value; } 
        }

        public string ObtUsuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string ObtID
        {
            get { return id; }
            set { id = value; }
        }
    }
   
}
