using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD.FolderCRUD
{
    class Create
    {
        private readonly string myDbConection = @"Data Source=.;Initial Catalog=CRUDtest;Integrated Security=True";

        public void CreateDataInTable(string name, string lastname, string Email)
        {
            try
            {
                using (SqlConnection conection = new SqlConnection(myDbConection))
                {
                    conection.Open();
                    string query = $"insert into Ctable values ('{name}','{lastname}','{Email}')";
                    SqlDataAdapter codeLine = new SqlDataAdapter(query, conection);
                    codeLine.SelectCommand.ExecuteNonQuery();
                    conection.Close();

                }
                Console.WriteLine("Usuario insertado con exito XD");
                Console.ReadKey();
            }
            catch (Exception Error)
            {

                Console.WriteLine($"Error {Error.Message}");
            }
        }
    }
}
