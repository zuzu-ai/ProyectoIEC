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
        static string dt;
        public static string DtUsuario 
        {
            get { return dt; }
            set { dt = value; } 
        }
        
    }
   
}
