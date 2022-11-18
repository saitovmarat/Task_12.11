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
        string Description;
        DateTime Deadline;
        public Executor Initiator;
        public Executor Executor;
        TaskStatus Status;
        string Report;
        public Task(string description, DateTime deadline, Executor initiator, Executor executor, TaskStatus status)
        {
            Description = description;
            Deadline = deadline;
            Initiator = initiator;
            Executor = executor;
            Status = status;
        }
        public void ChangeStatus(string a)
        {
            switch (a)
            {
                case "appointed":
                    Status = TaskStatus.Appointed;
                    break;
                case "inWork":
                    Status = TaskStatus.InWork;
                    break;
                case "underReview":
                    Status = TaskStatus.UnderReview;
                    break;
                case "completed":
                    Status = TaskStatus.Completed;
                    break;
                default:
                    break;
            }

        }



    }
}
