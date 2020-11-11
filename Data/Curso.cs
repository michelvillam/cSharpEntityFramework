using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadData.Data
{
    [Table("curso")]
    public class Curso
    {
        [Column("curso_id")]
        public int CursoId { get; set; }

        [Column("titulo")]
        public string Titulo { get; set; }

        [Column("descripcion")]
        public string Description { get; set; }

        [Column("fecha_publicacion")]
        public DateTime FechaPublicacion { get; set; }

        [Column("foto_portada")]
        public Byte[] FotoPortada { get; set; }

        public Precio PrecioPromocion { get; set; }

        public ICollection<Comentario> ComentarioLista { get; set; }

        public ICollection<CursoInstructor> CursoInstructors { get; set; }

    }
}