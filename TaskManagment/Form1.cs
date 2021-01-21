using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskManager.Models;
using TaskManager.Enums;
using TaskManager.ValueObjects;
using TaskManager.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace TaskManagment
{
    public partial class Form1 : Form
    {
        #region CustomMethods
        public void InitializeDb()
        {
            Task task = new Task("Pegar a manga e sair correndo", ETaskStatus.CONCLUDED, DateTime.Now, DateTime.Now);
            List<Task> tasks = new List<Task>();
            tasks.Add(task);
            Email email = new Email("renato@123.com");
            Role role = new Role("Administrador");
            List<Role> roles = new List<Role>();
            roles.Add(role);
            Profile profile = new Profile("Consultor", roles);
            List<Profile> profiles = new List<Profile>();
            profiles.Add(profile);
            List<Department> departments = new List<Department>();
            departments.AddRange(new List<Department> {
                new Department("Administração", profiles ),
                new Department("T.I.",profiles),
            });
            
            ;
            Company company = new Company("ModalGR");
            User user = new User("Renato", email, DateTime.Now, true,/* departments,*/ profile, company);
            User user1 = new User("AndrezinhoReiDelas", email, DateTime.Now, true, /*departments,*/ profile, company);
            List<User> users = new List<User>();
            CheckoutProcess checkoutprocess = new CheckoutProcess("Pegar manga no quintal dos outros", departments[1], "pegar a manga ue", DateTime.Now, DateTime.Now, tasks);
            users.AddRange(new List<User> { user, user1 });
            

            //MessageBox.Show(task.Id.ToString());
            //MessageBox.Show(company.ListAllUsers());


            DataContext db = new DataContext();
            db.CheckOutProcess.Add(checkoutprocess);
            db.Company.Add(company);
            db.User.Add(user);
            db.Task.Add(task);
            db.Department.Add(departments[1]); //db.Department.Add(departments[1]);
            
            db.SaveChanges();
            
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDb();
        }
    }
}
