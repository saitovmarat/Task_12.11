using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12._11
{
    enum ProjectStatus
    {
        Project,
        ProjectExecution,
        ProjectClosed
    }
    /// <summary>
    /// Проект
    /// </summary>
    class Project
    {
        string Description;
        DateTime Deadline;
        Employee Initiator;
        Employee TeamLeader;
        List<Task> Tasks;
        ProjectStatus Status;
        public Project(string description, DateTime deadline, Employee initiator, Employee teamLeader, List<Task> tasks, ProjectStatus status)
        {
            Description = description;
            Deadline = deadline;
            Initiator = initiator;
            TeamLeader = teamLeader;
            Tasks = tasks;
            Status = status;
        }
        public void ChangeStatus(string a)
        {
            switch (a)
            {
                case "execution":
                    Status = ProjectStatus.ProjectExecution;
                    break;
                case "closed":
                    Status = ProjectStatus.ProjectClosed;
                    break;
                default:
                    break;

            }
            
        }


    }
}
