using System;

namespace Collegge
{
    public class Student
    {
        //properties
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public Branch branch { get; set; } //contains reference to object of Branch class, thats represents the branch that the current student belongs to.
    }
}
