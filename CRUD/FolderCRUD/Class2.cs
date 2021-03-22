using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD.FolderCRUD
{
    class Update
    {
        private readonly string myDbCon = "Data Source=.;Initial Catalog=CRUDtest;Integrated Security=true";

        public void UpdateWhereId(string name, string lastname, string email, int id)
        {
            try
            {
                using (SqlConnection conect = new SqlConnection(myDbCon))
                {
                    conect.Open();
                    string query = $"update Ctable set name = @name , lastname = @lastname, Email = @email where ID = @id ";
                    SqlCommand command = new SqlCommand(query, conect);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastname",lastname);
                    command.Parameters.AddWithValue("@email",email);
                    command.Parameters.AddWithValue("@id",id);
                    command.ExecuteNonQuery();
                    conect.Close();
                    Console.WriteLine("The user have been update successfuly :)");
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
