using System.ComponentModel.DataAnnotations;

namespace L01P02__2022MM652.Models
{
    public class roles
    {

        [Key]
        public int rolId { get; set; }
        public string? rolNombre { get; set; }
    }
}
