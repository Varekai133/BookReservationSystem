using Data.DTO;
using Models;

namespace Extensions {
    public static class Extensions {
        public static BookDTO AsDto(this Book book) {
            return new BookDTO {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author
            };
        }

        public static ReservedBookDTO AsDto(this ReservedBook reservedBook) {
            return new ReservedBookDTO {
                Id = reservedBook.Id,
                Book = reservedBook.Book,
                Comment = reservedBook.Comment
            };
        }

        public static ReservationHistoryRecordDTO AsDto(this ReservationHistoryRecord reservationHistoryRecord) {
            return new ReservationHistoryRecordDTO {
                Id = reservationHistoryRecord.Id,
                Book = reservationHistoryRecord.Book,
                Status = reservationHistoryRecord.Status,
                Comment = reservationHistoryRecord.Comment,
                Date = reservationHistoryRecord.Date
            };
        }
    }
}