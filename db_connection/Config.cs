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
		public static string sql_connection_string
		{
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

		public static Dictionary<string, string> words = new Dictionary<string, string>()	// this dictionary need for translating russian word
		{																					// to english -- iTextPdf doesn't support russian :(
			{ "а", "a" }, 
			{ "б", "b" },
			{ "в", "v" },
			{ "г", "g" },
			{ "д", "d" },
			{ "е", "e" },
			{ "ё", "yo" },
			{ "ж", "zh" },
			{ "з", "z" },
			{ "и", "i" },
			{ "й", "j" },
			{ "к", "k" },
			{ "л", "l" },
			{ "м", "m" },
			{ "н", "n" },
			{ "о", "o" },
			{ "п", "p" },
			{ "р", "r" },
			{ "с", "s" },
			{ "т", "t" },
			{ "у", "u" },
			{ "ф", "f" },
			{ "х", "h" },
			{ "ц", "c" },
			{ "ч", "ch" },
			{ "ш", "sh" },
			{ "щ", "sch" },
			{ "ъ", "j" },
			{ "ы", "i" },
			{ "ь", "j" },
			{ "э", "e" },
			{ "ю", "yu" },
			{ "я", "ya" },
			{ "А", "A" },
			{ "Б", "B" },
			{ "В", "V" },
			{ "Г", "G" },
			{ "Д", "D" },
			{ "Е", "E" },
			{ "Ё", "Yo" },
			{ "Ж", "Zh" },
			{ "З", "Z" },
			{ "И", "I" },
			{ "Й", "J" },
			{ "К", "K" },
			{ "Л", "L" },
			{ "М", "M" },
			{ "Н", "N" },
			{ "О", "O" },
			{ "П", "P" },
			{ "Р", "R" },
			{ "С", "S" },
			{ "Т", "T" },
			{ "У", "U" },
			{ "Ф", "F" },
			{ "Х", "H" },
			{ "Ц", "C" },
			{ "Ч", "Ch" },
			{ "Ш", "Sh" },
			{ "Щ", "Sch" },
			{ "Ъ", "J" },
			{ "Ы", "I" },
			{ "Ь", "J" },
			{ "Э", "E" },
			{ "Ю", "Yu" },
			{ "Я", "Ya" },
		};
	}
}
