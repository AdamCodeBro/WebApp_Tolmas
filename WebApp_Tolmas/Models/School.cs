using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp_Tolmas.Models {
    public class School {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        //בית ספר אחד - להרבה כיתות. 
        public List<Classroom> Classrooms { get; set; } = new List<Classroom>();
    }
}