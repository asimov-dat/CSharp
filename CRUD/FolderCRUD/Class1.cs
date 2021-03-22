using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD.FolderCRUD
{
    class Delete
    {
        private readonly string myGoodConection = "Data Source=.;Initial Catalog=CRUDtest;Integrated Security=true";

        public void DeleteData(string from, string what, string value)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(myGoodConection))
                {
                    conection.Open();
                    string query = $"delete from {from} where {what} = '{value}'";
                    SqlCommand adapter = new SqlCommand(query, conection);
                    adapter.ExecuteNonQuery();
                    conection.Close();
                }
                Console.WriteLine("Usuario Eliminado con exito");
                Console.ReadKey();
            }
            catch (Exception Error)
            {
                Console.WriteLine($"Error {Error}");
                Console.ReadKey();
            }
        }
    }
}
