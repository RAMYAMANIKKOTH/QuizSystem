using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoice
{
    public enum Subject
    {
        English,
        Math,
        GK
    }
     public class Student
    {
       
        [Key]
        public int StudentID { get; private set; }
        public string studentName { get; set; }       
        public decimal Result { get; private set; }
        public Subject Subjectname{ get; set; }
        [Required]
        [StringLength(50)]
        public string emailAddress { get; set; }

    }
    

}

