using Models;

namespace Data.DTO {
    public class ReservedBookDTO {
        public uint Id { get; set; }
        public Book Book { get; set; }
        public string Comment { get; set; }
    }
}