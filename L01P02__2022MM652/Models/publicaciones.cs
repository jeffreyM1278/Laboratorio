using System.ComponentModel.DataAnnotations;

namespace L01P02__2022MM652.Models
{
    public class publicaciones
    {
        [Key]
        public int publicacionId { get; set; }
        public string? titulo { get; set; }
        public string? descripcion { get; set; }
        public int usuarioId { get; set; }

    }
}
