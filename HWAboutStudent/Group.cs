using System;
using System.Collections.Generic;
using System.Text;

namespace HWAboutStudent
{
    class Group
    {
        string Name;
        List<Student> students = new List<Student>();

        public Group(string name)
        {
            Name = name;
        }

        public void AddStudent(Student stud)
        {
            students.Add(stud);
        }
        public void AddGroupStudents(Group group)
        {
            foreach (Student student in group.students)
            {
                this.students.Add(student);
            }
        }
        public string GetInfo()
        {
            string listStudents = ":";
            foreach (Student st in students)
            {
                listStudents += " " + st.Name + " ";
            }
            return " " + Name + " " + listStudents +".";
        }
        public string GetFullInfo()
        {
            string listStudents = ":";
            foreach (Student st in students)
            {
                listStudents += " " + st.Name + " is " + st.State + " ";
            }

            return " " + Name + " " + listStudents +".";
        }
    }
}