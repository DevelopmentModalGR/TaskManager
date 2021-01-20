using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities;

namespace TaskManager.Models
{
    public class Department : Entity
    {
        public Department(string name)
        {
            Name = name;
        }

        public string Name { get;  private set; }
    }
}
