using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Ex1.DataBindingDemo
{
    public class Student
    {
        public string StudentName { get; set; }
        public bool IsEnrolled { get; set; }
    }
    public class StudentList : ObservableCollection<Student>
    {

    }
}
