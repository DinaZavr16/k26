using System;
using System.Collections.Generic;
using System.Text;

namespace HWAboutStudent
{
    abstract class Student
    {
        protected string state;
        protected string name;
        public string Name
        {
            get { return name; }
        }
        public string State
        {
            get { return state; }
        }

        public Student(string name)
        {
            this.name = name;
        }
        public abstract void Study();
        public virtual void Read()
        {

        }
        public virtual void Write()
        {

        }
        public virtual void Relax()
        {

        }
    }
}