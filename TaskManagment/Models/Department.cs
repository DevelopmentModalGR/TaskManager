using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities;

namespace TaskManager.Models
{
    
    public class Department : Entity
    {
        private List<Profile> profile;
        public Department(string name, List<Profile> profiles)
        {
            Name = name;
            this.Profile = new List<Profile>();
            this.profile = profiles;
        }

        public string Name { get;  private set; }

        public List<Profile> Profile { get => profile; set => profile = value; }
    }
}
