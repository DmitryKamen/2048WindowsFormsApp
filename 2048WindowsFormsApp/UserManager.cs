using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048WindowsFormsApp
{
    public class UserManager
    {
        public static string Path = "resulr.json";

        public static List<User> GetAll()
        {
            if (FileManager.Exist(Path))
            {
                var jsonData = FileManager.Get(Path);
                var users = JsonConvert.DeserializeObject<List<User>>(jsonData);
                return users;
            }
            return new List<User>();
        }

        public static void Add(User newUser)
        {
            var users = GetAll();
            users.Add(newUser);
            var jsonData = JsonConvert.SerializeObject(users);
            FileManager.Replace(Path, jsonData);
        }
    }
}
