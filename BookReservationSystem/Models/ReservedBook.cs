using System.ComponentModel.DataAnnotations;

namespace Models {
    public class ReservedBook {
        [Key]
        public uint Id { get; set; }
        public Book Book { get; set; }
        //public bool Status { get; set; }
        public string Comment { get; set; }
    }
}