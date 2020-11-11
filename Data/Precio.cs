using System.ComponentModel.DataAnnotations.Schema;

namespace ReadData.Data
{
    [Table("precio")]
    public class Precio
    {
        [Column("precio_id")]
        public int PrecioId{get; set;}

        [Column("precio_actual")]
        public decimal PrecioActual{get; set;}

        [Column("promocion")]
        public decimal Promocion{get; set;}

        [Column("curso_id")]
        public int CursoId{get; set;}

        public Curso Curso{get; set;}
        
    }
}