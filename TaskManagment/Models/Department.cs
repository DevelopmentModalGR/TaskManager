using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities;
using TaskManager.ValueObjects;

namespace TaskManager.Models
{
    
    public class Department : Entity
    {
        public Department(string name)
        {
            Name = name;
            this.CheckoutProcesses = new List<CheckoutProcess>();
            this.Users = new List<User>();
        }
        public Department(string name, List<User> users)
        {
            Name = name;
            this.CheckoutProcesses = new List<CheckoutProcess>();           
            this.Users = new List<User>();
            this.Users = users;
        }

        public string Name { get;  private set; }
        public virtual ICollection<CheckoutProcess> CheckoutProcesses { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
