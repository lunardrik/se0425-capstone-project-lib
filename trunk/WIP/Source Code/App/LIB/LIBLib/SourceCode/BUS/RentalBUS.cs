using System;
using System.Collections.Generic;

namespace LIB
{
    public class RentalBUS
    {

        private readonly RentalDAO _rentalDao = new RentalDAO();

        public bool InsertRental(RentalDTO rental)
        {
            return _rentalDao.Insert(rental);
        }

        public bool UpdateRental(RentalDTO rental)
        {
            return _rentalDao.Update(rental);
        }

        public List<RentalDTO> GetAllRental()
        {
            return _rentalDao.GetAll();
        }

        public List<RentalDTO> GetRentalByUserId(string userId)
        {
            return _rentalDao.GetByUserId(userId);
        }

        public List<RentalDTO> GetRentalByUserIdPaging(string userId, int page, out int noP)
        {
            int start = (page - 1)*Options.NumberOfRecord + 1;
            int end = page*Options.NumberOfRecord + 1;
            int noR;
            var rs = _rentalDao.GetByUserIdPaging(userId, start, end, out noR);
            noP = (int) Math.Ceiling((double) noR/(double) Options.NumberOfRecord);
            return rs;
        }

        public List<RentalDTO> GetRentalByBarcode(string barcode)
        {
            return _rentalDao.GetByBarcode(barcode);
        }

        public List<RentalDTO> GetRentalByIssuedDate(DateTime issuedDate)
        {
            return _rentalDao.GetByIssuedDate(issuedDate);
        }

    }
}
