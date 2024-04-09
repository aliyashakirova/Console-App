using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    internal class Student
    {
        //Properties
        public string Name { get; set; }
        public string Group { get; set; }
        public int Score { get; set; }

        //Method 
        public void Print ()
        {
            Console.WriteLine($"{Name} - name, {Group} - group, {Score} - score");
        }

        //Constructor:
        public Student (string name, int score)
        {
            Name = name;
            Score = score;
            Group = "3";
        }

    }
}
