using System;
using System.Collections.Generic;
using System.Text;

namespace HWAboutStudent
{
    class BadStudent : Student
    {
        public BadStudent(string name) : base(name)
        {
            base.state = "bad";
        }

        public override void Study()
        {
            Relax();
            Relax();
            Relax();
            Relax();
            Read();
        }
        public override void Read()
        {

        }
        public override void Write()
        {

        }
        public override void Relax()
        {

        }
    }
}