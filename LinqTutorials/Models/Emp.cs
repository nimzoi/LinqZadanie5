using System;

namespace LinqTutorials.Models
{
    public class Emp
    {
        public int Empno { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public Emp Mgr { get; set; }
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public int? Comm { get; set; }
        public int? Deptno { get; set; }
        public Dept Dept { get; set; }

        public override string ToString()
        {
            return $"{Empno} {Ename} {Job} {Mgr} {HireDate.ToShortDateString()} {Salary} {Comm} {Deptno}";
        }
    }
}