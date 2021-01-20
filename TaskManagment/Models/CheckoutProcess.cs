using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities;

namespace TaskManager.Models
{
   public class CheckoutProcess : Entity
    {
        public string Name { get; private set; }
        public Department Department { get; private set; }
        public string Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public List<Task> Tasks { get; private set; }

        public bool CheckProcessStatus()
        {
            return false;
        }
        public bool CheckTasksStatus()
        {
            return false;
        }
    }
}
