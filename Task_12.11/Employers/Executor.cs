using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12._11
{
    /// <summary>
    /// Исполнитель, наследуется от Рабочего
    /// </summary>
    /*class Executor
    {
        public bool HavingTask;
        public Executor(string name, bool havingTask)
        {
            Name = name;
            HavingTask = havingTask;
        }
        public void TakeATask(Task task, List<Executor> executors)
        {
            Console.WriteLine($"{task.Executor.Name}, напиши: \nберу - взять задачу в работу\nделегирую - делегировать задачу другому исполнителю\nотклоняю - отклонить задачу");
            task.ChangeStatus("appointed");
            switch (Console.ReadLine())
            {
                case "беру":
                    task.ChangeStatus("inWork");
                    task.Executor.HavingTask = true;
                    break;

                case "делегирую":
                    executors.Remove(task.Initiator);
                    Console.WriteLine("Напиши имя того, кому делегируешь из этого списка?");                   
                    foreach (Executor human in executors)
                    {
                        Console.WriteLine(human.Name);
                    }
                    Executor executor = new Executor("", false);
                    bool flag2 = false;
                    while (!flag2)
                    {
                        string name = Console.ReadLine();
                        foreach (Executor human in executors)
                        {
                            if (human.Name == name)
                            {
                                executor = human;
                                flag2 = true;
                            }
                        }
                        if (executor.Name == "")
                        {
                            Console.WriteLine("Такого человека нет, попробуй еще раз.");
                            Console.WriteLine("Напиши имя того кто будет инициатором из списка");
                        }
                    }
                    task.Executor = executor;
                    executors.Add(task.Executor);
                    break;

                case "отклоняю":
                    executors.Remove(task.Executor);
                    Executor executor2 = new Executor("", false);
                    bool flag3 = false;
                    while (!flag3)
                    {
                        string name = Console.ReadLine();
                        foreach (Executor human in executors)
                        {
                            if (human.Name == name)
                            {
                                executor = human;
                                flag2 = true;
                            }
                        }
                        if (executor2.Name == "")
                        {
                            Console.WriteLine("Такого человека нет, попробуй еще раз.");
                            Console.WriteLine("Напиши имя того кто будет инициатором из списка");
                        }
                    }
                    task.Executor = executor2;
                    executors.Add(task.Executor);
                    TakeATask(task, executors);
                    break;


            }
        }

    }*/
}
