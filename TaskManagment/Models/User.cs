using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities;
using TaskManager.Enums;
using TaskManager.ValueObjects;

namespace TaskManager.Models
{
    public class User: Entity
    {
        public User(string name, Email email, List<Profile> profiles, DateTime signUpDate, List<Department> departments)
        {
            Name = name;
            Email = email;
            SignUpDate = signUpDate;
            Departments = departments;
            Profile = profiles;
        }
        //
        public string Name { get;  private set; }
        public Email Email { get;  private set; }
        public DateTime SignUpDate { get;  private set; }
        public bool IsActive { get;  private set; }
        public List<Department> Departments { get;  private set; }
        public List<Profile> Profile { get; private set; }
    }
}
