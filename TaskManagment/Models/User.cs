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
       // private List<Department> departments;
        public User(string name, Email email, DateTime signUpDate, bool isActive, /*List<Department> department,*/ Profile profile, Company company)
        {
            Name = name;
            Email = email;
            SignUpDate = signUpDate;
            IsActive = isActive;
            //this.departments = department;
            this.Profile = profile;
            Company = company;
        }

        public string Name { get;  private set; }
        public Email Email { get;  private set; }
        public DateTime SignUpDate { get;  private set; }
        public bool IsActive { get;  private set; }
        public bool IsAdmin { get; private set; }
        //protected List<Department> Departments { get => departments; set => departments = value; }
        protected Profile Profile { get; private set; }
        public Company Company { get; private set; }

        public override string ToString()
        {
            return $"{this.Name}";
        }

        public void SetAsAdmin()
        {
            this.IsAdmin = true;
        }
    }
}
