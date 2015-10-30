using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIB
{
    public class BookRegisterBUS
    {
        private BookRegisterDAO _bookRegisterDao = new BookRegisterDAO();

        public bool InsertBookRegister(BookRegisterDTO bookRegister)
        {
            return _bookRegisterDao.Insert(bookRegister);
        }

        public bool UpdateBookRegister(BookRegisterDTO bookRegisterDto)
        {
            return _bookRegisterDao.Update(bookRegisterDto);
        }

        public bool DeleteBookRegister(string userId, string isbn, DateTime registerDate)
        {
            return _bookRegisterDao.Delete(userId, isbn, registerDate);
        }

        public List<BookRegisterDTO> GetAllBookRegister()
        {
            return _bookRegisterDao.GetAll();
        }

        public List<BookRegisterDTO> GetBookRegisterByIsbn(string isbn)
        {
            return _bookRegisterDao.GetByIsbn(isbn);
        }

        public List<BookRegisterDTO> GetBookRegisterByRegisterDate(DateTime registerDate)
        {
            return _bookRegisterDao.GetByRegisterDate(registerDate);
        }

        public List<BookRegisterDTO> GetBookRegisterByStatus(int status)
        {
            return _bookRegisterDao.GetByStatus(status);
        }

        public List<BookRegisterDTO> GetBookRegisterByUserId(string userId)
        {
            return _bookRegisterDao.GetByUserId(userId);
        }

        public List<BookRegisterDTO> GetBookRegisterByUserIdPaging(string userId, int page, out int noP)
        {
            int start = (page - 1) * Options.NumberOfRecord + 1;
            int end = page * Options.NumberOfRecord + 1;
            int noR;
            var rs = _bookRegisterDao.GetByUserIdPaging(userId, start, end, out noR);
            noP = (int)Math.Ceiling((double)noR / (double)Options.NumberOfRecord);
            return rs;
        }

        public BookRegisterDTO GetBookRegisterByPrimaryKey(string userId, string isbn, DateTime registerDate)
        {
            return _bookRegisterDao.GetByPrimaryKey(userId, isbn, registerDate);
        }

        public List<BookRegisterDTO> GetBookRegisterByCreatedDate(DateTime createdDate)
        {
            return _bookRegisterDao.GetByCreatedDate(createdDate);
        }

        public List<BookRegisterDTO> GetBookRegisterByStatusAndCreatedDate(BookRegisterStatus status, DateTime createdDate)
        {
            return _bookRegisterDao.GetByStatusAndCreatedDate(status, createdDate);
        }
    }
}
