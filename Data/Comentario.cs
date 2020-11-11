using System.ComponentModel.DataAnnotations.Schema;

namespace ReadData.Data
{
    [Table("comentario")]
    public class Comentario
    {

        [Column("comentario_id")]
        public int ComentarioId { get; set; }

        [Column("alumno")]
        public string Alumno { get; set; }

        [Column("puntuacion")]
        public int Puntuacion { get; set; }

        [Column("comentario_texto")]
        public string ComentarioTexto { get; set; }

        [Column("curso_id")]
        public int CursoId  { get; set; }

        public Curso Curso {get; set;}
        
    }
}