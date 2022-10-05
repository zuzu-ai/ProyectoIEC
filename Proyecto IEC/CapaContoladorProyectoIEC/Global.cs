using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaContoladorProyectoIEC
{
	public class Global
	{
		static DataTable table = new DataTable();
		static string fechat;
		static string usuario;
		static string id;
		static string idtusuario;
		static string nombretusuario;

		public DataTable obtenertabla
		{
			get { return table; }
			set { table = value; }
		}
		public string fechatrabajada
		{
			get { return fechat; }
			set { fechat = value; }
		}

		//Obtiene Usuario
		public string obtieneusuario
		{
			get { return usuario; }
			set { usuario = value; }
		}
		public string obtieneid
		{
			get { return id; }
			set { id = value; }
		}
		public string obtieneidtusuario
		{
			get { return idtusuario; }
			set { idtusuario = value; }
		}
		public string obtienenombretusuario
		{
			get { return nombretusuario; }
			set { nombretusuario = value; }
		}
	}
}
