using System;

namespace QualityTest.Models
{
    public class Student
    {
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public StudentStatus Status;
        public DateTime CreatedAt { get; set; }

        public enum StudentStatus
        {
            Active =1,
            Deactive  =0,
        }

        public bool IsNewStudent()
        {
            return CreatedAt >= DateTime.Now.AddMonths(-2);
        }

        public bool IsDeactive()
        {
            return Status == StudentStatus.Deactive;
        }
    }

    
}