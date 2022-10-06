# BookReservationSystem

* Table **Books** contains all books that are in the system.  
  Table **ReservedBooks** contains all books that are reserved (there is no **status** field, because this table contains books which status is already **true**).  
  Table **ReservationHistoryRecords** contains all reservation records (with statuses and comments) on each book.  

* Status is **true** if book is reserved, else status is **false**.

![test drawio](https://user-images.githubusercontent.com/40802250/194340596-def69683-8498-44ea-9e54-c9f9827825cb.png)
