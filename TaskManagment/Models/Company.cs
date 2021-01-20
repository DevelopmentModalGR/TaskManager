using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities;

namespace TaskManager.Models
{
    public class Company : Entity
    {
        private List<User> users;
        public Company(string name)
        {
            Name = name;
            this.users = new List<User>();
        }
        public Company(string name, List<User> user)
        {
            Name = name;
            this.users = user;
        }

        #region attributes        
        public string Name { get; private set; }
        protected List<User> Users { get => users; set => users = value; }
        #endregion

        #region Methods
        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
        public string ListAllUsers()
        {
            var aux = "";
            int count = 1;
            foreach (var item in Users)
            {
                aux += $"{count}.{item.Name} || ";
                count++;
            }
            count = 1;
            return aux;
        }
        #endregion
    }
}
