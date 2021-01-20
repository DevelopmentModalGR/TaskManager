using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entities;

namespace TaskManager.Models
{
    public class Checklist : Entity
    {
        public Checklist(string name, string description, DateTime initialDate, DateTime finalDate, List<Task> tasks)
        {
            Name = name;
            Description = description;
            InitialDate = initialDate;
            FinalDate = finalDate;
            Tasks = tasks;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime InitialDate { get; private set; }
        public DateTime FinalDate { get; private set; }
        public List<Task> Tasks { get; set; }

        public void StartTask(Task task)
        {
            task.SetStarted();

            //implementar inicialização da task
            //verifica se PredecessorTaskStatus == true
        }

        public void EndTask(Task task)
        {
            //implementar atualização da task
        }

        public void DeleteTask(Task task)
        {
            //implementar remoção da task
        }

        public void UpdateTask(Task task)
        {
            //implementar atualização da task
        }

    }
}
