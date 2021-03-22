using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.FolderCRUD;
using CRUD.FcrudEntity;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {

            string name, lastname, Email;
            //int id;

            //Create create = new Create();
            Console.WriteLine("Write name, lastname, Email, id");

            name = Console.ReadLine();
            lastname = Console.ReadLine();
            Email = Console.ReadLine();
            //id = Int32.Parse(Console.ReadLine());

            //create.CreateDataInTable(name, lastname, Email);
            //-------------------------------------------------------------------------------------------------------

            /*
             * Delete from Table

            string from, what, value;
            Delete delete = new Delete();

            Console.WriteLine("this delete users as follows:\n 1 : from(db, table)\n 2 : what(id, name, email, lastname)\n 3 : value(#,david,@email,alvarez)");
            from = Console.ReadLine();
            what = Console.ReadLine();
            value = Console.ReadLine();

            delete.DeleteData(from, what, value);
            */

            /*
            Update update = new Update();

            update.UpdateWhereId(name, lastname, Email, id);
            */

            //Read

            /*
            Console.WriteLine("Inserte nombre de tabla");
            name = Console.ReadLine();
            Read read = new Read();
            read.ReadTable(name);
            */

            // Create user entity

            CreateEntity.CreateUser(name,lastname,Email);

        }
    }
}
