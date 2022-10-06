using System.Collections.Generic;
using Data.DTO;
using Models;

namespace Servicies {
    public interface IBookRepository {
        void ReserveBook(uint id, string comment);
        void UnreserveBook(uint id);
        List<ReservedBookDTO> GetReservedBooks();
        List<BookDTO> GetUnreservedBooks();
        List<ReservationHistoryRecordDTO> GetReservationHistoryRecords(uint id);
    }
}