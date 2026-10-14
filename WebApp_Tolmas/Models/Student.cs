using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_Tolmas.Models {
    public class Student {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int ClassroomId { get; set; }

        [ForeignKey("ClassroomId")]
        public Classroom Classroom { get; set; }
    }
}