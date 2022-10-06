using System;
using Microsoft.AspNetCore.Mvc;
using Servicies;

namespace Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _SQLBookRepository;

        public BookController(IBookRepository SQLBookRepository) {
            _SQLBookRepository = SQLBookRepository;
        }
        
        [HttpGet("GetReservedBooks")]
        public IActionResult GetReservedBooks() {
            try {
                var reservedBooks = _SQLBookRepository.GetReservedBooks();
                return new JsonResult(reservedBooks);
            }
            catch(Exception ex) {
                return StatusCode(400);
            }
        }

        [HttpGet("GetUnreservedBooks")]
        public IActionResult GetUnreservedBooks() {
            try {
                var unreservedBooks = _SQLBookRepository.GetUnreservedBooks();
                return new JsonResult(unreservedBooks);
            }
            catch(Exception ex) {
                return StatusCode(400);
            }
        }

        [HttpPost("ReserveBook")]
        public IActionResult ReserveBook(uint id, string comment) {
            try {
                _SQLBookRepository.ReserveBook(id, comment);
            }
            catch(Exception ex) {
                return StatusCode(400, ex.Message + " Check if the id you entered is correct.");
            }
            return Ok();
        }

        [HttpPost("UnreserveBook")]
        public IActionResult UnreserveBook(uint id) {
            try {
                _SQLBookRepository.UnreserveBook(id);
            }
            catch(Exception ex) {
                return StatusCode(400, ex.Message + " Check if the id you entered is correct.");
            }
            return Ok();
        }

        [HttpGet("GetReservationHistoryBooks")]
        public IActionResult GetReservationHistoryBooks(uint id) {
            try {
                var test = _SQLBookRepository.GetReservationHistoryRecords(id);
                return new JsonResult(test);
            }
            catch(Exception ex) {
                return StatusCode(400);
            }
        }
    }
}
