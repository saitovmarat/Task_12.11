using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12._11
{
    /// <summary>
    /// Отчет по задаче
    /// </summary>
    class Report
    {
        string Text;
        string DateOfCompletion;
        Employee Executor;
        public Report(string text, string dateOfСopmletion, Employee executor)
        {
            Text = text;
            DateOfCompletion = dateOfСopmletion;
            Executor = executor;



        }
    }
}
