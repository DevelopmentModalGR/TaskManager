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
            Email email = new Email("renato@123.com");
            List<Department> departments = new List<Department>();
            departments.AddRange(new List<Department> {
                new Department("Administração"),
                new Department("T.I."),
            });

            ;
            Company company = new Company("ModalGR");
            User user = new User("Renato", email, DateTime.Now, true, departments, company);
            User user1 = new User("AndrezinhoReiDelas", email, DateTime.Now, true, departments, company);
            List<User> users = new List<User>();
            Task task = new Task("Pegar a manga e sair correndo", ETaskStatus.CONCLUDED, DateTime.Now, DateTime.Now, users);
            Task task2 = new Task("dEU RUIM ", ETaskStatus.CONCLUDED, DateTime.Now, DateTime.Now);
            List<Task> tasks = new List<Task>();
            tasks.Add(task); tasks.Add(task2);
            CheckoutProcess checkoutprocess = new CheckoutProcess("Pegar manga no quintal dos outros", departments[1], "pegar a manga ue", DateTime.Now, DateTime.Now, tasks);
            users.AddRange(new List<User> { user, user1 });
            user1.Tasks = tasks;
            user.Tasks.Add(task2);


            //MessageBox.Show(task.Id.ToString());
            //MessageBox.Show(company.ListAllUsers());


            DataContext db = new DataContext();
            db.CheckOutProcess.Add(checkoutprocess);
            db.Company.Add(company);
            db.User.Add(user);
            db.Task.Add(task);
            db.Department.Add(departments[1]); 
            db.SaveChanges();
            db.Department.Add(departments[0]);
            db.Task.Add(task2);
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
