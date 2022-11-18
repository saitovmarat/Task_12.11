using System;
using System.Collections.Generic;

namespace Task_12._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Executor executor1 = new Executor("Иван", false);
            Executor executor2 = new Executor("Aртем", false);
            Executor executor3 = new Executor("Никита", false);
            Executor executor4 = new Executor("Илья", false);
            Executor executor5 = new Executor("Ринат", false);
            Executor executor6 = new Executor("Ислам", false);
            Executor executor7 = new Executor("Андрей", false);
            Executor executor8 = new Executor("Роман", false);
            Executor executor9 = new Executor("Петр", false);
            Executor executor10 = new Executor("Александр", false);
            List<Executor> executors = new List<Executor> {executor1, executor2, executor3, executor4, executor5, executor6, executor7, executor8, executor9, executor10 };
            
            Initiator karim = new Initiator("Карим");
            TeamLead marat = new TeamLead("Марат");

            List<Task> tasks = new List<Task>();
            

            Project project = new Project("Cook", new DateTime(2022, 11, 18), karim, marat, tasks, ProjectStatus.Project);
            
            tasks.Add(marat.MakeATask(executors));
            Console.Clear();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1 - добавить задачу \n2 - остановить добавление задач");
                switch (Console.ReadLine())
                {
                    case "1":
                        tasks.Add(marat.MakeATask(executors));
                        break;
                    case "2":
                        flag = false;
                        break;
                    default:
                        continue;
                }
                Console.Clear();
            }
            project.ChangeStatus("execution");

            void GiveATask(Task task)
            {
                Console.WriteLine($"{task.Executor.Name}, напиши: \nберу - взять задачу в работу\nделегирую - делегировать задачу другому исполнителю\nотклоняю - отклонить задачу");
                task.ChangeStatus("appointed");
            }
            foreach(Task task in tasks)
            {
                GiveATask(task);
                executor1.TakeATask(task, executors);
            }
            

        }
    }
}
