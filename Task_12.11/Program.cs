using System;
using System.Collections.Generic;
using System.Threading;

namespace Task_12._11
{
    class Program
    {
        static Employee DoesThisPersonWorkThere(List<Employee> employees, string name)
        {
            Employee flag = new Employee("flag", new List<Task>(), new List<Task>());
            foreach (Employee human in employees)
            {
                if (name.ToLower() == human.Name.ToLower())
                {
                    return human;
                }
            }
            return flag;
        }
        static void DisplayEmployeesInformation(List<Employee> employees)
        {

            foreach (Employee human in employees)
            {
                Console.Write($"{human.Name}   ");
                
            }
        }
        static void TheMainProcess(List<Employee> employeesToDisplay, Task task)
        {
            employeesToDisplay.Remove(task.Executor);

            Console.WriteLine($"{task.Executor.Name}, ты берешь задачу {task.Description}, делегируешь или отклоняешь? \n(варианты ответа: беру, делегирую, отклоняю)");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "беру":
                    task.Status = TaskStatus.InWork;
                    Console.Clear();
                    break;
                case "делегирую":
                    bool taskApprooved = false;
                    while (!taskApprooved)
                    {
                        Console.WriteLine("Напиши имя человека, кому хочешь делегировать свою задачу из этого списка.");
                        DisplayEmployeesInformation(employeesToDisplay);
                        string name = Console.ReadLine().ToLower();
                        if (DoesThisPersonWorkThere(employeesToDisplay, name).Name != "flag")
                        {
                            taskApprooved = true;
                            task.Executor.RemoveTask(task);
                            DoesThisPersonWorkThere(employeesToDisplay, name).AddTo_ToDoList(task);
                            task.Executor = DoesThisPersonWorkThere(employeesToDisplay, name);
                            TheMainProcess(employeesToDisplay, task);
                            break;
                        }
                        Console.WriteLine("Этого человека нет в списке! Попробуй еще раз.");
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    break;
                case "отклоняю":
                    Console.WriteLine($"{task.Initiator.Name}, ты отклоняешь эту задачу или передаешь другому человеку? (варианты ответа: отклоняю, передаю)");
                    string answerOnRejection = Console.ReadLine().ToLower();
                    switch (answerOnRejection)
                    {
                        case "отклоняю":
                            task.Executor.RemoveTask(task);
                            break;
                        case "передаю":
                            bool taskApprooved2 = false;
                            while (!taskApprooved2)
                            {
                                Console.WriteLine("Напиши имя человека, кому хочешь делегировать свою задачу из этого списка.");
                                DisplayEmployeesInformation(employeesToDisplay);
                                string name = Console.ReadLine().ToLower();
                                if (DoesThisPersonWorkThere(employeesToDisplay, name).Name != "flag")
                                {
                                    taskApprooved2 = true;
                                    task.Executor.RemoveTask(task);
                                    DoesThisPersonWorkThere(employeesToDisplay, name).AddTo_ToDoList(task);
                                    task.Executor = DoesThisPersonWorkThere(employeesToDisplay, name);
                                    TheMainProcess(employeesToDisplay, task);
                                    break;
                                }
                                Console.WriteLine("Этого человека нет в списке! Попробуй еще раз.");
                                Thread.Sleep(3000);
                                Console.Clear();
                            }
                            break;
                    }
                    break;

            }
        }
        static void OutputFinalInformation(List<Employee> employees)
        {
            foreach(Employee human in employees)
            {
                human.DisplayInformation();
            }
        }
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                {new Employee("Иван", new List<Task>(), new List<Task>())},
                {new Employee("Aртем", new List<Task>(), new List<Task>())},
                {new Employee("Никита", new List<Task>(), new List<Task>())},
                {new Employee("Илья", new List<Task>(), new List<Task>())},
                {new Employee("Ринат", new List<Task>(), new List<Task>())},
                {new Employee("Ислам", new List<Task>(), new List<Task>())},
                {new Employee("Андрей", new List<Task>(), new List<Task>())},
                {new Employee("Роман", new List<Task>(), new List<Task>())},
                {new Employee("Петр", new List<Task>(), new List<Task>())},
                {new Employee("Александр", new List<Task>(), new List<Task>())}
            };
            List<Task> tasks = new List<Task>
            {
                {new Task("Do Tumakov", new DateTime(2022, 12, 12), employees[0], employees[1], TaskStatus.Appointed)},
                {new Task("Do Homework", new DateTime(2022, 11, 9), employees[1], employees[2], TaskStatus.Appointed)},
                {new Task("Dance", new DateTime(2022, 11, 8), employees[2], employees[3], TaskStatus.Appointed)},
                {new Task("Sing", new DateTime(2022, 11, 6), employees[3], employees[4], TaskStatus.Appointed)},
                {new Task("Drink beer", new DateTime(2022, 11, 4), employees[4], employees[5], TaskStatus.Appointed)},
                {new Task("Run from there", new DateTime(2022, 11, 5), employees[5], employees[6], TaskStatus.Appointed)},
                {new Task("Fly", new DateTime(2022, 11, 2), employees[6], employees[7], TaskStatus.Appointed)},
                {new Task("Swim", new DateTime(2022, 11, 3), employees[7], employees[8], TaskStatus.Appointed)},
                {new Task("Buy food", new DateTime(2022, 11, 1), employees[8], employees[9], TaskStatus.Appointed)},
                {new Task("Scream like you are on fire", new DateTime(2022, 11, 1), employees[9], employees[0], TaskStatus.Appointed)},
                {new Task("Sleep", new DateTime(2022, 11, 18), employees[1], employees[8], TaskStatus.Appointed)},
                {new Task("Pray for offset", new DateTime(2022, 11, 19), employees[7], employees[2], TaskStatus.Appointed)},

            };
            #region *Task Adding*
            employees[0].AddTo_ToDoList(tasks[0]);
            employees[0].AddTo_ToDoList(tasks[1]);
            employees[0].AddTo_ToCheckList(tasks[11]);

