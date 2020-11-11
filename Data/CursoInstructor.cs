using System.ComponentModel.DataAnnotations.Schema;

namespace ReadData.Data
{
    [Table("curso_instructor")]
    public class CursoInstructor
    {

        [Column("curso_id")]
        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        [Column("instructor_id")]
        public int InstructorId { get; set; }

        public Instructor Instructor { get; set; }

    }
}