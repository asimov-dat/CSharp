using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CRUD.FolderCRUD
{
    class Read
    {
        public readonly string conection = "Data Source=.; Initial Catalog=CRUDtest; Integrated Security=True";

        public void ReadTable(string Tabla)
        {
            try
            {
                using (SqlConnection conect = new SqlConnection(conection))
                {
                    string query = $"Select * From {Tabla}";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conect);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        Console.WriteLine($"{row[0]} {row[1]} {row[2]} {row[3]}");
                    }
                    Console.ReadKey();
                }
            }
            catch (Exception Error)
            {
                Console.WriteLine($"Error {Error}");
            }
        }
    }
}