            employees[1].AddTo_ToDoList(tasks[2]);
            employees[1].AddTo_ToCheckList(tasks[10]);

            employees[2].AddTo_ToDoList(tasks[3]);
            employees[2].AddTo_ToDoList(tasks[4]);
            employees[2].AddTo_ToCheckList(tasks[9]);

            employees[3].AddTo_ToDoList(tasks[5]);
            employees[3].AddTo_ToCheckList(tasks[8]);

            employees[4].AddTo_ToDoList(tasks[6]);
            employees[4].AddTo_ToCheckList(tasks[7]);

            employees[5].AddTo_ToDoList(tasks[7]);
            employees[5].AddTo_ToCheckList(tasks[6]);
            employees[5].AddTo_ToCheckList(tasks[0]);

            employees[6].AddTo_ToDoList(tasks[8]);
            employees[6].AddTo_ToCheckList(tasks[5]);

            employees[7].AddTo_ToDoList(tasks[9]);
            employees[7].AddTo_ToCheckList(tasks[4]);

            employees[8].AddTo_ToDoList(tasks[10]);
            employees[8].AddTo_ToCheckList(tasks[3]);

            employees[9].AddTo_ToDoList(tasks[11]);
            employees[9].AddTo_ToCheckList(tasks[2]);
            employees[9].AddTo_ToCheckList(tasks[1]);
            #endregion
            Project project = new Project("Cooking", new DateTime(2022, 01, 11), employees[2], employees[1], tasks, ProjectStatus.Project);
            project.ChangeStatus();

            
            foreach(Task task in tasks)
            {
                List<Employee> employeesToDisplay = employees;                
                employeesToDisplay.Remove(task.Initiator);

                TheMainProcess(employeesToDisplay, task); 
            }
            OutputFinalInformation(employees);
        }
    }
}
