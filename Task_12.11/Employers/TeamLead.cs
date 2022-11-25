using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12._11
{
    /// <summary>
    /// Тимлид
    /// </summary>
    /*class TeamLead
    {
        public TeamLead(string name)
        {
            Name = name;
        }
        public Task MakeATask(List<Executor> executors)
        {
            Console.WriteLine("Напиши описание(одно слово)");
            string description = Console.ReadLine();

            Console.WriteLine("Напиши срок сдачи (формат: гггг.мм.дд");
            string[] date = Console.ReadLine().Split(".");
            int[] date1 = new int[date.Length];
            for (int i = 0; i < date.Length; i++)
            {
                int temp = 0;
                bool a = int.TryParse(date[i], out temp);
                date1[i] = temp;
            }
            DateTime deadline = new DateTime(date1[0], date1[1], date1[2]);


            Console.WriteLine("Напиши имя того кто будет инициатором из этого списка");
            Executor initiator = new Executor("", false);
            foreach (Executor human in executors)
            {
                Console.WriteLine(human.Name);
            }
            bool flag1 = false;
            while (!flag1)
            {   
                string name = Console.ReadLine();
                foreach (Executor human in executors)
                {
                    if (human.Name == name)
                    {
                        initiator = human;
                        flag1 = true;
                    }    
                }
                if (initiator.Name == "")
                {
                    Console.WriteLine("Такого человека нет, попробуй еще раз.");
                    Console.WriteLine("Напиши имя того кто будет инициатором из списка");  
                }
                
            }


            Console.WriteLine("Напиши имя того кто будет исполнителем из этого списка");
            Executor executor = new Executor("", false);
            foreach (Executor human in executors)
            {
                Console.WriteLine(human.Name);
            }
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
            return new Task(description, deadline, initiator, executor, TaskStatus.Appointed);
        }

    }*/
}
