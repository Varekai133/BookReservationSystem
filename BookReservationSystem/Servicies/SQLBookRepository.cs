using System.Collections.Generic;
using Models;
using Data;
using System.Linq;
using Extensions;
using Data.DTO;

namespace Servicies {
    public class SQLBookRepository : IBookRepository
    {
        private readonly BookSystemDbContext _context;

        public SQLBookRepository(BookSystemDbContext context) => _context = context;

        public List<ReservedBookDTO> GetReservedBooks() {
            var booksInDb = _context.Books.ToList();
            var reservedBooks = _context.ReservedBooks.Select(item => item.AsDto()).ToList();
            return reservedBooks;
        }

        public List<BookDTO> GetUnreservedBooks() {
            var BookIdsOfReservedBooks = _context.ReservedBooks.Select(c => c.Book.Id).ToList();
            var unreservatedBooks = _context.Books
                .Where(c => !BookIdsOfReservedBooks.Contains(c.Id))
                .Select(item => item.AsDto())
                .ToList();
            return unreservatedBooks;
        }

        public void UnreserveBook(uint id) {
            var reservedBook = _context.ReservedBooks.Where(c => c.Book.Id == id).First();
            _context.ReservedBooks.Attach(reservedBook);
            _context.ReservedBooks.Remove(reservedBook);

            var reservationHistoryRecord = new ReservationHistoryRecord {
                Status = false,
                Comment = _context.ReservedBooks
                    .Where(c => c.Book.Id == id)
                    .Select(t => t.Comment)
                    .First(),
                Book = _context.Books.Where(c => c.Id == id).First(),
                Date = System.DateTime.Now
            };
            _context.ReservationHistoryRecords.Add(reservationHistoryRecord);

            _context.SaveChanges();
        }

        public void ReserveBook(uint id, string comment) {
            var book = _context.Books.Where(c => c.Id == id).First();

            var reservedBook = new ReservedBook {
                Comment = comment,
                Book = book
            };
            
            if (!_context.ReservedBooks.Select(c => c.Book.Id).ToList().Contains(id))
                _context.ReservedBooks.Add(reservedBook);
            else throw new System.Exception("This book is already reserved");

            var reservationHistoryRecord = new ReservationHistoryRecord {
                Status = true,
                Comment = comment,
                Book = book,
                Date = System.DateTime.Now
            };
            _context.ReservationHistoryRecords.Add(reservationHistoryRecord);

            _context.SaveChanges();
        }

        public List<ReservationHistoryRecordDTO> GetReservationHistoryRecords(uint id) {
            var booksInDb = _context.Books.ToList();
            var reservationHistoryRecords = _context.ReservationHistoryRecords
                .Where(c => c.Book.Id == id)
                .Select(item => item.AsDto())
                .ToList();
            return reservationHistoryRecords;
        }
    }
}