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
        private List<Department> departments;
        private List<Profile> profiles;
        public User(string name, Email email, DateTime signUpDate, bool isActive, List<Department> department, List<Profile> profile)
        {
            Name = name;
            Email = email;
            SignUpDate = signUpDate;
            IsActive = isActive;
            this.departments = department;
            this.profiles = profile;
        }

        public string Name { get;  private set; }
        public Email Email { get;  private set; }
        public DateTime SignUpDate { get;  private set; }
        public bool IsActive { get;  private set; }
        public List<Department> Departments { get => departments; set => departments = value; }
        public List<Profile> Profile { get => profiles; set => profiles = value; }
    }
}
