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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task task = new Task("Exemplo1", ETaskStatus.CONCLUDED, DateTime.Now, DateTime.Now);
            List<Task> tasks = new List<Task>();
            tasks.Add(task);
            Email email = new Email("renato@123.com");
            Role role = new Role("Administrador");
            Profile profile = new Profile(role, true);
            List<Department> departments = new List<Department>();
            departments.AddRange(new List<Department> {
                new Department("Administração"),
                new Department("T.I."),
            });
            CheckoutProcess checkoutprocess = new CheckoutProcess("Pegar manga no quintal dos outros", departments[1], "pegar a manga ue", DateTime.Now, DateTime.Now, tasks);
            List<Profile> profiles = new List<Profile>();
            User user = new User("Renato", email, DateTime.Now, true, departments, profiles);
            User user1 = new User("AndrezinhoReiDelas", email, DateTime.Now, true, departments, profiles);
            List<User> users = new List<User>();
            users.AddRange(new List<User> { user,user1});
            Company company = new Company("ModalGR",users);

            //MessageBox.Show(task.Id.ToString());
            //MessageBox.Show(company.ListAllUsers());

            DataContext db = new DataContext();
            db.Company.Add(company);
            db.User.Add(user);
            db.Task.Add(task);
            db.CheckOutProcess.Add(checkoutprocess);
            db.SaveChanges();
        }
    }
}
