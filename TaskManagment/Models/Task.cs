using System;
using System.Collections.Generic;
using TaskManager.Enums;
using TaskManager.Entities;

namespace TaskManager.Models
{
    public class Task : Entity
    {
        public Task(string name, ETaskStatus predecessorTaskStatus, DateTime startDate, DateTime endDate)
        {
            this.Name = name;
            this.PredecessorTaskStatus = predecessorTaskStatus;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Status = ETaskStatus.CREATED;
        }

        public string Name { get; private set; }
        public ETaskStatus PredecessorTaskStatus { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public ETaskStatus Status { get; private set; }

        public void SetStarted()
        {
            this.Status = ETaskStatus.STARTED;
        }
        public void SetConcluded() {
            this.Status = ETaskStatus.CONCLUDED;
        }
    }
}