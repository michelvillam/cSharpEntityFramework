using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ReadData.Data
{
    [Table("instructor")]
    public class Instructor
    {

        [Column("instructor_id")]
        public int InstructorId { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("apellidos")]
        public string Apellidos { get; set; }

        [Column("grado")]
        public string Grado { get; set; }

        [Column("foto_perfil")]
        public byte[] FotoPerfil { get; set; }

        public ICollection<CursoInstructor> CursoInstructors { get; set; }

    }
}