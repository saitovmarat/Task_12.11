using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12._11
{

    class Employee
    {
        /// <summary>
        /// Работник
        /// </summary>
        public string Name;
        public List<Task> ToDo = new List<Task>();
        List<Task> ToCheck = new List<Task>();
        public Employee(string name, List<Task> toDo, List<Task> toCheck)
        {
            Name = name;
            ToDo = toDo;
            ToCheck = toCheck;

        }
        public void AddTo_ToDoList(Task task)
        {
            ToDo.Add(task);
        }
        public void AddTo_ToCheckList(Task task)
        {
            ToCheck.Add(task);
        }
        public void RemoveTask(Task task)
        {
            foreach (Task mission in ToDo)
            {
                if (mission == task)
                {
                    ToDo.Remove(mission);
                    break;
                }
            }
        }
        public void DisplayInformation()
        {
            Console.Write($"{Name}, задачи -  ");
            foreach (Task task in ToDo)
            {
                Console.WriteLine($"{task.Description}, {task.ShowTaskStatus()};");
            }
        }
    }
}
