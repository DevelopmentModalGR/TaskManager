using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities;

namespace TaskManager.Models
{
    public class Company : Entity
    {
        public Company(string name)
        {
            Name = name;
        }

        #region attributes        
        public string Name { get; private set; }
        public List<User> Users { get; private set; }
        #endregion

        #region Methods

        #endregion
    }
}
