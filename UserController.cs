using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;

namespace NotesApp
{
    public class UserController
    {
        private string path = "users.json";

        private User user;
        private List<User> lstUsers;
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public void PutUser(string username, string email, string password)
        {
            user = new User(username, email, password);
            lstUsers = GetUsers();
            lstUsers.Add(user);
            File.WriteAllText(path, JsonConvert.SerializeObject(lstUsers, Formatting.Indented));
        }
        public void PutUser(User u)
        {
            lstUsers = GetUsers();
            lstUsers.Add(u);
            File.WriteAllText(path, JsonConvert.SerializeObject(lstUsers, Formatting.Indented));
        }
        /// <summary>
        /// Read
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            List<User> list = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(path));
            if(list == null)
                list = new List<User>();
            return list;
        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public void UpdateUser(string username, string email, string password)
        {
            lstUsers = GetUsers();
            foreach (User u in lstUsers)
            {
                if(u.Email == email)
                {
                    u.Password = password;
                    u.Username = username;
                }
            }
            File.WriteAllText(path, JsonConvert.SerializeObject(lstUsers, Formatting.Indented));
        }
        public void UpdateUser(User u)
        {
            lstUsers = GetUsers();
            foreach (User us in lstUsers)
            {
                if (us.Email == u.Email)
                {
                    us.Password = u.Password;
                    us.Username = u.Username;
                    us.Notes = u.Notes;
                }
            }
            File.WriteAllText(path, JsonConvert.SerializeObject(lstUsers, Formatting.Indented));
        }
        /// <summary>
        /// Delete del singolo studente
        /// </summary>
        /// <param name="email"></param>
        public void DeleteUser(string email)
        {
            lstUsers = GetUsers();
            lstUsers.RemoveAll(u => u.Email == email);
        }
        /// <summary>
        /// Read del singolo studente.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public User GetUser(string email)
        {
            lstUsers = GetUsers();
            user = lstUsers.Find(u => u.Email == email);
            return user;
        }

        public bool ExistingEmail(string email)
        {
            lstUsers = GetUsers();
            if (lstUsers.Exists(u => u.Email == email)) 
                return true;
            return false;
        }

        public bool FindUser(User us)
        {
            lstUsers = GetUsers();
            foreach (User u in lstUsers)
                if(u.Email == us.Email && u.Password == us.Password)
                    return true;
            return false;
        }
    }
}
