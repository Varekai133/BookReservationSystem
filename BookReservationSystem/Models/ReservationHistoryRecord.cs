using System;
using System.ComponentModel.DataAnnotations;

namespace Models {
    public class ReservationHistoryRecord {
        [Key]
        public uint Id { get; set; }
        public Book Book { get; set; }
        public bool Status { get; set; }
        public string Comment { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set;}
    }
}