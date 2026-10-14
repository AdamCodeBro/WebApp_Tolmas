using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_Tolmas.Models {
    public class Classroom {
        [Key]
        public int Id { get; set; }
        public int GradeLevel { get; set; } 
        public string ClassName { get; set; } 
        public string Subject { get; set; }   

        public int SchoolId { get; set; }
        [ForeignKey("SchoolId")]
        public School School { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
