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
            Task task = new Task(1, "Exemplo1", ETaskStatus.CONCLUDED, DateTime.Now, DateTime.Now);
            Email email = new Email("renato@123.com");
            Role role = new Role("Administrador");
            Profile profile = new Profile(role);
            Department department = new Department("adm");
            List<Department> departments = new List<Department>();
            List<Profile> profiles = new List<Profile>();

            User user = new User("Renato", email, profiles, DateTime.Now, departments);

            //MessageBox.Show(task.Id.ToString());

            /*DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);

            //for Connection
            var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            DbConnection connection = factory.CreateConnection();*/

            DataContext db = new DataContext();
            db.Department.Add(department); // .User.Add(user);
            db.SaveChanges();
        }
    }
}
