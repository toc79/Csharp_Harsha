using System;

namespace ClassLibrary1
{
    public class Student
    {
        public double SecuredMarks { get; set; }
        public double MaxMarks { get; set; }
        public double Percentage { get; set; }
    }

    //outer class
    public class MarksCalculation
    {
        public void CalculatePercentage(Student s)
        {
            //create object of inner class
            CalculationHelper ch = new CalculationHelper();

            //s.Percentage = s.SecuredMarks/ s.MaxMarks * 100;
            s.Percentage = ch.Multiyply(s.SecuredMarks / s.MaxMarks, 100);
        }

        //inner class
        public class CalculationHelper
        {
            public double Multiyply(double n1, double n2)
            {
                return n1 * n2;
            }
        }
    }
}
