using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.Models;

namespace CRUD.FcrudEntity
{
    class CreateEntity
    {
        public static void CreateUser(string name, string lastname, string email)
        {
            using (CRUDtestEntities Mdb = new CRUDtestEntities())
            {
                Ctable ctable = new Ctable();
                ctable.name = name;
                ctable.lastname = lastname;
                ctable.Email = email;

                Mdb.Ctables.Add(ctable);
                Mdb.SaveChanges();
            }
        }
    }
}
