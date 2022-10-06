using System.ComponentModel.DataAnnotations;
#nullable enable

namespace Models {
    public class Book {
        [Key]
        public uint Id { get; set; }
        public string Title { get; set; }
        public string? Author { get; set; }
    }
}