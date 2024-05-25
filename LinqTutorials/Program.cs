using System;
using LinqTutorials.Models;
using System.Linq;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            LinqTasks.Task1().ToList().ForEach(e => Console.WriteLine(FormatEmp(e)));

            Console.WriteLine("\nTask 2:");
            LinqTasks.Task2().ToList().ForEach(e => Console.WriteLine(FormatEmp(e)));

            Console.WriteLine("\nTask 3:");
            Console.WriteLine(LinqTasks.Task3());

            Console.WriteLine("\nTask 4:");
            LinqTasks.Task4().ToList().ForEach(e => Console.WriteLine(FormatEmp(e)));

            Console.WriteLine("\nTask 5:");
            LinqTasks.Task5().ToList().ForEach(o => Console.WriteLine($"{o}"));

            Console.WriteLine("\nTask 6:");
            LinqTasks.Task6().ToList().ForEach(o => Console.WriteLine($"{o}"));

            Console.WriteLine("\nTask 7:");
            LinqTasks.Task7().ToList().ForEach(o => Console.WriteLine($"{o}"));

            Console.WriteLine("\nTask 8:");
            Console.WriteLine(LinqTasks.Task8());

            Console.WriteLine("\nTask 9:");
            Console.WriteLine(FormatEmp(LinqTasks.Task9()));

            Console.WriteLine("\nTask 10:");
            LinqTasks.Task10().ToList().ForEach(o => Console.WriteLine($"{o}"));

            Console.WriteLine("\nTask 11:");
            LinqTasks.Task11().ToList().ForEach(o => 
                Console.WriteLine($"{{name: \"{o.GetType().GetProperty("name").GetValue(o)}\", numOfEmployees: {o.GetType().GetProperty("numOfEmployees").GetValue(o)}}}"));

            Console.WriteLine("\nTask 12:");
            LinqTasks.Task12().ToList().ForEach(e => Console.WriteLine(FormatEmp(e)));

            Console.WriteLine("\nTask 13:");
            Console.WriteLine(LinqTasks.Task13(new int[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 }));

            Console.WriteLine("\nTask 14:");
            LinqTasks.Task14().ToList().ForEach(d => Console.WriteLine(FormatDept(d)));

            Console.WriteLine("\nTask 15:");
            LinqTasks.Task15().ToList().ForEach(o => Console.WriteLine($"{o}"));
        }

        static string FormatEmp(Emp emp)
        {
            if (emp == null) return "null";
            return $"{emp.Empno} {emp.Ename} {emp.Job} {(emp.Mgr != null ? emp.Mgr.Empno.ToString() : "null")} {emp.HireDate.ToShortDateString()} {emp.Salary} {(emp.Comm.HasValue ? emp.Comm.Value.ToString() : "null")} {(emp.Deptno.HasValue ? emp.Deptno.Value.ToString() : "null")}";
        }

        static string FormatDept(Dept dept)
        {
            if (dept == null) return "null";
            return $"{dept.Deptno} {dept.Dname} {dept.Loc}";
        }
    }
}
