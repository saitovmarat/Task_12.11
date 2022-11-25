using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12._11
{
    enum TaskStatus
    {
        Appointed,
        InWork,
        UnderReview,
        Completed
    }
    class Task
    {
        public string Description;
        DateTime Deadline;
        public Employee Initiator;
        public Employee Executor;
        public TaskStatus Status;
        Report Report;
        public Task(string description, DateTime deadline, Employee initiator, Employee executor, TaskStatus status)
        {
            Description = description;
            Deadline = deadline;
            Initiator = initiator;
            Executor = executor;
            Status = status;
        }
        public TaskStatus ShowTaskStatus()
        {
            return Status;
        }



    }
}
