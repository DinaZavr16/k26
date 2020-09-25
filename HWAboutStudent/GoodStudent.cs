using System;
using System.Collections.Generic;
using System.Text;

namespace HWAboutStudent
{
    class GoodStudent : Student
    {
        public GoodStudent(string name) : base(name)
        {
            base.state = "good";
        }

        public override void Study()
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
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