using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capstone.DTO;
using Capstone.DAO;

namespace Capstone.BUS
{
    class PublisherBUS
    {
        public int insertPublisher(PublisherDTO publisher)
        {
            PublisherDAO dao = new PublisherDAO();
            return dao.insertPublisher(publisher);
        }

        public int deletePublisher(PublisherDTO publisher)
        {
            PublisherDAO dao = new PublisherDAO();
            return dao.deletePublisher(publisher);
        }

        public int updatePublisher(PublisherDTO publisher)
        {
            PublisherDAO dao = new PublisherDAO();
            return dao.updatePublisher(publisher);
        }

        public PublisherDTO getPublisherById(int publisherId)
        {
            PublisherDAO dao = new PublisherDAO();
            return dao.getPublisherById(publisherId);
        }
    }
}
