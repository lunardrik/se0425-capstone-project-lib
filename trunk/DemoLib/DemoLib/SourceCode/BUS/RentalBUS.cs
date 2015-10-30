using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class RentalBUS
    {

        private RentalDAO RentalDAO
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public void insertRental(RentalDTO rental)
        {
            RentalDAO.insert(rental);
        }

        public void updateRental(RentalDTO rental)
        {
            throw new System.NotImplementedException();
        }

        public RentalDTO getRentalByRentalID(string rentalID)
        {
            throw new System.NotImplementedException();
        }

        public List<RentalDTO> getRentalByUsername(string userID)
        {
            throw new System.NotImplementedException();
        }

        public bool expandRentalTime(DateTime newTime)
        {
            throw new System.NotImplementedException();
        }
    }
}
