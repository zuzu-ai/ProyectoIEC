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

		public DataTable obtenertabla
		{
			get { return table; }
			set { table = value; }
		}
	}
}
