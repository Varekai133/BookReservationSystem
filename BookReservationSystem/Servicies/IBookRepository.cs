using System.Collections.Generic;
using Models;

namespace Servicies {
    public interface IBookRepository {
        void ReserveBook(uint id, string comment);
        void UnreserveBook(uint id);
        List<ReservedBook> GetReservedBooks();
        List<Book> GetUnreservedBooks();
        List<ReservationHistoryRecord> GetReservationHistoryRecords(uint id);
    }
}