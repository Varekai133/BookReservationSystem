using System.ComponentModel.DataAnnotations;
#nullable enable

namespace Data.DTO {
    public class BookDTO {
        [Key]
        public uint Id { get; set; }
        public string Title { get; set; }
        public string? Author { get; set; }
    }
}