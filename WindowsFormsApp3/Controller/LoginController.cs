using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Controller
{
    internal class LoginController
    {
        //Create
        public void AddUser(User user)
        {
            using (BazaDanniEntities2 db = new BazaDanniEntities2())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        //Read
        public List<User> GetAllUsers()
        {
            using (BazaDanniEntities2 db = new BazaDanniEntities2())
            {
                return db.Users.ToList();
            }
        }
        //Update
        public void UpdateUser(int id ,User user)
        {
            using (BazaDanniEntities2 db = new BazaDanniEntities2())
            {
                var userToUpdate = db.Users.Where(u => u.Id == id).FirstOrDefault();
                userToUpdate = user;
                db.Users.AddOrUpdate(user);
                db.SaveChanges();
            }
        }

        //Delete

        public void RemoveUser(int id)
        {
            using (BazaDanniEntities2 db = new BazaDanniEntities2())
            {
                var userToDelete = db.Users.Where(u => u.Id == id).FirstOrDefault();
                db.Users.Remove(userToDelete);
                db.SaveChanges();
            }
        } 
    }
}
