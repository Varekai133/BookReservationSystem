using System;
using System.ComponentModel.DataAnnotations;
using Models;

namespace Data.DTO {
    public class ReservationHistoryRecordDTO {
        public uint Id { get; set; }
        public Book Book { get; set; }
        public bool Status { get; set; }
        public string Comment { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set;}
    }
}