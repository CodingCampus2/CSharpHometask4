using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    public class Program
    {
        public static Func<Task4, char[,]> TaskSolver;

        static void Main(string[] args)
        {
            TaskSolver = task =>
            {
                // Your solution goes here
                // You can get all needed inputs from task.[Property]
                // Good luck!
                char[,] board = task.Board;

                return board;
            };

            Task4.CheckSolver(TaskSolver);
        }
    }
}
