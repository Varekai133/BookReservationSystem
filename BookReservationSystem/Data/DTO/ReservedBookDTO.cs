using System.ComponentModel.DataAnnotations;
using Models;

namespace Data.DTO {
    public class ReservedBookDTO {
        [Key]
        public uint Id { get; set; }
        public Book Book { get; set; }
        public string Comment { get; set; }
    }
}