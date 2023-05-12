using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace db_connection
{
	internal abstract class Config
	{
		public static SqlConnection connection = null;


		private static string _connection_string = null;
		public static string sql_connection_string {
			get
			{
				_connection_string = new SqlConnectionStringBuilder()
				{
					IntegratedSecurity = true,
					InitialCatalog = database_name ?? "",
					DataSource = server_name ?? ""
				}.ConnectionString;

				return _connection_string;
			}
		
		}

		public static string server_name = null;
		public static string database_name = null;

		public static string last_file_path = null;
	}
}
