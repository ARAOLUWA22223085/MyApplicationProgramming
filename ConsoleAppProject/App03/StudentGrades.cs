using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {

        public string [] Students { get; set; }

        public int [] Marks  { get; set; }

        public int [] GradeProfile { get; set; }

        public double [] Mean { get; set; }

        public int [] Minimum { get; set; }

        public int [] Maximum { get; set; }


        public StudentGrades()
        {
            Students = new string[]
                    {
                    "Fillian","Dylan","Erith","Georgia",
                    "Harrison","Hamza","Jorge",
                    "Liam","Shantia","Cynthia"
                    };

            GradeProfile = new int[(int)Grade.A + 1];
            Marks = new int[Students.Length];
        }

    }
    /// <Summary>
    /// 
    /// <Summary>

    public void InputMarks()
    {
        throw new NotImplementedException();
    }

    /// <Summary>
    /// 
    /// <Summary>
    public void OutputMarks()
    {
        throw new NotImplementedException();
    }

    /// <Summary>
    /// 
    /// <Summary>
    public Grade ConvertToGrade()
    {
        throw new NotImplementedException();
    }

    /// <Summary>
    /// 
    /// <Summary>
    public void CalculateStats()
    { 
        throw new NotImplementedException();
    }

}
